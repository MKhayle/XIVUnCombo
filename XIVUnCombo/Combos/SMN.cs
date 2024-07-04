using Dalamud.Game.ClientState.JobGauge.Types;

namespace XIVUncombo.Combos;

internal static class SMN
{
    public const byte ClassID = 26;
    public const byte JobID = 27;

    public const uint

        Ruin = 163,
        Ruin2 = 172,
        Ruin3 = 3579,
        Ruin4 = 7426,
        Infuse = 25800,
        Fester = 181,
        RubyRuin = 25808,
        TopazRuin = 25809,
        EmeraldRuin = 25810,
        RubyRuin2 = 25811,
        TopazRuin2 = 25812,
        EmeraldRuin2 = 25813,
        RubyRuin3 = 25817,
        TopazRuin3 = 25818,
        EmeraldRuin3 = 25819,
        RubyRite = 25823,
        TopazRite = 25824,
        EmeraldRite = 25825,
        RubyCatastrophe = 25832,
        TopazCatastrophe = 25833,
        EmeraldCatastrophe = 25834,
        RubyOutburst = 25814,
        TopazOutburst = 25815,
        EmeraldOutburst = 25816,
        Painflare = 3578,
        DreadwyrmTrance = 3581,
        Deathflare = 3582,
        SummonBahamut = 7427,
        EnkindleBahamut = 7429,
        Physick = 16230,
        EnergySyphon = 16510,
        Outburst = 16511,
        EnkindlePhoenix = 16516,
        EnergyDrain = 16508,
        SummonCarbuncle = 25798,
        RadiantAegis = 25799,
        Aethercharge = 25800,
        SearingLight = 25801,
        SummonRuby = 25802,
        SummonTopaz = 25803,
        SummonEmerald = 25804,
        SummonIfrit = 25805,
        SummonTitan = 25806,
        SummonGaruda = 25807,
        AstralFlow = 25822,
        TriDisaster = 25826,
        Rekindle = 25830,
        SummonPhoenix = 25831,
        CrimsonCyclone = 25835,
        MountainBuster = 25836,
        Slipstream = 25837,
        SummonIfrit2 = 25838,
        SummonTitan2 = 25839,
        SummonGaruda2 = 25840,
        CrimsonStrike = 25885,
        Gemshine = 25883,
        PreciousBrilliance = 25884,
        Necrosis = 36990,
        SummonSolarBahamut = 36992,
        Sunflare = 36996,
        LuxSolaris = 36997,
        EnkindleSolarBahamut = 36998,
        AstralImpulse = 25820,
        FountainOfFire = 16514,
        UmbralImpulse = 36994,
        AstralFlare = 25821,
        BrandOfPurgatory = 16515,
        UmbralFlare = 36995;

    public static class Buffs
    {
        public const ushort
            Aetherflow = 304,
            FurtherRuin = 2701,
            SearingLight = 2703,
            IfritsFavor = 2724,
            GarudasFavor = 2725,
            TitansFavor = 2853;
    }

    public static class Debuffs
    {
        public const ushort
            Placeholder = 0;
    }

    public static class Levels
    {
        public const byte
            SummonCarbuncle = 2,
            RadiantAegis = 2,
            Infuse = 6,
            SummonRuby = 6,
            Gemshine = 6,
            EnergyDrain = 10,
            Fester = 10,
            SummonTopaz = 15,
            SummonEmerald = 22,
            PreciousBrilliance = 26,
            Outburst = 26,
            Ruin2 = 30,
            SummonIfrit = 30,
            SummonTitan = 35,
            Painflare = 40,
            SummonGaruda = 45,
            EnergySyphon = 52,
            Ruin3 = 54,
            DreadwyrmTrance = 58,
            Ruin4 = 62,
            SearingLight = 66,
            EnkindleBahamut = 70,
            SummonBahamut = 70,
            Rites = 72,
            TriDisaster = 74,
            Rekindle = 80,
            ElementalMastery = 86,
            SummonPhoenix = 80,
            SummonIfrit2 = 80,
            SummonTitan2 = 80,
            SummonGaruda2 = 80,
            Necrosis = 92,
            SummonSolarBahamut = 100,
            LuxSolaris = 100;
    }
}

internal class SummonerUncombo : CustomCombo
{
    protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.SummonerUncombo;

    protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
    {
        if (IsEnabled(CustomComboPreset.SummonerGemshineUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerGemshineIfritFeature))
            {
                if (actionID == BLU.BLU1)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.RubyRuin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.RubyRuin2;
                    if (level < SMN.Levels.Rites)
                        return SMN.RubyRuin3;
                    return SMN.RubyRite;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerGemshineTitanFeature))
            {
                if (actionID == BLU.BLU2)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.TopazRuin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.TopazRuin2;
                    if (level < SMN.Levels.Rites)
                        return SMN.TopazRuin3;
                    return SMN.TopazRite;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerGemshineGarudaFeature))
            {
                if (actionID == BLU.BLU3)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.EmeraldRuin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.EmeraldRuin2;
                    if (level < SMN.Levels.Rites)
                        return SMN.EmeraldRuin3;
                    return SMN.EmeraldRite;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerBrillanceUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerBrillanceIfritFeature))
            {
                if (actionID == BLU.BLU4)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.RubyOutburst;
                    return SMN.RubyCatastrophe;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerBrillanceTitanFeature))
            {
                if (actionID == BLU.BLU5)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.TopazOutburst;
                    return SMN.TopazCatastrophe;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerBrillanceGarudaFeature))
            {
                if (actionID == BLU.BLU6)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.EmeraldOutburst;
                    return SMN.EmeraldCatastrophe;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerRuinUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerRuinBahamutFeature))
            {
                if (actionID == BLU.BLU7)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.Ruin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.Ruin2;
                    return SMN.Ruin3;
                }

                if (actionID == BLU.BLU8)
                {
                    return SMN.AstralImpulse;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerRuinPhoenixFeature))
            {
                if (actionID == BLU.BLU7)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.Ruin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.Ruin2;
                    return SMN.Ruin3;
                }

                if (actionID == BLU.BLU9)
                {
                    return SMN.FountainOfFire;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerRuinSolarBahamutFeature))
            {
                if (actionID == BLU.BLU7)
                {
                    if (level < SMN.Levels.Ruin2)
                        return SMN.Ruin;
                    if (level < SMN.Levels.Ruin3)
                        return SMN.Ruin2;
                    return SMN.Ruin3;
                }

                if (actionID == BLU.BLU10)
                {
                    return SMN.UmbralImpulse;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerTriDisasterUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerTriDisasterBahamutFeature))
            {
                if (actionID == BLU.BLU11)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.Outburst;
                    return SMN.TriDisaster;
                }

                if (actionID == BLU.BLU12)
                {
                    return SMN.AstralFlare;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerTriDisasterPhoenixFeature))
            {
                if (actionID == BLU.BLU11)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.Outburst;
                    return SMN.TriDisaster;
                }

                if (actionID == BLU.BLU13)
                {
                    return SMN.BrandOfPurgatory;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerTriDisasterSolarBahamutFeature))
            {
                if (actionID == BLU.BLU11)
                {
                    if (level < SMN.Levels.TriDisaster)
                        return SMN.Outburst;
                    return SMN.TriDisaster;
                }

                if (actionID == BLU.BLU14)
                {
                    return SMN.UmbralFlare;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerAstralFlowUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerIfritFlowFeature))
            {
                if (actionID == BLU.BLU15)
                {
                    return SMN.CrimsonCyclone;
                }

                if (actionID == BLU.BLU16)
                {
                    return SMN.CrimsonStrike;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerTitanFlowFeature))
            {
                if (actionID == BLU.BLU17)
                {
                    return SMN.MountainBuster;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerGarudaFlowFeature))
            {
                if (actionID == BLU.BLU18)
                {
                    return SMN.Slipstream;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerBahamutFlowFeature))
            {
                if (actionID == BLU.BLU19)
                {
                    return SMN.Deathflare;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerPhoenixFlowFeature))
            {
                if (actionID == BLU.BLU20)
                {
                    return SMN.Rekindle;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerSolarBahamutFlowFeature))
            {
                if (actionID == BLU.BLU21)
                {
                    return SMN.Sunflare;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerEnkindleUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummoneBahamutEnkindleFeature))
            {
                if (actionID == BLU.BLU22)
                {
                    return SMN.EnkindleBahamut;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerPhoenixEnkindleFeature))
            {
                if (actionID == BLU.BLU23)
                {
                    return SMN.EnkindlePhoenix;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerSolarBahamutEnkindleFeature))
            {
                if (actionID == BLU.BLU24)
                {
                    return SMN.EnkindleSolarBahamut;
                }
            }
        }

        if (IsEnabled(CustomComboPreset.SummonerSummoningUncombo))
        {
            if (IsEnabled(CustomComboPreset.SummonerBahamutSummoningFeature))
            {
                if (actionID == BLU.BLU25)
                {
                    if (level < SMN.Levels.DreadwyrmTrance)
                        return SMN.Infuse;
                    if (level < SMN.Levels.SummonBahamut)
                        return SMN.DreadwyrmTrance;
                    return SMN.SummonBahamut;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerPhoenixSummoningFeature))
            {
                if (actionID == BLU.BLU26)
                {
                    return SMN.SummonPhoenix;
                }
            }

            if (IsEnabled(CustomComboPreset.SummonerSolarBahamutSummoningFeature))
            {
                if (actionID == BLU.BLU27)
                {
                    return SMN.SummonSolarBahamut;
                }
            }
        }

        return actionID;
    }
}