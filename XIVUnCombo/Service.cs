using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace XIVUncombo;

/// <summary>
/// Dalamud and plugin services.
/// </summary>
internal class Service
{
    /// <summary>
    /// Gets or sets the plugin configuration.
    /// </summary>
    internal static PluginConfiguration Configuration { get; set; } = null!;

    /// <summary>
    /// Gets or sets the plugin icon replacer.
    /// </summary>
    internal static IconReplacer IconReplacer { get; set; } = null!;

    /// <summary>
    /// Gets or sets the plugin address resolver.
    /// </summary>
    internal static PluginAddressResolver Address { get; set; } = null!;

    /// <summary>
    /// Gets the Dalamud plugin interface.
    /// </summary>
    [PluginService]
    internal static IDalamudPluginInterface Interface { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud chat gui.
    /// </summary>
    [PluginService]
    internal static IChatGui ChatGui { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud client state.
    /// </summary>
    [PluginService]
    internal static IClientState ClientState { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud command manager.
    /// </summary>
    [PluginService]
    internal static ICommandManager CommandManager { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud data manager.
    /// </summary>
    [PluginService]
    internal static IDataManager DataManager { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud texture provider.
    /// </summary>
    [PluginService]
    internal static ITextureProvider TextureProvider { get; private set; } = null!;

    /// <summary>
    /// Gets the Dalamud plugin log.
    /// </summary>
    [PluginService]
    internal static IPluginLog PluginLog { get; private set; } = null!;
}
