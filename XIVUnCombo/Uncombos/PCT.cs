namespace XIVUncombo.Uncombos;

internal static class PCT
{
    public const byte JobID = 42;

    public const uint
        FireRed = 34650,
        AeroGreen = 34651,
        WaterBlue = 34652,
        BlizzardCyan = 34653,
        EarthYellow = 34654,
        ThunderMagenta = 34655,
        ExtraFireRed = 34656,
        ExtraAeroGreen = 34657,
        ExtraWaterBlue = 34658,
        ExtraBlizzardCyan = 34659,
        ExtraEarthYellow = 34660,
        ExtraThunderMagenta = 34661,
        MiracleWhite = 34662,
        CometBlack = 34663,
        PomMotif = 34664,
        WingMotif = 34665,
        ClawMotif = 34666,
        MawMotif = 34667,
        HammerMotif = 34668,
        StarrySkyMotif = 34669,
        PomMuse = 34670,
        WingedMuse = 34671,
        ClawedMuse = 34672,
        FangedMuse = 34673,
        StrikingMuse = 34674,
        StarryMuse = 34675,
        MogOftheAges = 34676,
        Retribution = 34677,
        HammerStamp = 34678,
        HammerBrush = 34679,
        PolishingHammer = 34680,
        StarPrism1 = 34681,
        StarPrism2 = 34682,
        SubstractivePalette = 34683,
        Smudge = 34684,
        TemperaCoat = 34685,
        TemperaGrassa = 34686,
        RainbowDrip = 34688,
        CreatureMotif = 34689,
        WeaponMotif = 34690,
        LandscapeMotif = 34691,
        AnimalMotif2 = 35347,
        WeaponMotif2 = 35348,
        LandscapeMotif2 = 35349;

    public static class Levels
    {
        public const byte
            FireRed = 1,
            AeroGreen = 5,
            TemperaCoat = 10,
            WaterBlue = 15,
            Smudge = 20,
            ExtraFireRed = 25,
            CreatureMotif = 30,
            PomMotif = 30,
            WingMotif = 30,
            PomMuse = 30,
            WingedMuse = 30,
            MogOftheAges = 30,
            ExtraAeroGreen = 35,
            ExtraWaterBlue = 45,
            HammerMotif = 50,
            HammerStamp = 50,
            WeaponMotif = 50,
            StrikingMuse = 50,
            SubstractivePalette = 60,
            BlizzardCyan = 60,
            EarthYellow = 60,
            ThunderMagenta = 60,
            ExtraBlizzardCyan = 60,
            ExtraEarthYellow = 60,
            ExtraThunderMagenta = 60,
            StarrySkyMotif = 70,
            LandscapeMotif = 70,
            MiracleWhite = 80,
            HammerBrush = 86,
            PolishingHammer = 86,
            TemperaGrassa = 88,
            CometBlack = 90,
            RainbowDrip = 92,
            ClawMotif = 96,
            MawMotif = 96,
            ClawedMuse = 96,
            FangedMuse = 96,
            StarryMuse = 70,
            Retribution = 96,
            StarPrism1 = 100,
            StarPrism2 = 100;
    }

    internal class PictomancerUncombo : CustomUncombo
    {
        protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.PictomancerUncombo;

        protected override uint Invoke(uint actionID, byte level)
        {
            if (IsEnabled(CustomUncomboPreset.PictomancerFireUncombo))
            {
                if (actionID == BLU.BLU1)
                {
                    return FireRed;
                }

                if (actionID == BLU.BLU2)
                {
                    return AeroGreen;
                }

                if (actionID == BLU.BLU3)
                {
                    return WaterBlue;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerFire2Uncombo))
            {
                if (actionID == BLU.BLU4)
                {
                    return ExtraFireRed;
                }

                if (actionID == BLU.BLU5)
                {
                    return ExtraAeroGreen;
                }

                if (actionID == BLU.BLU6)
                {
                    return ExtraWaterBlue;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerBlizzardUncombo))
            {
                if (actionID == BLU.BLU7)
                {
                    return BlizzardCyan;
                }

                if (actionID == BLU.BLU8)
                {
                    return EarthYellow;
                }

                if (actionID == BLU.BLU9)
                {
                    return ThunderMagenta;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerBlizzard2Uncombo))
            {
                if (actionID == BLU.BLU10)
                {
                    return ExtraBlizzardCyan;
                }

                if (actionID == BLU.BLU11)
                {
                    return ExtraEarthYellow;
                }

                if (actionID == BLU.BLU12)
                {
                    return ExtraThunderMagenta;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerEarlyCreatureUncombo))
            {
                if (actionID == BLU.BLU13)
                {
                    return PomMotif;
                }

                if (actionID == BLU.BLU14)
                {
                    return PomMuse;
                }

                if (actionID == BLU.BLU15)
                {
                    return WingMotif;
                }

                if (actionID == BLU.BLU16)
                {
                    return WingedMuse;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerHammerUncombo))
            {
                // Hammer
                if (actionID == BLU.BLU17)
                {
                    return HammerMotif;
                }

                if (actionID == BLU.BLU18)
                {
                    return HammerStamp;
                }

                if (actionID == BLU.BLU19)
                {
                    return HammerBrush;
                }

                if (actionID == BLU.BLU20)
                {
                    return PolishingHammer;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerLateCreatureUncombo))
            {
                if (actionID == BLU.BLU21)
                {
                    return ClawMotif;
                }

                if (actionID == BLU.BLU22)
                {
                    return ClawedMuse;
                }

                if (actionID == BLU.BLU23)
                {
                    return MawMotif;
                }

                if (actionID == BLU.BLU24)
                {
                    return FangedMuse;
                }
            }

            if (IsEnabled(CustomUncomboPreset.PictomancerMogUncombo))
            {
                if (actionID == BLU.BLU25)
                {
                    return MogOftheAges;
                }

                if (actionID == BLU.BLU26)
                {
                    return Retribution;
                }
            }

            return actionID;
        }
    }
}
