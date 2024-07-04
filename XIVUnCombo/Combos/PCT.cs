﻿using System;

using Dalamud.Game.ClientState.JobGauge.Types;
using FFXIVClientStructs.FFXIV.Client.Game.Gauge;
using XIVUncombo.Combos;

namespace XIVUncombo.Combos;

internal static class PCT
{
    public const byte JobID = 42;

    public const uint
        FireRed = 34650,
        AeroGreen = 34651,
        WaterBlue = 34652,
        BlizzardCyan = 34653,
        EarthYellow = 34654,
        ThunderMagenta = 34655,
        ExtraFireRed = 34656,
        ExtraAeroGreen = 34657,
        ExtraWaterBlue = 34658,
        ExtraBlizzardCyan = 34659,
        ExtraEarthYellow = 34660,
        ExtraThunderMagenta = 34661,
        MiracleWhite = 34662,
        CometBlack = 34663,
        PomMotif = 34664,
        WingMotif = 34665,
        ClawMotif = 34666,
        MawMotif = 34667,
        HammerMotif = 34668,
        StarrySkyMotif = 34669,
        PomMuse = 34670,
        WingedMuse = 34671,
        ClawedMuse = 34672,
        FangedMuse = 34673,
        StrikingMuse = 34674,
        StarryMuse = 34675,
        MogOftheAges = 34676,
        Retribution = 34677,
        HammerStamp = 34678,
        HammerBrush = 34679,
        PolishingHammer = 34680,
        StarPrism1 = 34681,
        StarPrism2 = 34682,
        SubstractivePalette = 34683,
        Smudge = 34684,
        TemperaCoat = 34685,
        TemperaGrassa = 34686,
        RainbowDrip = 34688,
        CreatureMotif = 34689,
        WeaponMotif = 34690,
        LandscapeMotif = 34691,
        AnimalMotif2 = 35347,
        WeaponMotif2 = 35348,
        LandscapeMotif2 = 35349;

    public static class Buffs
    {
        public const ushort
            SubstractivePalette = 3674,
            Chroma2Ready = 3675,
            Chroma3Ready = 3676,
            RainbowReady = 3679,
            HammerReady = 3680,
            StarPrismReady = 3681,
            Installation = 3688,
            ArtisticInstallation = 3689,
            SubstractivePaletteReady = 3690,
            InvertedColors = 3691;
    }

    public static class Debuffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Levels
    {
        public const byte
            FireRed = 1,
            AeroGreen = 5,
            TemperaCoat = 10,
            WaterBlue = 15,
            Smudge = 20,
            ExtraFireRed = 25,
            CreatureMotif = 30,
            PomMotif = 30,
            WingMotif = 30,
            PomMuse = 30,
            WingedMuse = 30,
            MogOftheAges = 30,
            ExtraAeroGreen = 35,
            ExtraWaterBlue = 45,
            HammerMotif = 50,
            HammerStamp = 50,
            WeaponMotif = 50,
            StrikingMuse = 50,
            SubstractivePalette = 60,
            BlizzardCyan = 60,
            EarthYellow = 60,
            ThunderMagenta = 60,
            ExtraBlizzardCyan = 60,
            ExtraEarthYellow = 60,
            ExtraThunderMagenta = 60,
            StarrySkyMotif = 70,
            LandscapeMotif = 70,
            MiracleWhite = 80,
            HammerBrush = 86,
            PolishingHammer = 86,
            TemperaGrassa = 88,
            CometBlack = 90,
            RainbowDrip = 92,
            ClawMotif = 96,
            MawMotif = 96,
            ClawedMuse = 96,
            FangedMuse = 96,
            StarryMuse = 70,
            Retribution = 96,
            StarPrism1 = 100,
            StarPrism2 = 100;
    }

    internal class PictomancerUncombo : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.PictomancerUncombo;

        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (IsEnabled(CustomComboPreset.PictomancerFireUncombo))
            {
                if (actionID == BLU.BLU1)
                {
                    return PCT.FireRed;
                }

                if (actionID == BLU.BLU2)
                {
                    return PCT.AeroGreen;
                }

                if (actionID == BLU.BLU3)
                {
                    return PCT.WaterBlue;
                }
            }

            if (IsEnabled(CustomComboPreset.PictomancerFire2Uncombo))
            {
                if (actionID == BLU.BLU4)
                {
                    return PCT.ExtraFireRed;
                }

                if (actionID == BLU.BLU5)
                {
                    return PCT.ExtraAeroGreen;
                }

                if (actionID == BLU.BLU6)
                {
                    return PCT.ExtraWaterBlue;
                }
            }

            if (IsEnabled(CustomComboPreset.PictomancerBlizzardUncombo))
            {
                if (actionID == BLU.BLU7)
                {
                    return PCT.BlizzardCyan;
                }

                if (actionID == BLU.BLU8)
                {
                    return PCT.EarthYellow;
                }

                if (actionID == BLU.BLU9)
                {
                    return PCT.ThunderMagenta;
                }
            }

            if (IsEnabled(CustomComboPreset.PictomancerBlizzard2Uncombo))
            {
                if (actionID == BLU.BLU10)
                {
                    return PCT.ExtraBlizzardCyan;
                }

                if (actionID == BLU.BLU11)
                {
                    return PCT.ExtraEarthYellow;
                }

                if (actionID == BLU.BLU12)
                {
                    return PCT.ExtraThunderMagenta;
                }
            }

            if (IsEnabled(CustomComboPreset.PictomancerHammerUncombo))
            {
                // Hammer
                if (actionID == BLU.BLU13)
                {
                    return PCT.HammerStamp;
                }

                if (actionID == BLU.BLU14)
                {
                    return PCT.HammerBrush;
                }

                if (actionID == BLU.BLU15)
                {
                    return PCT.PolishingHammer;
                }
            }

            return actionID;
        }
    }
}
