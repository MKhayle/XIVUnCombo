using System;
using System.Linq;

using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class DNC
{
    public const byte JobID = 38;

    public const uint
        // Single Target
        Cascade = 15989,
        Fountain = 15990,
        ReverseCascade = 15991,
        Fountainfall = 15992,
        // AoE
        Windmill = 15993,
        Bladeshower = 15994,
        RisingWindmill = 15995,
        Bloodshower = 15996,
        // Steps
        Emboite = 15999,
        Entrechat = 16000,
        Jete = 16001,
        Pirouette = 16002,
        // Dancing
        StandardStep = 15997,
        StandardFinish = 16003,
        TechnicalStep = 15998,
        TechnicalFinish = 16004,
        Tillana = 25790,
        LastDance = 36983,
        FinishingMove = 36984,
        // Fans
        FanDance1 = 16007,
        FanDance2 = 16008,
        FanDance3 = 16009,
        FanDance4 = 25791,
        // Other
        SaberDance = 16005,
        EnAvant = 16010,
        Devilment = 16011,
        Flourish = 16013,
        Improvisation = 16014,
        StarfallDance = 25792,
        DanceOfTheDawn = 36985;

    public static class Levels
    {
        public const byte
            Cascade = 1,
            Fountain = 2,
            Windmill = 15,
            StandardStep = 15,
            ReverseCascade = 20,
            Bladeshower = 25,
            RisingWindmill = 35,
            Fountainfall = 40,
            Bloodshower = 45,
            FanDance3 = 66,
            TechnicalStep = 70,
            Flourish = 72,
            Tillana = 82,
            FanDance4 = 86,
            StarfallDance = 90,
            LastDance = 92,
            FinishingMove = 96;
    }
}

internal class DancerUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.DancerUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.DancerEmboiteFeature))
        {
            if (actionID == BLU.BLU1)
            {
                return DNC.Cascade;
            }

            if (actionID == BLU.BLU2)
            {
                return DNC.Windmill;
            }

            if (actionID == BLU.BLU3)
            {
                return DNC.Emboite;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerEntrechatFeature))
        {
            if (actionID == BLU.BLU4)
            {
                return DNC.Fountain;
            }

            if (actionID == BLU.BLU5)
            {
                return DNC.Bladeshower;
            }

            if (actionID == BLU.BLU6)
            {
                return DNC.Entrechat;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerJeteFeature))
        {
            if (actionID == BLU.BLU7)
            {
                return DNC.ReverseCascade;
            }

            if (actionID == BLU.BLU8)
            {
                return DNC.RisingWindmill;
            }

            if (actionID == BLU.BLU9)
            {
                return DNC.Jete;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerPirouetteFeature))
        {
            if (actionID == BLU.BLU10)
            {
                return DNC.Fountainfall;
            }

            if (actionID == BLU.BLU11)
            {
                return DNC.Bloodshower;
            }

            if (actionID == BLU.BLU12)
            {
                return DNC.Pirouette;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerStandardDanceFeature))
        {
            if (actionID == BLU.BLU13)
            {
                return DNC.StandardStep;
            }

            if (actionID == BLU.BLU14)
            {
                return DNC.StandardFinish;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerTechnicalDanceFeature))
        {
            if (actionID == BLU.BLU15)
            {
                return DNC.TechnicalStep;
            }

            if (actionID == BLU.BLU16)
            {
                return DNC.TechnicalFinish;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerTillanaFeature))
        {
            if (actionID == BLU.BLU13)
            {
                return DNC.StandardStep;
            }

            if (actionID == BLU.BLU17)
            {
                return DNC.Tillana;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerFinishingMoveFeature))
        {
            if (actionID == BLU.BLU15)
            {
                return DNC.TechnicalStep;
            }

            if (actionID == BLU.BLU18)
            {
                return DNC.FinishingMove;
            }
        }

        if (IsEnabled(CustomComboPreset.DancerDawnUncombo))
        {
            if (actionID == BLU.BLU19)
            {
                return DNC.SaberDance;
            }

            if (actionID == BLU.BLU20)
            {
                return DNC.DanceOfTheDawn;
            }
        }

        return actionID;
    }
}