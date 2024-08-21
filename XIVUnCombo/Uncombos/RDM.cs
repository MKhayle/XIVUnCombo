namespace XIVUncombo.Uncombos;

internal static class RDM
{
    public const byte JobID = 35;

    public const uint
        Jolt = 7503,
        Riposte = 7504,
        Verthunder = 7505,
        Veraero = 7507,
        Scatter = 7509,
        Verfire = 7510,
        Verstone = 7511,
        Zwerchhau = 7512,
        Moulinet = 7513,
        Vercure = 7514,
        Redoublement = 7516,
        Fleche = 7517,
        Acceleration = 7518,
        ContreSixte = 7519,
        Embolden = 7520,
        Manafication = 7521,
        Verraise = 7523,
        Jolt2 = 7524,
        Verflare = 7525,
        Verholy = 7526,
        EnchantedRiposte = 7527,
        EnchantedZwerchhau = 7528,
        EnchantedRedoublement = 7529,
        EnchantedMoulinet = 7530,
        Verthunder2 = 16524,
        Veraero2 = 16525,
        Impact = 16526,
        Reprise = 16528,
        EnchantedReprise = 16529,
        Scorch = 16530,
        Verthunder3 = 25855,
        Veraero3 = 25856,
        Resolution = 25858,
        EnchantedMoulinetDeux = 37002,
        EnchantedMoulinetTrois = 37003,
        Jolt3 = 37004,
        ViceOfThorns = 37005,
        GrandImpact = 37006,
        Prefulgence = 37007;

    public static class Levels
    {
        public const byte
            Jolt = 2,
            Verthunder = 4,
            Veraero = 10,
            Scatter = 15,
            Zwerchhau = 35,
            Fleche = 45,
            Redoublement = 50,
            Acceleration = 50,
            Vercure = 54,
            ContreSixte = 56,
            Embolden = 58,
            Manafication = 60,
            Jolt2 = 62,
            Verraise = 64,
            Impact = 66,
            Verflare = 68,
            Verholy = 70,
            Scorch = 80,
            Veraero3 = 82,
            Verthunder3 = 82,
            Jolt3 = 82,
            Resolution = 90,
            ViceOfThorns = 92,
            GrandImpact = 96,
            Prefulgence = 100;
    }
}

internal class RedMageUncombo : CustomUncombo
{
    protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.RedMageUncombo;

    protected override uint Invoke(uint actionID, byte level)
    {
        if (IsEnabled(CustomUncomboPreset.RedMageNonEnchantedSTFeature))
        {
            if (actionID == BLU.BLU1)
            {
                return RDM.Riposte;
            }

            if (actionID == BLU.BLU2)
            {
                return RDM.Zwerchhau;
            }

            if (actionID == BLU.BLU3)
            {
                return RDM.Redoublement;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageEnchantedSTFeature))
        {
            if (actionID == BLU.BLU4)
            {
                return RDM.EnchantedRiposte;
            }

            if (actionID == BLU.BLU5)
            {
                return RDM.EnchantedZwerchhau;
            }

            if (actionID == BLU.BLU6)
            {
                return RDM.EnchantedRedoublement;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageEnchantedAoEFeature))
        {
            if (actionID == BLU.BLU7)
            {
                return RDM.Moulinet;
            }

            if (actionID == BLU.BLU8)
            {
                return RDM.EnchantedMoulinet;
            }

            if (actionID == BLU.BLU9)
            {
                return RDM.EnchantedMoulinetDeux;
            }

            if (actionID == BLU.BLU10)
            {
                return RDM.EnchantedMoulinetTrois;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageEnchantedRangedFeature))
        {
            if (actionID == BLU.BLU11)
            {
                return RDM.Reprise;
            }

            if (actionID == BLU.BLU12)
            {
                return RDM.EnchantedReprise;
            }
        }
        if (IsEnabled(CustomUncomboPreset.RedMageVerFlareFeature))
        {
            if (actionID == BLU.BLU13)
            {
                if (level <= RDM.Levels.Verthunder3)
                    return RDM.Verthunder;
                else return RDM.Verthunder3;
            }

            if (actionID == BLU.BLU14)
            {
                return RDM.Verthunder2;
            }

            if (actionID == BLU.BLU15)
            {
                return RDM.Verflare;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageVerHolyFeature))
        {
            if (actionID == BLU.BLU16)
            {
                if (level <= RDM.Levels.Veraero3)
                    return RDM.Veraero;
                else return RDM.Veraero3;
            }

            if (actionID == BLU.BLU17)
            {
                return RDM.Veraero2;
            }

            if (actionID == BLU.BLU18)
            {
                return RDM.Verholy;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageScorchFeature))
        {
            if (actionID == BLU.BLU19)
            {
                if (level <= RDM.Levels.Jolt3)
                    return RDM.Jolt2;
                else return RDM.Jolt3;
            }

            if (actionID == BLU.BLU20)
            {
                return RDM.Impact;
            }

            if (actionID == BLU.BLU21)
            {
                return RDM.Scorch;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageResolutionFeature))
        {
            if (actionID == BLU.BLU22)
            {
                return RDM.Resolution;
            }
        }

        if (IsEnabled(CustomUncomboPreset.RedMageGrandImpactUncombo))
        {
            if (actionID == BLU.BLU19)
            {
                if (level <= RDM.Levels.Jolt3)
                    return RDM.Jolt2;
                else return RDM.Jolt3;
            }

            if (actionID == BLU.BLU23)
            {
                return RDM.GrandImpact;
            }
        }


        if (IsEnabled(CustomUncomboPreset.RedMagePrefulgenceUncombo))
        {
            if (actionID == BLU.BLU24)
            {
                return RDM.Manafication;
            }

            if (actionID == BLU.BLU25)
            {
                return RDM.Prefulgence;
            }
        }

        return actionID;
    }
}