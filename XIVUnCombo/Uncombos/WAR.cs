namespace XIVUncombo.Uncombos;

internal static class WAR
{
    public const byte ClassID = 3;
    public const byte JobID = 21;

    public const uint
        HeavySwing = 31,
        Maim = 37,
        Berserk = 38,
        ThrillOfBattle = 40,
        Overpower = 41,
        StormsPath = 42,
        StormsEye = 45,
        InnerBeast = 49,
        SteelCyclone = 51,
        Infuriate = 52,
        FellCleave = 3549,
        Decimate = 3550,
        RawIntuition = 3551,
        Equilibrium = 3552,
        InnerRelease = 7389,
        MythrilTempest = 16462,
        ChaoticCyclone = 16463,
        NascentFlash = 16464,
        InnerChaos = 16465,
        Bloodwhetting = 25751,
        PrimalRend = 25753,
        PrimalWrath = 36924,
        PrimalRuination = 36925;

    public static class Levels
    {
        public const byte
            Maim = 4,
            Berserk = 6,
            StormsPath = 26,
            ThrillOfBattle = 30,
            InnerBeast = 35,
            MythrilTempest = 40,
            StormsEye = 50,
            Infuriate = 50,
            FellCleave = 54,
            RawIntuition = 56,
            Equilibrium = 58,
            Decimate = 60,
            InnerRelease = 70,
            MythrilTempestTrait = 74,
            NascentFlash = 76,
            InnerChaos = 80,
            Bloodwhetting = 82,
            PrimalRend = 90,
            PrimalWrath = 96,
            PrimalRuination = 100;
    }
}

internal class WarriorUncombo : CustomUncombo
{
    protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.WarriorUncombo;

    protected override uint Invoke(uint actionID, byte level)
    {
        if (IsEnabled(CustomUncomboPreset.WarriorChaoticCycloneUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return WAR.Decimate;
            }

            if (actionID == BLU.BLU2)
            {
                return WAR.ChaoticCyclone;
            }
        }

        if (IsEnabled(CustomUncomboPreset.WarriorInnerChaosUncombo))
        {
            if (actionID == BLU.BLU3)
            {
                return WAR.FellCleave;
            }

            if (actionID == BLU.BLU4)
            {
                return WAR.InnerChaos;
            }
        }

        if (IsEnabled(CustomUncomboPreset.WarriorPrimalWrathUncombo))
        {
            if (actionID == BLU.BLU5)
            {
                return WAR.InnerRelease;
            }

            if (actionID == BLU.BLU6)
            {
                return WAR.PrimalWrath;
            }
        }

        if (IsEnabled(CustomUncomboPreset.WarriorPrimalRuinationUncombo))
        {
            if (actionID == BLU.BLU7)
            {
                return WAR.PrimalRend;
            }

            if (actionID == BLU.BLU8)
            {
                return WAR.PrimalRuination;
            }
        }

        return actionID;
    }
}