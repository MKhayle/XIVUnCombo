﻿using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class VPR
{
    public const byte JobID = 41;

    public const uint
            BloodiedMaw = 34619,
            DeathRattle = 34634,
            DreadFangs = 34607,
            DreadMaw = 34615,
            Dreadwinder = 34620,
            // Generations
            Generation1 = 34627,
            Generation2 = 34628,
            Generation3 = 34629,
            Generation4 = 34630,
            FlankstingStrike = 34610,
            FlanksbaneFang = 34611,
            HindstingStrike = 34612,
            HindsbaneFang = 34613,
            HuntersBite = 34616,
            HuntersCoil = 34621,
            HuntersDen = 34624,
            HuntersSnap = 39166,
            HuntersSting = 34608,
            JaggedMaw = 34618,
            LastLash = 34635,
            // Legacies
            Legacy1 = 34640,
            Legacy2 = 34641,
            Legacy3 = 34642,
            Legacy4 = 34643,
            Ouroboros = 34631,
            PitofDread = 34623,
            RattlingCoil = 39189,
            Reawaken = 34626,
            SerpentsIre = 34647,
            SerpentsTail1 = 35920,
            SerpentsTail2 = 39183,
            Slither1 = 34646,
            Slither2 = 39184,
            SnakeScales = 39185,
            SteelFangs = 34606,
            SteelMaw = 34614,
            SwiftskinsBite = 34617,
            SwiftskinsCoil = 34622,
            SwiftskinsDen = 34625,
            SwiftskinsSting = 34609,
            Twinfang = 35921,
            Twinblood = 35922,
            TwinfangBite = 34636,
            TwinbloodBite = 34637,
            TwinfangThresh = 34638,
            TwinbloodThresh = 34639,
            UncoiledFury1 = 34633,
            UncoiledFury2 = 39168,
            UncoiledTwinFangs = 34644,
            UncoiledTwinBlood = 34645,
            Worldswallower = 39190,
            WrithingSnap = 34632;

    public static class Buffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Debuffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Levels
    {
        public const byte
            Reawaken = 90;
    }
}


internal class ViperUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.ViperUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (actionID == BLU.BLU1)
        {
            return VPR.SteelFangs;
        }

        if (actionID == BLU.BLU2)
        {
            return VPR.HuntersSting;
        }

        if (actionID == BLU.BLU3)
        {
            return VPR.DreadFangs;
        }

        if (actionID == BLU.BLU4)
        {
            return VPR.WrithingSnap;
        }

        if (actionID == BLU.BLU5)
        {
            return VPR.SwiftskinsSting;
        }

        if (actionID == BLU.BLU6)
        {
            return VPR.SteelMaw;
        }

        if (actionID == BLU.BLU7)
        {
            return VPR.FlankstingStrike;
        }

        if (actionID == BLU.BLU8)
        {
            return VPR.FlanksbaneFang;
        }

        if (actionID == BLU.BLU9)
        {
            return VPR.HindstingStrike;
        }

        if (actionID == BLU.BLU10)
        {
            return VPR.HindsbaneFang;
        }

        if (actionID == BLU.BLU11)
        {
            return VPR.DreadMaw;
        }

        if (actionID == BLU.BLU12)
        {
            return VPR.HuntersBite;
        }

        if (actionID == BLU.BLU13)
        {
            return VPR.SwiftskinsBite;
        }

        if (actionID == BLU.BLU14)
        {
            return VPR.JaggedMaw;
        }

        if (actionID == BLU.BLU15)
        {
            return VPR.BloodiedMaw;
        }

        if (actionID == BLU.BLU16)
        {
            return VPR.DeathRattle;
        }

        if (actionID == BLU.BLU17)
        {
            return VPR.LastLash;
        }

        if (actionID == BLU.BLU18)
        {
            return VPR.Dreadwinder;
        }

        if (actionID == BLU.BLU19)
        {
            return VPR.HuntersCoil;
        }

        if (actionID == BLU.BLU20)
        {
            return VPR.SwiftskinsCoil;
        }

        if (actionID == BLU.BLU21)
        {
            return VPR.PitofDread;
        }

        if (actionID == BLU.BLU22)
        {
            return VPR.HuntersDen;
        }

        if (actionID == BLU.BLU23)
        {
            return VPR.SwiftskinsDen;
        }

        if (actionID == BLU.BLU24)
        {
            return VPR.TwinfangBite;
        }

        if (actionID == BLU.BLU25)
        {
            return VPR.TwinbloodBite;
        }

        if (actionID == BLU.BLU26)
        {
            return VPR.TwinfangThresh;
        }

        if (actionID == BLU.BLU27)
        {
            return VPR.TwinbloodThresh;
        }

        if (actionID == BLU.BLU28)
        {
            return VPR.UncoiledFury1;
        }

        if (actionID == BLU.BLU29)
        {
            return VPR.Reawaken;
        }

        if (actionID == BLU.BLU30)
        {
            return VPR.Generation1;
        }

        if (actionID == BLU.BLU31)
        {
            return VPR.Generation2;
        }

        if (actionID == BLU.BLU32)
        {
            return VPR.Generation3;
        }

        if (actionID == BLU.BLU33)
        {
            return VPR.Generation4;
        }

        if (actionID == BLU.BLU34)
        {
            return VPR.UncoiledTwinFangs;
        }

        if (actionID == BLU.BLU35)
        {
            return VPR.UncoiledTwinBlood;
        }

        if (actionID == BLU.BLU36)
        {
            return VPR.Ouroboros;
        }

        if (actionID == BLU.BLU37)
        {
            return VPR.Legacy1;
        }

        if (actionID == BLU.BLU38)
        {
            return VPR.Legacy2;
        }

        if (actionID == BLU.BLU39)
        {
            return VPR.Legacy3;
        }

        if (actionID == BLU.BLU40)
        {
            return VPR.Legacy4;
        }

        return actionID;
    }
}