using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class NIN
{
    public const byte ClassID = 29;
    public const byte JobID = 30;

    public const uint
        SpinningEdge = 2240,
        GustSlash = 2242,
        Hide = 2245,
        Assassinate = 8814,
        Mug = 2248,
        DeathBlossom = 2254,
        AeolianEdge = 2255,
        TrickAttack = 2258,
        Ninjutsu = 2260,
        Chi = 2261,
        JinNormal = 2263,
        Kassatsu = 2264,
        FumaShuriken = 2265,
        Katon = 2266,
        Raiton = 2267,
        Hyoton = 2268,
        Huton = 2269,
        Doton = 2270,
        Suiton = 2271,
        ArmorCrush = 3563,
        DreamWithinADream = 3566,
        KuchiyoseOgama = 7401,
        Bhavacakra = 7402,
        TenChiJin = 7403,
        HakkeMujinsatsu = 16488,
        Meisui = 16489,
        GokkaMekkyaku = 16491,
        HyoshoRanryu = 16492,
        Jin = 18807,
        Bunshin = 16493,
        Huraijin = 25876,
        PhantomKamaitachi = 25774,
        ForkedRaiju = 25777,
        FleetingRaiju = 25778,
        Dokumori = 36957,
        KuchiyoseGamasen = 36959,
        ZeshoMeppo = 36960,
        TenriJido = 36961;

    public static class Buffs
    {
        public const ushort
            Mudra = 496,
            Kassatsu = 497,
            Suiton = 507,
            Hidden = 614,
            Bunshin = 1954,
            RaijuReady = 2690,
            Higi = 3850;
    }

    public static class Debuffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Levels
    {
        public const byte
            GustSlash = 4,
            Hide = 10,
            Mug = 15,
            AeolianEdge = 26,
            Ninjitsu = 30,
            Suiton = 45,
            HakkeMujinsatsu = 52,
            ArmorCrush = 54,
            Huraijin = 60,
            Dokumori = 66,
            TenChiJin = 70,
            Meisui = 72,
            EnhancedKassatsu = 76,
            Bunshin = 80,
            PhantomKamaitachi = 82,
            Raiju = 90;
    }
}

internal class NinjaUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.NinjaUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.NinjaNinjutsuUncombo))
        {
            if (IsEnabled(CustomComboPreset.NinjaFumaShurikenFeature))
            {
                if (actionID == BLU.BLU1)
                {
                    return NIN.FumaShuriken;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaKatonFeature))
            {
                if (actionID == BLU.BLU2)
                {
                    return NIN.Katon;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaRaitonFeature))
            {
                if (actionID == BLU.BLU3)
                {
                    return NIN.Raiton;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaHyotonFeature))
            {
                if (actionID == BLU.BLU4)
                {
                    return NIN.Hyoton;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaHutonFeature))
            {
                if (actionID == BLU.BLU5)
                {
                    return NIN.Huton;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaDotonFeature))
            {
                if (actionID == BLU.BLU6)
                {
                    return NIN.Doton;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaSuitonFeature))
            {
                if (actionID == BLU.BLU7)
                {
                    return NIN.Suiton;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.NinjaKassatsuUncombo))
        {
            if (IsEnabled(CustomComboPreset.NinjaGokaMekkyakuFeature))
            {
                if (actionID == BLU.BLU8)
                {
                    return NIN.GokkaMekkyaku;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaHyoshoRanryuFeature))
            {
                if (actionID == BLU.BLU9)
                {
                    return NIN.HyoshoRanryu;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.NinjaNinkiHigiUncombo))
        {
            if (IsEnabled(CustomComboPreset.NinjaKuchiyoseGamasenFeature))
            {
                if (actionID == BLU.BLU10)
                {
                    return NIN.KuchiyoseOgama;
                }

                if (actionID == BLU.BLU11)
                {
                    return NIN.KuchiyoseGamasen;
                }
            }

            if (IsEnabled(CustomComboPreset.NinjaHyoshoRanryuFeature))
            {
                if (actionID == BLU.BLU12)
                {
                    return NIN.Bhavacakra;
                }

                if (actionID == BLU.BLU13)
                {
                    return NIN.ZeshoMeppo;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.NinjaTenriJidoUncombo))
        {

            if (actionID == BLU.BLU14)
            {
                return NIN.TenChiJin;
            }

            if (actionID == BLU.BLU15)
            {
                return NIN.TenriJido;
            }
        }

        return actionID;
    }
}