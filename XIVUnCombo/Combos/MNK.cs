using System;
using System.Linq;

using Dalamud.Game.ClientState.JobGauge.Enums;
using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class MNK
{
    public const byte ClassID = 2;
    public const byte JobID = 20;

    public const uint
        Bootshine = 53,
        TrueStrike = 54,
        SnapPunch = 56,
        TwinSnakes = 61,
        ArmOfTheDestroyer = 62,
        Demolish = 66,
        PerfectBalance = 69,
        Rockbreaker = 70,
        DragonKick = 74,
        TornadoKick = 3543,
        ElixirField = 3545,
        Meditation = 3546,
        RiddleOfFire = 7395,
        Brotherhood = 7396,
        FourPointFury = 16473,
        Enlightenment = 16474,
        CelestialRevolution = 25765,
        HowlingFist = 25763,
        MasterfulBlitz = 25764,
        RiddleOfWind = 25766,
        ShadowOfTheDestroyer = 25767,
        RisingPhoenix = 25768,
        PhantomRush = 25769,
        FlintStrike = 25882,
        ElixirBurst = 36948;

    public static class Buffs
    {
        public const ushort
            OpoOpoForm = 107,
            RaptorForm = 108,
            CoerlForm = 109,
            PerfectBalance = 110,
            LeadenFist = 1861,
            FormlessFist = 2513,
            DisciplinedFist = 3001;
    }

    public static class Debuffs
    {
        public const ushort
            Demolish = 246;
    }

    public static class Levels
    {
        public const byte
            Bootshine = 1,
            TrueStrike = 4,
            SnapPunch = 6,
            Meditation = 15,
            TwinSnakes = 18,
            ArmOfTheDestroyer = 26,
            Rockbreaker = 30,
            Demolish = 30,
            FourPointFury = 45,
            HowlingFist = 40,
            DragonKick = 50,
            PerfectBalance = 50,
            FormShift = 52,
            EnhancedPerfectBalance = 60,
            ElixirField = 60,
            TornadoKick = 60,
            CelestialRevolution = 60,
            MasterfulBlitz = 60,
            RiddleOfFire = 68,
            Brotherhood = 70,
            Enlightenment = 70,
            RiddleOfWind = 72,
            ShadowOfTheDestroyer = 82,
            RisingPhoenix = 86,
            PhantomRush = 90,
            ElixirBurst = 92;
    }
}

internal class MonkUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.MonkUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.MonkBlitzUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                if (level < MNK.Levels.ElixirBurst)
                    return MNK.ElixirField;
                else return MNK.ElixirBurst;
            }

            if (actionID == BLU.BLU2)
            {
                return MNK.CelestialRevolution;
            }

            if (actionID == BLU.BLU3)
            {
                if (level < MNK.Levels.RisingPhoenix)
                    return MNK.FlintStrike;
                else return MNK.RisingPhoenix;
            }

            if (actionID == BLU.BLU4)
            {
                if (level < MNK.Levels.PhantomRush)
                    return MNK.TornadoKick;
                else return MNK.PhantomRush;
            }

        }

        return actionID;
    }
}