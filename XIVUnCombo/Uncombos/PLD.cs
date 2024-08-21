namespace XIVUncombo.Uncombos;

internal static class PLD
{
    public const byte ClassID = 1;
    public const byte JobID = 19;

    public const uint
        FastBlade = 9,
        RiotBlade = 15,
        ShieldBash = 16,
        FightOrFlight = 20,
        RageOfHalone = 21,
        CircleOfScorn = 23,
        ShieldLob = 24,
        SpiritsWithin = 29,
        GoringBlade = 3538,
        RoyalAuthority = 3539,
        Clemency = 3541,
        TotalEclipse = 7381,
        Requiescat = 7383,
        HolySpirit = 7384,
        LowBlow = 7540,
        Prominence = 16457,
        HolyCircle = 16458,
        Confiteor = 16459,
        Atonement = 16460,
        Expiacion = 25747,
        BladeOfFaith = 25748,
        BladeOfTruth = 25749,
        BladeOfValor = 25750,
        Supplication = 36918,
        Sepulchre = 36919,
        Imperator = 36921,
        BladeOfHonor = 36922;

    public static class Levels
    {
        public const byte
            FightOrFlight = 2,
            RiotBlade = 4,
            LowBlow = 12,
            SpiritsWithin = 30,
            CircleOfScorn = 50,
            RageOfHalone = 26,
            Prominence = 40,
            GoringBlade = 54,
            RoyalAuthority = 60,
            HolySpirit = 64,
            DivineMagicMastery = 64,
            Requiescat = 68,
            HolyCircle = 72,
            Atonement = 76,
            Supplication = 76,
            Sepulchre = 76,
            Confiteor = 80,
            Expiacion = 86,
            BladeOfFaith = 90,
            BladeOfTruth = 90,
            BladeOfValor = 90,
            Imperator = 96,
            BladeOfHonor = 100;
    }
}

internal class PaladinUncombo : CustomUncombo
{
    protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.PaladinUncombo;

    protected override uint Invoke(uint actionID, byte level)
    {
        if (IsEnabled(CustomUncomboPreset.PaladinImperatorBladesUncombo))
        {
            if (actionID == BLU.BLU1)
            {
                if (level <= PLD.Levels.Imperator)
                    return PLD.Requiescat;
                else return PLD.Imperator;
            }

            if (actionID == BLU.BLU2)
            {
                return PLD.BladeOfHonor;
            }
        }

        if (IsEnabled(CustomUncomboPreset.PaladinBladesUncombo))
        {
            if (actionID == BLU.BLU3)
            {
                return PLD.Confiteor;
            }

            if (actionID == BLU.BLU4)
            {
                return PLD.BladeOfFaith;
            }

            if (actionID == BLU.BLU5)
            {
                return PLD.BladeOfTruth;
            }

            if (actionID == BLU.BLU6)
            {
                return PLD.BladeOfValor;
            }
        }

        if (IsEnabled(CustomUncomboPreset.PaladinAtonementUncombo))
        {
            if (actionID == BLU.BLU7)
            {
                return PLD.Atonement;
            }

            if (actionID == BLU.BLU8)
            {
                return PLD.Supplication;
            }

            if (actionID == BLU.BLU9)
            {
                return PLD.Sepulchre;
            }
        }

        return actionID;
    }
}