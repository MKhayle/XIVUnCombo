using System;

using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class MCH
{
    public const byte JobID = 31;

    public const uint
        // Single target
        CleanShot = 2873,
        HeatedCleanShot = 7413,
        SplitShot = 2866,
        HeatedSplitShot = 7411,
        SlugShot = 2868,
        HeatedSlugshot = 7412,
        // Charges
        GaussRound = 2874,
        Ricochet = 2890,
        DoubleCheck = 36979,
        Checkmate = 36980,
        // AoE
        SpreadShot = 2870,
        AutoCrossbow = 16497,
        Scattergun = 25786,
        // Rook
        RookAutoturret = 2864,
        RookOverdrive = 7415,
        AutomatonQueen = 16501,
        QueenOverdrive = 16502,
        // Other
        Wildfire = 2878,
        Detonator = 16766,
        Hypercharge = 17209,
        BarrelStabilizer = 7414,
        HeatBlast = 7410,
        BlazingShot = 36978,
        HotShot = 2872,
        Drill = 16498,
        Bioblaster = 16499,
        AirAnchor = 16500,
        Chainsaw = 25788,
        Excavator = 36981,
        FullMetal = 36982;

    public static class Levels
    {
        public const byte
            SlugShot = 2,
            GaussRound = 15,
            CleanShot = 26,
            Hypercharge = 30,
            HeatBlast = 35,
            RookOverdrive = 40,
            Wildfire = 45,
            Ricochet = 50,
            AutoCrossbow = 52,
            HeatedSplitShot = 54,
            Drill = 58,
            HeatedSlugshot = 60,
            HeatedCleanShot = 64,
            BarrelStabilizer = 66,
            BlazingShot = 68,
            ChargedActionMastery = 74,
            AirAnchor = 76,
            QueenOverdrive = 80,
            Chainsaw = 90,
            DoubleCheck = 92,
            CheckMate = 92,
            Excavator = 96,
            FullMetal = 100;
    }
}

internal class MachinistUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.MachinistUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.MachinistWildfireUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return MCH.Wildfire;
            }

            if (actionID == BLU.BLU2)
            {
                return MCH.Detonator;
            }
        }

        if (IsEnabled(CustomComboPreset.MachinistExcavatorUncombo))
        {
            if (actionID == BLU.BLU3)
            {
                return MCH.Chainsaw;
            }

            if (actionID == BLU.BLU4)
            {
                return MCH.Excavator;
            }
        }

        return actionID;
    }
}