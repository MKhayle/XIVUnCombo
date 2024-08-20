using System.Collections.Generic;

using Dalamud.Game.ClientState.JobGauge.Enums;
using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class AST
{
    public const byte JobID = 33;

    public const uint
        Draw = 3590,
        Redraw = 3593,
        Benefic = 3594,
        Malefic = 3596,
        Malefic2 = 3598,
        Ascend = 3603,
        Lightspeed = 3606,
        Benefic2 = 3610,
        Synastry = 3612,
        CollectiveUnconscious = 3613,
        Gravity = 3615,
        Balance = 37023,
        Bole = 37027,
        Arrow = 37024,
        Spear = 37026,
        Ewer = 37028,
        Spire = 37025,
        EarthlyStar = 7439,
        Malefic3 = 7442,
        MinorArcana = 7443,
        LordOfCrowns = 7444,
        LadyOfCrowns = 7445,
        SleeveDraw = 7448,
        Divination = 16552,
        CelestialOpposition = 16553,
        Malefic4 = 16555,
        Horoscope = 16557,
        NeutralSect = 16559,
        Play = 17055,
        CrownPlay = 25869,
        Astrodyne = 25870,
        FallMalefic = 25871,
        Gravity2 = 25872,
        Exaltation = 25873,
        Macrocosmos = 25874,
        AstralDraw = 37017,
        UmbralDraw = 37018;


    public static class Levels
    {
        public const byte
            Ascend = 12,
            Benefic2 = 26,
            Draw = 30,
            Redraw = 40,
            Astrodyne = 50,
            MinorArcana = 70,
            CrownPlay = 70;
    }
}

internal class AstrologianUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.AstrologianUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.AstrologianBalanceFeature))
        {
            if (actionID == BLU.BLU1)
            {
                return AST.Balance;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianArrowFeature))
        {
            if (actionID == BLU.BLU2)
            {
                return AST.Arrow;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianSpireFeature))
        {
            if (actionID == BLU.BLU3)
            {
                return AST.Spire;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianSpearFeature))
        {
            if (actionID == BLU.BLU4)
            {
                return AST.Spear;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianBoleFeature))
        {
            if (actionID == BLU.BLU5)
            {
                return AST.Bole;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianEwerFeature))
        {
            if (actionID == BLU.BLU6)
            {
                return AST.Ewer;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianLordOfCrownsFeature))
        {
            if (actionID == BLU.BLU7)
            {
                return AST.LordOfCrowns;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianLadyOfCrownsFeature))
        {
            if (actionID == BLU.BLU8)
            {
                return AST.LadyOfCrowns;
            }
        }

        if (IsEnabled(CustomComboPreset.AstrologianUmbralDrawUncombo))
        {
            if (actionID == BLU.BLU9)
            {
                return AST.AstralDraw;
            }

            if (actionID == BLU.BLU10)
            {
                return AST.UmbralDraw;
            }
        }

        return actionID;
    }
}