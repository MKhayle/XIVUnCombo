namespace XIVUncombo.Uncombos;

internal static class SAM
{
    public const byte JobID = 34;

    public const uint
        // Single target
        Hakaze = 7477,
        Jinpu = 7478,
        Shifu = 7479,
        Yukikaze = 7480,
        Gekko = 7481,
        Kasha = 7482,
        Gyofu = 36963,
        // AoE
        Fuga = 7483,
        Mangetsu = 7484,
        Oka = 7485,
        Fuko = 25780,
        // Iaijutsu and Tsubame
        Midare = 7487,
        TenkaGoken = 7488,
        Higanbana = 7489,
        Iaijutsu = 7867,
        TsubameGaeshi = 16483,
        // Kaeshi
        KaeshiHiganbana = 16484,
        KaeshiGoken = 16485,
        KaeshiSetsugekka = 16486,
        KaeshiNamikiri = 25782,
        Shoha = 16487,
        // Tendo
        TendoGoken = 36965,
        TendoSetsugekka = 36966,
        TendoKaeshiGoken = 36967,
        TendoKaeshiSetsugekka = 36968,
        // Misc
        HissatsuShinten = 7490,
        HissatsuKyuten = 7491,
        HissatsuSenei = 16481,
        HissatsuGuren = 7496,
        Ikishoten = 16482,
        Shoha2 = 25779,
        OgiNamikiri = 25781;

    public static class Levels
    {
        public const byte
            Jinpu = 4,
            Shifu = 18,
            Gekko = 30,
            Mangetsu = 35,
            Kasha = 40,
            Oka = 45,
            Yukikaze = 50,
            MeikyoShisui = 50,
            HissatsuKyuten = 64,
            HissatsuGuren = 70,
            HissatsuSenei = 72,
            TsubameGaeshi = 76,
            Shoha = 80,
            // Shoha2 = 82,
            Hyosetsu = 86,
            Fuko = 86,
            OgiNamikiri = 90,
            Zanshin = 96;
    }
}

internal class SamuraiUncombo : CustomUncombo
{
    protected internal override CustomUncomboPreset Preset { get; } = CustomUncomboPreset.SamuraiUncombo;

    protected override uint Invoke(uint actionID, byte level)
    {
        if (IsEnabled(CustomUncomboPreset.SamuraiHiganbanaFeature))
        {
            if (actionID == BLU.BLU1)
            {
                return SAM.Higanbana;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiGokenFeature))
        {
            if (actionID == BLU.BLU2)
            {
                return SAM.TenkaGoken;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiMidareFeature))
        {
            if (actionID == BLU.BLU3)
            {
                return SAM.Midare;
            }
        }
        if (IsEnabled(CustomUncomboPreset.SamuraiKaeshiGokenFeature))
        {
            if (actionID == BLU.BLU4)
            {
                return SAM.KaeshiGoken;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiKaeshiSetsugekkaFeature))
        {
            if (actionID == BLU.BLU5)
            {
                return SAM.KaeshiSetsugekka;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiKaeshiNamikiriFeature))
        {
            if (actionID == BLU.BLU6)
            {
                return SAM.OgiNamikiri;
            }

            if (actionID == BLU.BLU7)
            {
                return SAM.KaeshiNamikiri;
            }
        }
        if (IsEnabled(CustomUncomboPreset.SamuraiTendoGokenFeature))
        {
            if (actionID == BLU.BLU8)
            {
                return SAM.TendoGoken;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiTendoMidareFeature))
        {
            if (actionID == BLU.BLU9)
            {
                return SAM.TendoSetsugekka;
            }
        }
        if (IsEnabled(CustomUncomboPreset.SamuraiTendoKaeshiGokenFeature))
        {
            if (actionID == BLU.BLU10)
            {
                return SAM.TendoKaeshiGoken;
            }
        }

        if (IsEnabled(CustomUncomboPreset.SamuraiTendoKaeshiMidareFeature))
        {
            if (actionID == BLU.BLU11)
            {
                return SAM.TendoKaeshiSetsugekka;
            }
        }

        return actionID;
    }
}