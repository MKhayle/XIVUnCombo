using System;
using System.Linq;

using Dalamud.Game;
using Dalamud.Game.Command;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using XIVUncombo.Attributes;
using XIVUncombo.Interface;

namespace XIVUncombo;

/// <summary>
/// Main plugin implementation.
/// </summary>
public sealed partial class XIVUncombo : IDalamudPlugin
{
    private const string Command = "/puncombo";

    private readonly WindowSystem windowSystem;
    private readonly ConfigWindow configWindow;

    /// <summary>
    /// Initializes a new instance of the <see cref="XIVUncombo"/> class.
    /// </summary>
    /// <param name="pluginInterface">Dalamud plugin interface.</param>
    /// <param name="sigScanner">Dalamud signature scanner.</param>
    /// <param name="gameInteropProvider">Dalamud game interop provider.</param>
    public XIVUncombo(
        IDalamudPluginInterface pluginInterface,
        ISigScanner sigScanner,
        IGameInteropProvider gameInteropProvider)
    {
        pluginInterface.Create<Service>();

        Service.Configuration = pluginInterface.GetPluginConfig() as PluginConfiguration ?? new PluginConfiguration();
        Service.Address = new PluginAddressResolver();
        Service.Address.Setup((SigScanner)sigScanner);

        Service.IconReplacer = new IconReplacer(gameInteropProvider);

        this.configWindow = new(this);
        this.windowSystem = new("XIV Uncombo");
        this.windowSystem.AddWindow(this.configWindow);

        Service.Interface.UiBuilder.OpenConfigUi += this.OnOpenConfigUi;
        Service.Interface.UiBuilder.Draw += this.windowSystem.Draw;

        Service.CommandManager.AddHandler(Command, new CommandInfo(this.OnCommand)
        {
            HelpMessage = "Open a window to edit XIVUncombo settings.",
            ShowInHelp = true,
        });
    }

    /// <inheritdoc/>
    public string Name => "XIV Uncombo";

    /// <inheritdoc/>
    public void Dispose()
    {
        Service.CommandManager.RemoveHandler(Command);

        Service.Interface.UiBuilder.OpenConfigUi -= this.OnOpenConfigUi;
        Service.Interface.UiBuilder.Draw -= this.windowSystem.Draw;

        Service.IconReplacer?.Dispose();
    }

    private void OnOpenConfigUi()
    {
        if (Service.Configuration.AutoJobChange)
        {
            string job = Service.ClientState.LocalPlayer?.ClassJob.Id != null ? CustomComboInfoAttribute.JobIDToName((byte)Service.ClientState.LocalPlayer?.ClassJob.Id) : Service.Configuration.CurrentJobTab;
            if (job is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar"
                || Service.Configuration.CurrentJobTab is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar")
                job = "Paladin";
            Service.Configuration.CurrentJobTab = job;
        }

        this.configWindow.IsOpen = true;
    }

    private void OnCommand(string command, string arguments)
    {
        var argumentsParts = arguments.Split();

        switch (argumentsParts[0])
        {
            case "setall":
                {
                    foreach (var preset in Enum.GetValues<CustomComboPreset>())
                    {
                        Service.Configuration.EnabledActions.Add(preset);
                    }

                    Service.ChatGui.Print("All SET");
                    Service.Configuration.Save();
                    break;
                }

            case "unsetall":
                {
                    foreach (var preset in Enum.GetValues<CustomComboPreset>())
                    {
                        Service.Configuration.EnabledActions.Remove(preset);
                    }

                    Service.ChatGui.Print("All UNSET");
                    Service.Configuration.Save();
                    break;
                }

            default:
                if (Service.Configuration.AutoJobChange)
                {
                    string job = Service.ClientState.LocalPlayer?.ClassJob.Id != null ? CustomComboInfoAttribute.JobIDToName((byte)Service.ClientState.LocalPlayer?.ClassJob.Id) : Service.Configuration.CurrentJobTab;
                    if (job is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar"
                        || Service.Configuration.CurrentJobTab is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar")
                        job = "Paladin";
                    Service.Configuration.CurrentJobTab = job;
                }

                this.configWindow.Toggle();
                break;
        }

        Service.Configuration.Save();
    }

}
