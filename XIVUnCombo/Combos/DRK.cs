using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class DRK
{
    public const byte JobID = 32;

    public const uint
        HardSlash = 3617,
        Unleash = 3621,
        SyphonStrike = 3623,
        Souleater = 3632,
        BloodWeapon = 3625,
        SaltedEarth = 3639,
        AbyssalDrain = 3641,
        CarveAndSpit = 3643,
        Quietus = 7391,
        Bloodspiller = 7392,
        FloodOfDarkness = 16466,
        EdgeOfDarkness = 16467,
        StalwartSoul = 16468,
        FloodOfShadow = 16469,
        EdgeOfShadow = 16470,
        LivingShadow = 16472,
        SaltAndDarkness = 25755,
        Shadowbringer = 25757,
        ScarletDelirium = 36928,
        Comeuppance = 36929,
        Torcleaver = 36930,
        Impalement = 36931;

    public static class Buffs
    {
        public const ushort
            BloodWeapon = 742,
            Darkside = 751,
            Delirium = 1972;
    }

    public static class Debuffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Levels
    {
        public const byte
            SyphonStrike = 2,
            Souleater = 26,
            FloodOfDarkness = 30,
            BloodWeapon = 35,
            EdgeOfDarkness = 40,
            StalwartSoul = 40,
            SaltedEarth = 52,
            AbyssalDrain = 56,
            CarveAndSpit = 60,
            Bloodspiller = 62,
            Quietus = 64,
            Delirium = 68,
            Shadow = 74,
            LivingShadow = 80,
            SaltAndDarkness = 86,
            Shadowbringer = 90;
    }
}


internal class DarKKnightUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.DarkKnightUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.DarkKnightDeliriumSTUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return DRK.Bloodspiller;
            }

            if (actionID == BLU.BLU2)
            {
                return DRK.ScarletDelirium;
            }

            if (actionID == BLU.BLU3)
            {
                return DRK.Comeuppance;
            }

            if (actionID == BLU.BLU4)
            {
                return DRK.Torcleaver;
            }
        }
        if (IsEnabled(CustomComboPreset.DarkKnightDeliriumAoEUncombo))
        {
            if (actionID == BLU.BLU5)
            {
                return DRK.Quietus;
            }

            if (actionID == BLU.BLU6)
            {
                return DRK.Impalement;
            }
        }

        return actionID;
    }
}