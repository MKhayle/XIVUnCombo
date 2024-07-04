using System;
using System.Collections.Generic;
using System.Linq;

using Dalamud.Configuration;
using Dalamud.Utility;
using Newtonsoft.Json;
using XIVUncombo.Attributes;
using XIVUncombo.Combos;

namespace XIVUncombo;

/// <summary>
/// Plugin configuration.
/// </summary>
[Serializable]
public class PluginConfiguration : IPluginConfiguration
{
    private static readonly Dictionary<CustomComboPreset, CustomComboPreset[]> ConflictingCombos;
    private static readonly Dictionary<CustomComboPreset, CustomComboPreset?> ParentCombos;  // child: parent

    static PluginConfiguration()
    {
        ConflictingCombos = Enum.GetValues<CustomComboPreset>()
            .Distinct() // Prevent ArgumentExceptions from adding the same int twice, should not be seen anymore
            .ToDictionary(
                preset => preset,
                preset => preset.GetAttribute<ConflictingCombosAttribute>()?.ConflictingPresets ?? Array.Empty<CustomComboPreset>());

        ParentCombos = Enum.GetValues<CustomComboPreset>()
            .Distinct() // Prevent ArgumentExceptions from adding the same int twice, should not be seen anymore
            .ToDictionary(
                preset => preset,
                preset => preset.GetAttribute<ParentComboAttribute>()?.ParentPreset);
    }

    /// <summary>
    /// Gets or sets the configuration version.
    /// </summary>
    public int Version { get; set; } = 5;

    /// <summary>
    /// Gets or sets the collection of enabled combos.
    /// </summary>
    [JsonProperty("EnabledActionsV5")]
    public HashSet<CustomComboPreset> EnabledActions { get; set; } = new();

    /// <summary>
    /// Gets or sets the collection of enabled combos.
    /// </summary>
    [JsonProperty("EnabledActionsV4")]
    public HashSet<CustomComboPreset> EnabledActions4 { get; set; } = new();

    /// <summary>
    /// Gets or sets a value indicating whether to hide the children of a feature if it is disabled.
    /// </summary>
    public bool HideChildren { get; set; } = false;

    /// <summary>
    /// Save the configuration to disk.
    /// </summary>
    public void Save()
        => Service.Interface.SavePluginConfig(this);

    /// <summary>
    /// Gets a value indicating whether a preset is enabled.
    /// </summary>
    /// <param name="preset">Preset to check.</param>
    /// <returns>The boolean representation.</returns>
    public bool IsEnabled(CustomComboPreset preset)
        => this.EnabledActions.Contains(preset);

    /// <summary>
    /// Gets an array of conflicting combo presets.
    /// </summary>
    /// <param name="preset">Preset to check.</param>
    /// <returns>The conflicting presets.</returns>
    public CustomComboPreset[] GetConflicts(CustomComboPreset preset)
        => ConflictingCombos[preset];

    /// <summary>
    /// Gets the parent combo preset if it exists, or null.
    /// </summary>
    /// <param name="preset">Preset to check.</param>
    /// <returns>The parent preset.</returns>
    public CustomComboPreset? GetParent(CustomComboPreset preset)
        => ParentCombos[preset];
}
