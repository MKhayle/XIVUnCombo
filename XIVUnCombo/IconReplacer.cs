using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Dalamud.Hooking;
using Dalamud.Plugin.Services;
using XIVUncombo.Uncombos;

namespace XIVUncombo;

/// <summary>
/// This class facilitates the icon replacing.
/// </summary>
internal sealed partial class IconReplacer : IDisposable
{
    private readonly List<CustomUncombo> customCombos;
    private readonly Hook<IsIconReplaceableDelegate> isIconReplaceableHook;
    private readonly Hook<GetIconDelegate> getIconHook;

    private IntPtr actionManager = IntPtr.Zero;

    /// <summary>
    /// Initializes a new instance of the <see cref="IconReplacer"/> class.
    /// </summary>
    public IconReplacer(IGameInteropProvider gameInteropProvider)
    {
        this.customCombos = Assembly.GetAssembly(typeof(CustomUncombo))!.GetTypes()
            .Where(t => !t.IsAbstract && IsDescendant(t, typeof(CustomUncombo)))
            .Select(t => Activator.CreateInstance(t))
            .Cast<CustomUncombo>()
            .ToList();

        this.getIconHook = gameInteropProvider.HookFromAddress<GetIconDelegate>(FFXIVClientStructs.FFXIV.Client.Game.ActionManager.Addresses.GetAdjustedActionId.Value, this.GetIconDetour);
        this.isIconReplaceableHook = gameInteropProvider.HookFromAddress<IsIconReplaceableDelegate>(Service.Address.IsActionIdReplaceable, this.IsIconReplaceableDetour);

        this.getIconHook.Enable();
        this.isIconReplaceableHook.Enable();
    }

    private static bool IsDescendant(Type clazz, Type ancestor)
    {
        if (clazz.BaseType == null) return false;
        if (clazz.BaseType == ancestor) return true;
        return IsDescendant(clazz.BaseType, ancestor);
    }

    private delegate ulong IsIconReplaceableDelegate(uint actionID);

    private delegate uint GetIconDelegate(IntPtr actionManager, uint actionID);

    /// <inheritdoc/>
    public void Dispose()
    {
        this.getIconHook?.Dispose();
        this.isIconReplaceableHook?.Dispose();
    }

    /// <summary>
    /// Calls the original hook.
    /// </summary>
    /// <param name="actionID">Action ID.</param>
    /// <returns>The result from the hook.</returns>
    internal uint OriginalHook(uint actionID)
        => this.getIconHook.Original(this.actionManager, actionID);

    private unsafe uint GetIconDetour(IntPtr actionManager, uint actionID)
    {
        this.actionManager = actionManager;

        try
        {
            if (Service.ClientState.LocalPlayer == null)
                return this.OriginalHook(actionID);

            var level = Service.ClientState.LocalPlayer?.Level ?? 0;

            foreach (var combo in this.customCombos)
            {
                if (combo.TryInvoke(actionID, level, out var newActionID))
                    return newActionID;
            }

            return this.OriginalHook(actionID);
        }
        catch (Exception ex)
        {
            Service.PluginLog.Error(ex, "Don't crash the game");
            return this.OriginalHook(actionID);
        }
    }

    private ulong IsIconReplaceableDetour(uint actionID) => 1;
}
