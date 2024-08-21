namespace XIVUncombo.Uncombos;

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

internal class AstrologianUncombo : CustomUncombo
{
    protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.AstrologianUncombo;

    protected override uint Invoke(uint actionID, byte level)
    {
        if (IsEnabled(CustomUncomboPreset.AstrologianBalanceFeature))
        {
            if (actionID == BLU.BLU1)
            {
                return AST.Balance;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianArrowFeature))
        {
            if (actionID == BLU.BLU2)
            {
                return AST.Arrow;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianSpireFeature))
        {
            if (actionID == BLU.BLU3)
            {
                return AST.Spire;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianSpearFeature))
        {
            if (actionID == BLU.BLU4)
            {
                return AST.Spear;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianBoleFeature))
        {
            if (actionID == BLU.BLU5)
            {
                return AST.Bole;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianEwerFeature))
        {
            if (actionID == BLU.BLU6)
            {
                return AST.Ewer;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianLordOfCrownsFeature))
        {
            if (actionID == BLU.BLU7)
            {
                return AST.LordOfCrowns;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianLadyOfCrownsFeature))
        {
            if (actionID == BLU.BLU8)
            {
                return AST.LadyOfCrowns;
            }
        }

        if (IsEnabled(CustomUncomboPreset.AstrologianUmbralDrawUncombo))
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