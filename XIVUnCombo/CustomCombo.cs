using System;
using System.Linq;

using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.ClientState.JobGauge.Types;
using Dalamud.Game.ClientState.Objects.Enums;
using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Game.ClientState.Statuses;
using Dalamud.Utility;
using XIVUncombo.Attributes;

namespace XIVUncombo.Combos;

/// <summary>
/// Base class for each combo.
/// </summary>
internal abstract partial class CustomCombo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomCombo"/> class.
    /// </summary>
    protected CustomCombo()
    {
        var presetInfo = this.Preset.GetAttribute<CustomComboInfoAttribute>();
        this.JobID = presetInfo.JobID;
        this.ClassID = this.JobID switch
        {
            ADV.JobID => ADV.ClassID,
            BLM.JobID => BLM.ClassID,
            BRD.JobID => BRD.ClassID,
            DRG.JobID => DRG.ClassID,
            MNK.JobID => MNK.ClassID,
            NIN.JobID => NIN.ClassID,
            PLD.JobID => PLD.ClassID,
            SCH.JobID => SCH.ClassID,
            SMN.JobID => SMN.ClassID,
            WAR.JobID => WAR.ClassID,
            WHM.JobID => WHM.ClassID,
            _ => 0xFF,
        };
    }

    /// <summary>
    /// Gets the preset associated with this combo.
    /// </summary>
    protected internal abstract CustomComboPreset Preset { get; }

    /// <summary>
    /// Gets the class ID associated with this combo.
    /// </summary>
    protected byte ClassID { get; }

    /// <summary>
    /// Gets the job ID associated with this combo.
    /// </summary>
    protected byte JobID { get; }

    /// <summary>
    /// Performs various checks then attempts to invoke the combo.
    /// </summary>
    /// <param name="actionID">Starting action ID.</param>
    /// <param name="level">Player level.</param>
    /// <param name="lastComboMove">Last combo action ID.</param>
    /// <param name="comboTime">Combo timer.</param>
    /// <param name="newActionID">Replacement action ID.</param>
    /// <returns>True if the action has changed, otherwise false.</returns>
    public bool TryInvoke(uint actionID, byte level, uint lastComboMove, float comboTime, out uint newActionID)
    {
        newActionID = 0;

        if (!IsEnabled(this.Preset))
            return false;

        var classJobID = LocalPlayer!.ClassJob.Id;

        if (classJobID >= 8 && classJobID <= 15)
            classJobID = DOH.JobID;

        if (classJobID >= 16 && classJobID <= 18)
            classJobID = DOL.JobID;

        if (this.JobID != ADV.JobID && this.ClassID != ADV.ClassID &&
            this.JobID != classJobID && this.ClassID != classJobID)
            return false;

        var resultingActionID = this.Invoke(actionID, lastComboMove, comboTime, level);

        if (resultingActionID == 0 || actionID == resultingActionID)
            return false;

        newActionID = resultingActionID;
        return true;
    }

    /// <summary>
    /// Invokes the combo.
    /// </summary>
    /// <param name="actionID">Starting action ID.</param>
    /// <param name="lastComboActionID">Last combo action.</param>
    /// <param name="comboTime">Current combo time.</param>
    /// <param name="level">Current player level.</param>
    /// <returns>The replacement action ID.</returns>
    protected abstract uint Invoke(uint actionID, uint lastComboActionID, float comboTime, byte level);
}

/// <summary>
/// Passthrough methods and properties to IconReplacer. Shortens what it takes to call each method.
/// </summary>
internal abstract partial class CustomCombo
{
    /// <summary>
    /// Gets the player or null.
    /// </summary>
    protected static IPlayerCharacter? LocalPlayer
        => Service.ClientState.LocalPlayer;

    /// <summary>
    /// Calls the original hook.
    /// </summary>
    /// <param name="actionID">Action ID.</param>
    /// <returns>The result from the hook.</returns>
    protected static uint OriginalHook(uint actionID)
        => Service.IconReplacer.OriginalHook(actionID);

    /// <summary>
    /// Compare the original hook to the given action ID.
    /// </summary>
    /// <param name="actionID">Action ID.</param>
    /// <returns>A value indicating whether the action would be modified.</returns>
    protected static bool IsOriginal(uint actionID)
        => Service.IconReplacer.OriginalHook(actionID) == actionID;

    /// <summary>
    /// Determine if the given preset is enabled.
    /// </summary>
    /// <param name="preset">Preset to check.</param>
    /// <returns>A value indicating whether the preset is enabled.</returns>
    protected static bool IsEnabled(CustomComboPreset preset)
        => (int)preset < 100 || Service.Configuration.IsEnabled(preset);

}
