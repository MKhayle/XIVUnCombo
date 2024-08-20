using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class DRG
{
    public const byte ClassID = 4;
    public const byte JobID = 22;

    public const uint
        // Single Target
        TrueThrust = 75,
        VorpalThrust = 78,
        Disembowel = 87,
        FullThrust = 84,
        ChaosThrust = 88,
        HeavensThrust = 25771,
        ChaoticSpring = 25772,
        WheelingThrust = 3556,
        FangAndClaw = 3554,
        RaidenThrust = 16479,
        BarrageThrust = 36954,
        ExplosiveThrust = 36955,
        Drakesbane = 36952,
        BarrageThrust2 = 36954,
        ExplosiveThrust2 = 36955,
        // AoE
        DoomSpike = 86,
        SonicThrust = 7397,
        CoerthanTorment = 16477,
        DraconianFury = 25770,
        // Combined
        Geirskogul = 3555,
        Nastrond = 7400,
        // Jumps
        Jump = 92,
        SpineshatterDive = 95,
        DragonfireDive = 96,
        HighJump = 16478,
        MirageDive = 7399,
        // Dragon
        Stardiver = 16480,
        WyrmwindThrust = 25773,
        // Buff abilities
        LanceCharge = 85,
        DragonSight = 7398,
        BattleLitany = 3557;

    public static class Levels
    {
        public const byte
            VorpalThrust = 4,
            Disembowel = 18,
            FullThrust = 26,
            SpineshatterDive = 45,
            DragonfireDive = 50,
            ChaosThrust = 50,
            BattleLitany = 52,
            HeavensThrust = 86,
            ChaoticSpring = 86,
            FangAndClaw = 56,
            WheelingThrust = 58,
            Geirskogul = 60,
            SonicThrust = 62,
            Drakesbane = 64,
            DragonSight = 66,
            MirageDive = 68,
            LifeOfTheDragon = 70,
            CoerthanTorment = 72,
            HighJump = 74,
            RaidenThrust = 76,
            Stardiver = 80,
            WyrmwindThrust = 90;
    }
}

internal class DragoonUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.DragoonUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.DragoonDrakesbaneUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return DRG.WheelingThrust;
            }

            if (actionID == BLU.BLU2)
            {
                return DRG.FangAndClaw;
            }

            if (actionID == BLU.BLU3)
            {
                return DRG.Drakesbane;
            }
        }

        if (IsEnabled(CustomComboPreset.DragoonRaidenThrustUncombo))
        {
            if (actionID == BLU.BLU4)
            {
                return DRG.TrueThrust;
            }

            if (actionID == BLU.BLU5)
            {
                return DRG.RaidenThrust;
            }
        }

        if (IsEnabled(CustomComboPreset.DragoonDraconianFuryUncombo))
        {
            if (actionID == BLU.BLU6)
            {
                return DRG.DoomSpike;
            }

            if (actionID == BLU.BLU7)
            {
                return DRG.DraconianFury;
            }
        }

        return actionID;
    }
}