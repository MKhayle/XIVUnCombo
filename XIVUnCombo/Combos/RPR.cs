using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class RPR
{
    public const byte JobID = 39;

    public const uint
        // Single Target
        Slice = 24373,
        WaxingSlice = 24374,
        InfernalSlice = 24375,
        // AoE
        SpinningScythe = 24376,
        NightmareScythe = 24377,
        // Soul Reaver
        Gibbet = 24382,
        Gallows = 24383,
        Guillotine = 24384,
        BloodStalk = 24389,
        UnveiledGibbet = 24390,
        UnveiledGallows = 24391,
        GrimSwathe = 24392,
        Gluttony = 24393,
        VoidReaping = 24395,
        CrossReaping = 24396,
        GrimReaping = 24397,
        // Generators
        SoulSlice = 24380,
        SoulScythe = 24381,
        // Sacrifice
        ArcaneCircle = 24405,
        PlentifulHarvest = 24385,
        // Shroud
        Enshroud = 24394,
        Communio = 24398,
        LemuresSlice = 24399,
        LemuresScythe = 24400,
        // Misc
        ShadowOfDeath = 24378,
        Harpe = 24386,
        Soulsow = 24387,
        HarvestMoon = 24388,
        HellsIngress = 24401,
        HellsEgress = 24402,
        Regress = 24403,
        // DT
        Sacrificium = 36969,
        ExecutionerGibet = 36970,
        ExecutionerGallows = 36971,
        ExecutionerGuillotine = 36972,
        Perfectio = 36973;

    public static class Levels
    {
        public const byte
            WaxingSlice = 5,
            HellsIngress = 20,
            HellsEgress = 20,
            SpinningScythe = 25,
            InfernalSlice = 30,
            NightmareScythe = 45,
            BloodStalk = 50,
            GrimSwathe = 55,
            SoulSlice = 60,
            SoulScythe = 65,
            SoulReaver = 70,
            Regress = 74,
            Gluttony = 76,
            Enshroud = 80,
            Soulsow = 82,
            HarvestMoon = 82,
            EnhancedShroud = 86,
            LemuresScythe = 86,
            PlentifulHarvest = 88,
            Communio = 90;
    }
}

internal class ReaperUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.ReaperUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.ReaperUnveiledUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return RPR.BloodStalk;
            }

            if (actionID == BLU.BLU2)
            {
                return RPR.UnveiledGibbet;
            }

            if (actionID == BLU.BLU3)
            {
                return RPR.UnveiledGallows;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperRegressUncombo))
        {
            if (actionID == BLU.BLU4)
            {
                return RPR.HellsIngress;
            }

            if (actionID == BLU.BLU5)
            {
                return RPR.HellsEgress;
            }

            if (actionID == BLU.BLU6)
            {
                return RPR.Regress;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperVoidReapingUncombo))
        {
            if (actionID == BLU.BLU7)
            {
                return RPR.Gibbet;
            }

            if (actionID == BLU.BLU8)
            {
                return RPR.VoidReaping;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperCrossReapingUncombo))
        {

            if (actionID == BLU.BLU9)
            {
                return RPR.Gallows;
            }

            if (actionID == BLU.BLU10)
            {
                return RPR.CrossReaping;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperGrimReapingUncombo))
        {

            if (actionID == BLU.BLU11)
            {
                return RPR.Guillotine;
            }

            if (actionID == BLU.BLU12)
            {
                return RPR.GrimReaping;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperHarvestMoonUncombo))
        {
            if (actionID == BLU.BLU13)
            {
                return RPR.Soulsow;
            }

            if (actionID == BLU.BLU14)
            {
                return RPR.HarvestMoon;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperLemureUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return RPR.BloodStalk;
            }

            if (actionID == BLU.BLU15)
            {
                return RPR.GrimSwathe;
            }

            if (actionID == BLU.BLU16)
            {
                return RPR.LemuresSlice;
            }

            if (actionID == BLU.BLU17)
            {
                return RPR.LemuresScythe;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperSacrificiumUncombo))
        {
            if (actionID == BLU.BLU18)
            {
                return RPR.Gluttony;
            }

            if (actionID == BLU.BLU19)
            {
                return RPR.Sacrificium;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperExecutionerGibbetUncombo))
        {
            if (actionID == BLU.BLU7)
            {
                return RPR.Gibbet;
            }

            if (actionID == BLU.BLU20)
            {
                return RPR.ExecutionerGibet;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperExecutionerGallowsUncombo))
        {

            if (actionID == BLU.BLU8)
            {
                return RPR.Gallows;
            }

            if (actionID == BLU.BLU21)
            {
                return RPR.ExecutionerGallows;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperExecutionerGuillotineUncombo))
        {

            if (actionID == BLU.BLU9)
            {
                return RPR.Guillotine;
            }

            if (actionID == BLU.BLU22)
            {
                return RPR.ExecutionerGuillotine;
            }
        }

        if (IsEnabled(CustomComboPreset.ReaperPerfectioUncombo))
        {
            if (actionID == BLU.BLU23)
            {
                return RPR.Communio;
            }

            if (actionID == BLU.BLU24)
            {
                return RPR.Perfectio;
            }
        }

        return actionID;
    }
}