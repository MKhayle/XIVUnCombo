using Dalamud.Game.ClientState.JobGauge.Enums;
using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class BRD
{
    public const byte ClassID = 5;
    public const byte JobID = 23;

    public const uint
        HeavyShot = 97,
        StraightShot = 98,
        VenomousBite = 100,
        RagingStrikes = 101,
        QuickNock = 106,
        Barrage = 107,
        Bloodletter = 110,
        Windbite = 113,
        MagesBallad = 114,
        ArmysPaeon = 116,
        RainOfDeath = 117,
        BattleVoice = 118,
        EmpyrealArrow = 3558,
        WanderersMinuet = 3559,
        IronJaws = 3560,
        Sidewinder = 3562,
        PitchPerfect = 7404,
        CausticBite = 7406,
        Stormbite = 7407,
        RefulgentArrow = 7409,
        Peloton = 7557,
        BurstShot = 16495,
        ApexArrow = 16496,
        Shadowbite = 16494,
        Ladonsbite = 25783,
        BlastArrow = 25784,
        RadiantFinale = 25785;

    public static class Levels
    {
        public const byte
            StraightShot = 2,
            RagingStrikes = 4,
            VenomousBite = 6,
            Bloodletter = 12,
            MagesBallad = 30,
            Windbite = 30,
            Barrage = 38,
            ArmysPaeon = 40,
            RainOfDeath = 45,
            BattleVoice = 50,
            WanderersMinuet = 52,
            PitchPerfect = 52,
            EmpyrealArrow = 54,
            IronJaws = 56,
            Sidewinder = 60,
            BiteUpgrade = 64,
            RefulgentArrow = 70,
            Shadowbite = 72,
            BurstShot = 76,
            ApexArrow = 80,
            Ladonsbite = 82,
            BlastShot = 86,
            RadiantFinale = 90;
    }
}

internal class BardUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.BardUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.BardBlastArrowUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                return BRD.ApexArrow;
            }

            if (actionID == BLU.BLU2)
            {
                return BRD.BlastArrow;
            }
        }

        return actionID;
    }
}