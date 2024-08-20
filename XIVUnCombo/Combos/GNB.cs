using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class GNB
{
    public const byte JobID = 37;

    public const uint
        KeenEdge = 16137,
        NoMercy = 16138,
        BrutalShell = 16139,
        DemonSlice = 16141,
        SolidBarrel = 16145,
        GnashingFang = 16146,
        SavageClaw = 16147,
        DemonSlaughter = 16149,
        WickedTalon = 16150,
        SonicBreak = 16153,
        Continuation = 16155,
        JugularRip = 16156,
        AbdomenTear = 16157,
        EyeGouge = 16158,
        BowShock = 16159,
        BurstStrike = 16162,
        FatedCircle = 16163,
        Bloodfest = 16164,
        Hypervelocity = 25759,
        DoubleDown = 25760,
        FatedBrand = 36936,
        ReignOfBeasts = 36937,
        NobleBlood = 36938,
        LionHeart = 36939;

    public static class Levels
    {
        public const byte
            NoMercy = 2,
            BrutalShell = 4,
            SolidBarrel = 26,
            BurstStrike = 30,
            DemonSlaughter = 40,
            SonicBreak = 54,
            BowShock = 62,
            Continuation = 70,
            FatedCircle = 72,
            Bloodfest = 76,
            EnhancedContinuation = 86,
            CartridgeCharge2 = 88,
            DoubleDown = 90;
    }
}

internal class GunbreakerUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.GunbreakerUnCombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.GunbreakerGnashingUnCombo))
        {
            if (actionID == BLU.BLU1)
            {
                return GNB.GnashingFang;
            }

            if (actionID == BLU.BLU2)
            {
                return GNB.SavageClaw;
            }

            if (actionID == BLU.BLU3)
            {
                return GNB.WickedTalon;
            }
        }

        if (IsEnabled(CustomComboPreset.GunbreakerConsecutionUncombo))
        {
            if (actionID == BLU.BLU4)
            {
                return GNB.JugularRip;
            }

            if (actionID == BLU.BLU5)
            {
                return GNB.AbdomenTear;
            }

            if (actionID == BLU.BLU6)
            {
                return GNB.EyeGouge;
            }
        }

        if (IsEnabled(CustomComboPreset.GunbreakerHypervelocityUncombo))
        {
            if (actionID == BLU.BLU7)
            {
                return GNB.Hypervelocity;
            }
        }

        if (IsEnabled(CustomComboPreset.GunbreakerFatedBrandUncombo))
        {
            if (actionID == BLU.BLU8)
            {
                return GNB.FatedBrand;
            }
        }

        if (IsEnabled(CustomComboPreset.GunbreakerReignUncombo))
        {
            if (actionID == BLU.BLU9)
            {
                return GNB.ReignOfBeasts;
            }

            if (actionID == BLU.BLU10)
            {
                return GNB.NobleBlood;
            }

            if (actionID == BLU.BLU11)
            {
                return GNB.LionHeart;
            }
        }

        return actionID;
    }
}