using FFXIVClientStructs.FFXIV.Component.GUI;
using XIVUncombo.Attributes;
using XIVUncombo.Combos;

using UTL = XIVUncombo.Attributes.IconsComboAttribute;

namespace XIVUncombo;

/// <summary>
/// Combo presets.
/// </summary>
public enum CustomComboPreset
{
    // ====================================================================================
    #region Misc

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
    AdvAny = 0,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
    AstAny = AdvAny + AST.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
    BlmAny = AdvAny + BLM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
    BrdAny = AdvAny + BRD.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
    DncAny = AdvAny + DNC.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
    DohAny = AdvAny + DOH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
    DolAny = AdvAny + DOL.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
    DrgAny = AdvAny + DRG.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
    DrkAny = AdvAny + DRK.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
    GnbAny = AdvAny + GNB.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
    MchAny = AdvAny + MCH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
    MnkAny = AdvAny + MNK.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
    NinAny = AdvAny + NIN.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
    PldAny = AdvAny + PLD.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
    RdmAny = AdvAny + RDM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
    RprAny = AdvAny + RPR.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
    SamAny = AdvAny + SAM.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
    SchAny = AdvAny + SCH.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
    SgeAny = AdvAny + SGE.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
    SmnAny = AdvAny + SMN.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
    WarAny = AdvAny + WAR.JobID,

    [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
    WhmAny = AdvAny + WHM.JobID,

    [CustomComboInfo("Disabled", "This should not be used.", ADV.JobID)]
    Disabled = 99999,

    #endregion
    // ====================================================================================
    #region ADV (empty)

    #endregion
    // ====================================================================================
    #region ASTROLOGIAN
    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-10 to your hotbar.", AST.JobID)]
    AstrologianUncombo = 3301,

    [IconsCombo([AST.Balance, UTL.ArrowRight, BLU.BLU1])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Balance (lvl 30+)", "Water Cannon becomes the Balance.", AST.JobID)]
    AstrologianBalanceFeature = 3303,

    [IconsCombo([AST.Arrow, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Arrow (lvl 30+)", "Flame Thrower becomes the Arrow.", AST.JobID)]
    AstrologianArrowFeature = 3304,

    [IconsCombo([AST.Spire, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Spire (lvl 30+)", "Aqua Breath becomes the Spire.", AST.JobID)]
    AstrologianSpireFeature = 3305,

    [IconsCombo([AST.Spear, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Spear (lvl 30+)", "Flying Frenzy becomes The Spear.", AST.JobID)]
    AstrologianSpearFeature = 3306,

    [IconsCombo([AST.Bole, UTL.ArrowRight, BLU.BLU5])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Bole (lvl 30+)", "Drill Cannons becomes The Bole.", AST.JobID)]
    AstrologianBoleFeature = 3307,

    [IconsCombo([AST.Ewer, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Ewer (lvl 30+)", "High Voltage becomes The Ewer.", AST.JobID)]
    AstrologianEwerFeature = 3308,

    [IconsCombo([AST.LordOfCrowns, UTL.ArrowRight, BLU.BLU7])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Lord of Crowns (lvl 70+)", "Loom becomes The Lord of Crowns.", AST.JobID)]
    AstrologianLordOfCrownsFeature = 3310,

    [IconsCombo([AST.LadyOfCrowns, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("The Lady of Crowns (lvl 70+)", "Fell Sting becomes The Lady of Crowns.", AST.JobID)]
    AstrologianLadyOfCrownsFeature = 3311,

    [IconsCombo([AST.AstralDraw, UTL.ArrowRight, BLU.BLU9, UTL.Blank, AST.UmbralDraw, UTL.ArrowRight, BLU.BLU10])]
    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("Astral/Umbral Draw (lvl 70+)", "Song of Torment and Glower will respectively become Astral Draw and Umbral Draw.", AST.JobID)]
    AstrologianUmbralDrawUncombo = 3312,

    #endregion
    // ====================================================================================
    #region BLACK MAGE

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-2 to your hotbar.", BLM.JobID)]
    BlackMageUncombo = 2501,

    [IconsCombo([BLM.Fire, UTL.ArrowRight, BLU.BLU1, UTL.Blank, BLM.Paradox, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(BlackMageUncombo)]
    [CustomComboInfo("Paradox (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Fire 1 and Paradox.", BLM.JobID)]
    BlackMageParadoxUncombo = 2502,

    #endregion
    // ====================================================================================
    #region BARD

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-2 to your hotbar.", BRD.JobID)]
    BardUncombo = 2301,

    [IconsCombo([BRD.ApexArrow, UTL.ArrowRight, BLU.BLU1, UTL.Blank, BRD.BlastArrow, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(BardUncombo)]
    [CustomComboInfo("Blast Arrow (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Apex Arrow and Blast Arrow.", BRD.JobID)]
    BardBlastArrowUncombo = 2302,

    #endregion
    // ====================================================================================
    #region DANCER

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-20 to your hotbar.", DNC.JobID)]
    DancerUncombo = 3801,

    [IconsCombo([DNC.Cascade, UTL.ArrowRight, BLU.BLU1, UTL.Blank, DNC.Windmill, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DNC.Emboite, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Emboite (lvl 15+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Cascade, Windmill, and Emboite.", DNC.JobID)]
    DancerEmboiteFeature = 3803,

    [IconsCombo([DNC.Fountain, UTL.ArrowRight, BLU.BLU4, UTL.Blank, DNC.Bladeshower, UTL.ArrowRight, BLU.BLU5, UTL.Blank, DNC.Entrechat, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Entrechat (lvl 15+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Fountain, Bladeshower, and Entrechat.", DNC.JobID)]
    DancerEntrechatFeature = 3804,

    [IconsCombo([DNC.ReverseCascade, UTL.ArrowRight, BLU.BLU7, UTL.Blank, DNC.RisingWindmill, UTL.ArrowRight, BLU.BLU8, UTL.Blank, DNC.Jete, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Jete (lvl 15+)", "Loom, Fell Sting, and Song of Torment will respectively become Reverse Cascade, Rising Windmill, and Jete.", DNC.JobID)]
    DancerJeteFeature = 3805,

    [IconsCombo([DNC.Fountainfall, UTL.ArrowRight, BLU.BLU10, UTL.Blank, DNC.Bloodshower, UTL.ArrowRight, BLU.BLU11, UTL.Blank, DNC.Pirouette, UTL.ArrowRight, BLU.BLU12])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Pirouette (lvl 15+)", "Glower, Plaincracker and Bristle will respectively become Fountainfall, Bloodshower, and Pirouette.", DNC.JobID)]
    DancerPirouetteFeature = 3806,

    [IconsCombo([DNC.StandardStep, UTL.ArrowRight, BLU.BLU13, UTL.Blank, DNC.StandardFinish, UTL.ArrowRight, BLU.BLU14])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Standard Dance (lvl 15+)", "White Wind and Petrify lvl 5 become Standard Step and Standard Finish.", DNC.JobID)]
    DancerStandardDanceFeature = 3808,

    [IconsCombo([DNC.TechnicalStep, UTL.ArrowRight, BLU.BLU15, UTL.Blank, DNC.TechnicalFinish, UTL.ArrowRight, BLU.BLU16])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Technical Dance (lvl 70+)", "Sharpened Knife and Ice Spikes become Technical Step and Technical Finish.", DNC.JobID)]
    DancerTechnicalDanceFeature = 3809,

    [IconsCombo([DNC.TechnicalFinish, UTL.ArrowRight, BLU.BLU16, UTL.Blank, DNC.Tillana, UTL.ArrowRight, BLU.BLU17])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Tillana (lvl 82+)", "Ice Spikes and Blood Drain become Technical Finish and Tillana.", DNC.JobID)]
    DancerTillanaFeature = 3811,

    [IconsCombo([DNC.StandardFinish, UTL.ArrowRight, BLU.BLU14, UTL.Blank, DNC.FinishingMove, UTL.ArrowRight, BLU.BLU18])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Finishing Move (lvl 96+)", "Petrify lvl 5 and Acorn Bomb become Standard Finish and Finishing Move.", DNC.JobID)]
    DancerFinishingMoveFeature = 3812,

    [IconsCombo([DNC.SaberDance, UTL.ArrowRight, BLU.BLU19, UTL.Blank, DNC.DanceOfTheDawn, UTL.ArrowRight, BLU.BLU20])]
    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Dance of the Dawn (lvl 100)", "Bomb Toss and Off-Guard become Saber Dance and Dance of the Dawn.", DNC.JobID)]
    DancerDawnUncombo = 3813,

    #endregion
    // ====================================================================================
    #region DARK KNIGHT

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-6 to your hotbar.", DRK.JobID)]
    DarkKnightUncombo = 3201,

    [IconsCombo([DRK.Bloodspiller, UTL.ArrowRight, BLU.BLU1, UTL.Blank, UTL.Blank, DRK.ScarletDelirium, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DRK.Comeuppance, UTL.ArrowRight, BLU.BLU3, DRK.Torcleaver, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(DarkKnightUncombo)]
    [CustomComboInfo("Delirium Single Target (lvl 96+)", "Water Cannon, Flame Thrower, Aqua Breath and Flying Frenzy will respectively become Bloodspiller, Scarlet Delirium, Comeuppance and Torcleaver.", DRK.JobID)]
    DarkKnightDeliriumSTUncombo = 3202,

    [IconsCombo([DRK.Quietus, UTL.ArrowRight, BLU.BLU5, UTL.Blank, DRK.Impalement, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(DarkKnightUncombo)]
    [CustomComboInfo("Delirium AoE (lvl 96+)", "Drill Cannons and High Voltage will respectively become Quietus and Impalement.", DRK.JobID)]
    DarkKnightDeliriumAoEUncombo = 3203,
    #endregion
    // ====================================================================================
    #region DRAGOON

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-7 to your hotbar.", DRG.JobID)]
    DragoonUncombo = 2201,

    [IconsCombo([DRG.WheelingThrust, UTL.ArrowRight, BLU.BLU1, UTL.Blank, DRG.FangAndClaw, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DRG.Drakesbane, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Drakesbane (lvl 64+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Wheeling Thrust, Fang and Claw and Drakesbane.", DRG.JobID)]
    DragoonDrakesbaneUncombo = 2202,

    [IconsCombo([DRG.TrueThrust, UTL.ArrowRight, BLU.BLU4, UTL.Blank, DRG.RaidenThrust, UTL.ArrowRight, BLU.BLU5])]
    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Raiden Thrust (lvl 76+)", "Flying Frenzy and Drill Cannons will respectively become True Thrust and Raiden Thrust.", DRG.JobID)]
    DragoonRaidenThrustUncombo = 2203,

    [IconsCombo([DRG.DoomSpike, UTL.ArrowRight, BLU.BLU6, UTL.Blank, DRG.DraconianFury, UTL.ArrowRight, BLU.BLU7])]
    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Draconian Fury (lvl 82+)", "High Voltage and Loom will respectively become Doom Spike and Draconian Fury.", DRG.JobID)]
    DragoonDraconianFuryUncombo = 2204,

    #endregion
    // ====================================================================================
    #region GUNBREAKER

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-11 to your hotbar.", GNB.JobID)]
    GunbreakerUnCombo = 3701,

    [IconsCombo([GNB.GnashingFang, UTL.ArrowRight, BLU.BLU1, UTL.Blank, GNB.SavageClaw, UTL.ArrowRight, BLU.BLU2, UTL.Blank, GNB.WickedTalon, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Gnashing Fang (lvl 60+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Gnashing Fang, Savage Claw and Wicked Talon.", GNB.JobID)]
    GunbreakerGnashingUnCombo = 3702,

    [IconsCombo([GNB.JugularRip, UTL.ArrowRight, BLU.BLU4, UTL.Blank, GNB.AbdomenTear, UTL.ArrowRight, BLU.BLU5, UTL.Blank, GNB.EyeGouge, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Gnashing Continuation (lvl 70+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Jugular Rip, Abdomen Tear, & Eye Gouge.", GNB.JobID)]
    GunbreakerConsecutionUncombo = 3703,

    [IconsCombo([GNB.Hypervelocity, UTL.ArrowRight, BLU.BLU7])]
    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Hypervelocity Continuation (lvl 86+)", "Loom will become Hypervelocity.", GNB.JobID)]
    GunbreakerHypervelocityUncombo = 3704,

    [IconsCombo([GNB.FatedBrand, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Fated Brand Continuation (lvl 96+)", "Final Sting will become Fated Brand.", GNB.JobID)]
    GunbreakerFatedBrandUncombo = 3705,

    [IconsCombo([GNB.ReignOfBeasts, UTL.ArrowRight, BLU.BLU9, UTL.Blank, GNB.NobleBlood, UTL.ArrowRight, BLU.BLU10, UTL.Blank, GNB.LionHeart, UTL.ArrowRight, BLU.BLU11])]
    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Reign of Beasts (lvl 100)", "Song of Torment, Glower and Plain Cracker will respectively become Reign of Beasts, Noble Blood, and Lionheart.", GNB.JobID)]
    GunbreakerReignUncombo = 3706,

    #endregion
    // ====================================================================================
    #region MACHINIST

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-4 to your hotbar.", MCH.JobID)]
    MachinistUncombo = 3101,

    [IconsCombo([MCH.Wildfire, UTL.ArrowRight, BLU.BLU1, UTL.Blank, MCH.Detonator, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(MachinistUncombo)]
    [CustomComboInfo("Wildfire (lvl 45+)", "Water Cannon and Flame Thrower will respectively become Wildfire and Detonator.", MCH.JobID)]
    MachinistWildfireUncombo = 3102,

    [IconsCombo([MCH.Chainsaw, UTL.ArrowRight, BLU.BLU3, UTL.Blank, MCH.Excavator, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(MachinistUncombo)]
    [CustomComboInfo("Excavator (lvl 60+)", "Aqua Breath and Flying Frenzy will respectively become Chainsaw and Excavator.", MCH.JobID)]
    MachinistExcavatorUncombo = 3103,

    #endregion
    // ====================================================================================
    #region MONK

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-4 to your hotbar.", MNK.JobID)]
    MonkUncombo = 2001,

    [IconsCombo([MNK.ElixirField, UTL.ArrowRight, BLU.BLU1])]
    [ParentCombo(MonkUncombo)]
    [CustomComboInfo("Elixir Field/Burst (lvl 60+)", "Water Cannon will become Elixir Field/Elixir Burst.", MNK.JobID)]
    MonkBlitzElixirUncombo = 2002,

    [IconsCombo([MNK.CelestialRevolution, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(MonkUncombo)]
    [CustomComboInfo("Celestial Revolution (lvl 60+)", "Flame Thrower will become Celestial Revolution.", MNK.JobID)]
    MonkBlitzCelestialUncombo = 2003,

    [IconsCombo([MNK.FlintStrike, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(MonkUncombo)]
    [CustomComboInfo("Flint Strike/Rising Phoenix (lvl 60+)", "Aqua Breath will become Flint Strike/Rising Phoenix.", MNK.JobID)]
    MonkBlitzFlintUncombo = 2004,

    [IconsCombo([MNK.TornadoKick, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(MonkUncombo)]
    [CustomComboInfo("Tornado Kick/Phantom Rush (lvl 60+)", "Flying Frenzy will become Tornado Kick/Phantom Rush.", MNK.JobID)]
    MonkBlitzTornadoUncombo = 2005,

    #endregion
    // ====================================================================================
    #region NINJA

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-15 to your hotbar.", NIN.JobID)]
    NinjaUncombo = 3001,

    [IconsCombo([NIN.FumaShuriken, UTL.ArrowRight, BLU.BLU1])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Fuma Shuriken (lvl 30+)", "Water Cannon becomes Fuma Shuriken.", NIN.JobID)]
    NinjaFumaShurikenFeature = 3003,

    [IconsCombo([NIN.Katon, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Katon (lvl 35+)", "Flame Thrower becomes Katon.", NIN.JobID)]
    NinjaKatonFeature = 3004,

    [IconsCombo([NIN.Raiton, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Raiton (lvl 35+)", "Aqua Breath becomes Raiton.", NIN.JobID)]
    NinjaRaitonFeature = 3005,

    [IconsCombo([NIN.Hyoton, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Hyoton (lvl 45+)", " becomes Hyoton.", NIN.JobID)]
    NinjaHyotonFeature = 3006,

    [IconsCombo([NIN.Huton, UTL.ArrowRight, BLU.BLU5])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Huton (lvl 45+)", "Drill Cannons becomes Huton.", NIN.JobID)]
    NinjaHutonFeature = 3007,

    [IconsCombo([NIN.Doton, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Doton (lvl 45+)", "High Voltage becomes Doton.", NIN.JobID)]
    NinjaDotonFeature = 3008,

    [IconsCombo([NIN.Suiton, UTL.ArrowRight, BLU.BLU7])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Suiton (lvl 45+)", "Loom becomes Suiton.", NIN.JobID)]
    NinjaSuitonFeature = 3009,

    [IconsCombo([NIN.GokkaMekkyaku, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Goka Mekkyaku (lvl 76+)", "Fell Sting becomes Goka Mekkyaku.", NIN.JobID)]
    NinjaGokaMekkyakuFeature = 3011,

    [IconsCombo([NIN.HyoshoRanryu, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Hyosho Ranryu (lvl 76+)", "Song of Torment becomes Hyosho Ranryu.", NIN.JobID)]
    NinjaHyoshoRanryuFeature = 3012,

    [IconsCombo([NIN.KuchiyoseOgama, UTL.ArrowRight, BLU.BLU10, NIN.KuchiyoseGamasen, UTL.ArrowRight, BLU.BLU11])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Kuchiyose Gamasen (lvl 96+)", "Glower and Plaincracker will respectively become Kuchiyose Ogama and Kuchiyose Gamasen.", NIN.JobID)]
    NinjaKuchiyoseGamasenFeature = 3014,

    [IconsCombo([NIN.Bhavacakra, UTL.ArrowRight, BLU.BLU12, UTL.Blank, NIN.ZeshoMeppo, UTL.ArrowRight, BLU.BLU13])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Zesho Meppo (lvl 96+)", "Bristle and White Wind will respectively become Bhavacakra and Zesho Meppo.", NIN.JobID)]
    NinjaZeshoMeppoFeature = 3015,

    [IconsCombo([NIN.TenChiJin, UTL.ArrowRight, BLU.BLU14, UTL.Blank, NIN.TenriJido, UTL.ArrowRight, BLU.BLU15])]
    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Tenri Jido (lvl 100)", "Petrify lvl 5 and Sharpened Knife become Ten Chi Jin and Tenri Jido.", NIN.JobID)]
    NinjaTenriJidoUncombo = 3016,

    #endregion
    // ====================================================================================
    #region PALADIN

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-9 to your hotbar.", PLD.JobID)]
    PaladinUncombo = 1901,

    [IconsCombo([PLD.Imperator, UTL.ArrowRight, BLU.BLU1, UTL.Blank, PLD.BladeOfHonor, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Imperator (lvl 96+)", "Water Cannon and Flame Thrower will respectively become Imperator and Blade of Honor.", PLD.JobID)]
    PaladinImperatorBladesUncombo = 1902,

    [IconsCombo([PLD.Confiteor, UTL.ArrowRight, BLU.BLU3, UTL.Blank, PLD.BladeOfFaith, UTL.ArrowRight, BLU.BLU4, UTL.Blank, PLD.BladeOfTruth, UTL.ArrowRight, BLU.BLU5, UTL.Blank, PLD.BladeOfValor, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Blades (lvl 90+)", "Aqua Breath, Flying Frenzy, Drill Cannons and High Voltage will respectively become Confiteor, Blade of Faith, Blade of Truth and Blade of Valor.", PLD.JobID)]
    PaladinBladesUncombo = 1903,

    [IconsCombo([PLD.Atonement, UTL.ArrowRight, BLU.BLU7, UTL.Blank, PLD.Supplication, UTL.ArrowRight, BLU.BLU8, UTL.Blank, PLD.Sepulchre, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Atonement (lvl 76+)", "Loom, Fell Sting and Song of Torment will respectively become Atonement, Supplication and Sepulchre.", PLD.JobID)]
    PaladinAtonementUncombo = 1904,

    #endregion
    // ====================================================================================
    #region PICTOMANCER

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-15 to your hotbars.", PCT.JobID)]
    PictomancerUncombo = 4201,

    [ParentCombo(PictomancerUncombo)]
    [CustomComboInfo("Fire in Red (lvl 1+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Fire in Red, Aero in Green, and Water in Blue.", PCT.JobID)]
    PictomancerFireUncombo = 4202,

    [ParentCombo(PictomancerUncombo)]
    [CustomComboInfo("Blizzard in Cyan (lvl 60+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Blizzard in Cyan, Stone in Yellow, and Thunder in Magenta.", PCT.JobID)]
    PictomancerBlizzardUncombo = 4203,

    [ParentCombo(PictomancerUncombo)]
    [CustomComboInfo("Fire II in Red (lvl 50+)", "Loom, Final Sting and Song of Torment will respectively become Fire in Red II, Aero in Green II, and Water in Blue II.", PCT.JobID)]
    PictomancerFire2Uncombo = 4204,

    [ParentCombo(PictomancerUncombo)]
    [CustomComboInfo("Blizzard II in Cyan (lvl 60+)", "Glower, Plain Cracker and Bristle will respectively become Blizzard in Cyan II, Stone in Yellow II, and Thunder in Magenta II.", PCT.JobID)]
    PictomancerBlizzard2Uncombo = 4205,

    [ParentCombo(PictomancerUncombo)]
    [CustomComboInfo("Hammer Stamp (lvl 50+)", "White Wind, Level 5 Petrify and Sharpened Knife will respectively become Blizzard in Cyan II, Stone in Yellow II, and Thunder in Magenta II.", PCT.JobID)]
    PictomancerHammerUncombo = 4206,

    #endregion
    // ====================================================================================
    #region REAPER

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-24 to your hotbar.", RPR.JobID)]
    ReaperUncombo = 3901,

    [IconsCombo([RPR.BloodStalk, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RPR.UnveiledGibbet, UTL.ArrowRight, BLU.BLU2, UTL.Blank, RPR.UnveiledGallows, UTL.ArrowRight, BLU.BLU3 ])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Unveiled Gibbet/Gallows (lvl 70+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Blood Stalk, Unveiled Gibbet and Unveiled Gallows.", RPR.JobID)]
    ReaperUnveiledUncombo = 3902,

    [IconsCombo([RPR.HellsIngress, UTL.ArrowRight, BLU.BLU4, UTL.Blank, RPR.HellsEgress, UTL.ArrowRight, BLU.BLU5, UTL.Blank, RPR.Regress, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Regress (lvl 74+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Hell's Ingress, Hell's Egress and Regress.", RPR.JobID)]
    ReaperRegressUncombo = 3903,

    [IconsCombo([RPR.Gibbet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RPR.VoidReaping, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Void Reaping (lvl 80+)", "Loom and Fell Sting will respectively become Gibbet and Void Reaping.", RPR.JobID)]
    ReaperVoidReapingUncombo = 3904,

    [IconsCombo([RPR.Gallows, UTL.ArrowRight, BLU.BLU9, UTL.Blank, RPR.CrossReaping, UTL.ArrowRight, BLU.BLU10])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Cross Reaping (lvl 80+)", "Song of Torment and Glower will respectively become Gallows and Cross Reaping.", RPR.JobID)]
    ReaperCrossReapingUncombo = 3905,

    [IconsCombo([RPR.Guillotine, UTL.ArrowRight, BLU.BLU11, UTL.Blank, RPR.GrimReaping, UTL.ArrowRight, BLU.BLU12])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Grim Reaping (lvl 80+)", "Plaincracker and Bristle will respectively become Guillotine and Grim Reaping.", RPR.JobID)]
    ReaperGrimReapingUncombo = 3906,

    [IconsCombo([RPR.Soulsow, UTL.ArrowRight, BLU.BLU13, UTL.Blank, RPR.HarvestMoon, UTL.ArrowRight, BLU.BLU14])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Harvest Moon (lvl 82+)", "White Wind and Petrify lvl 5 will respectively become Soulsow and Harvest Moon.", RPR.JobID)]
    ReaperHarvestMoonUncombo = 3907,

    [IconsCombo([RPR.BloodStalk, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RPR.GrimSwathe, UTL.ArrowRight, BLU.BLU15, UTL.Blank, RPR.LemuresSlice, UTL.ArrowRight, BLU.BLU16, UTL.Blank, RPR.LemuresScythe, UTL.ArrowRight, BLU.BLU17])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Lemure (lvl 86+)", "Water Cannon, Sharpened Knife, Ice Spikes, Blood Drain will respectively become Blood Stalk, Grim Swathe, Lemure's Slice and Lemure's Scythe.", RPR.JobID)]
    ReaperLemureUncombo = 3908,

    [IconsCombo([RPR.Gluttony, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RPR.Sacrificium, UTL.ArrowRight, BLU.BLU19])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Sacrificium (lvl 92+)", "Acorn Bom and Bomb Toss will respectively become Glutonny and Sacrificium.", RPR.JobID)]
    ReaperSacrificiumUncombo = 3909,

    [IconsCombo([RPR.Gibbet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RPR.ExecutionerGibet, UTL.ArrowRight, BLU.BLU20])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Executioner Gibbet (lvl 96+)", "Loom and Off-Guard will respectively become Gibbet and Executioner's Gibbet.", RPR.JobID)]
    ReaperExecutionerGibbetUncombo = 3910,

    [IconsCombo([RPR.Gallows, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RPR.ExecutionerGallows, UTL.ArrowRight, BLU.BLU21])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Executioner Gallows (lvl 96+)", "Fell Sting and Self-Destruct will respectively become Gallows and Executioner's Gallows.", RPR.JobID)]
    ReaperExecutionerGallowsUncombo = 3911,

    [IconsCombo([RPR.Guillotine, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RPR.ExecutionerGuillotine, UTL.ArrowRight, BLU.BLU22])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Executioner Guillotine (lvl 96+)", "Song of Torment and Transfusion will respectively become Guillotine and Executioner's Guillotine.", RPR.JobID)]
    ReaperExecutionerGuillotineUncombo = 3912,

    [IconsCombo([RPR.Communio, UTL.ArrowRight, BLU.BLU23, UTL.Blank, RPR.Perfectio, UTL.ArrowRight, BLU.BLU24])]
    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Perfectio (lvl 100)", "Faze and Flying Sardine will respectively become Communio and Perfectio.", RPR.JobID)]
    ReaperPerfectioUncombo = 3913,

    #endregion
    // ====================================================================================
    #region RED MAGE

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-25 to your hotbar.", RDM.JobID)]
    RedMageUncombo = 3501,

    [IconsCombo([RDM.Riposte, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RDM.Zwerchhau, UTL.ArrowRight, BLU.BLU2, UTL.Blank, RDM.Redoublement, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Non-Enchanted Melee (lvl 1+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Riposte, Zwerchhau, Redoublement.", RDM.JobID)]
    RedMageNonEnchantedSTFeature = 3502,

    [IconsCombo([RDM.EnchantedRiposte, UTL.ArrowRight, BLU.BLU4, UTL.Blank, RDM.EnchantedZwerchhau, UTL.ArrowRight, BLU.BLU5, UTL.Blank, RDM.EnchantedRedoublement, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Enchanted Melee (lvl 1+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Enchanted Riposte, Enchanted Zwerchhau and Enchanted Redoublement.", RDM.JobID)]
    RedMageEnchantedSTFeature = 3503,

    [IconsCombo([RDM.EnchantedMoulinet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RDM.EnchantedMoulinetDeux, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RDM.EnchantedMoulinetTrois, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Enchanted Moulinet (lvl 52+)", "Loom, Fell Sting, Song of Torment and Glower will respectively become Moulinet, Enchanted Moulinet, Enchanted Moulinet Deux and Enchanted Moulinet Trois.", RDM.JobID)]
    RedMageEnchantedAoEFeature = 3504,

    [IconsCombo([RDM.Reprise, UTL.ArrowRight, BLU.BLU10, UTL.Blank, RDM.EnchantedReprise, UTL.ArrowRight, BLU.BLU11])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Enchanted Reprise (lvl 76+)", "Plaincracker and Bristle will respectively become Reprise and Enchanted Reprise.", RDM.JobID)]
    RedMageEnchantedRangedFeature = 3505,

    [IconsCombo([RDM.Verthunder, UTL.ArrowRight, BLU.BLU12, UTL.Blank, RDM.Verthunder2, UTL.ArrowRight, BLU.BLU13, UTL.Blank, RDM.Verflare, UTL.ArrowRight, BLU.BLU14])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("VerFlare (lvl 68+)", "White Wind, Petrify lvl 5 and Sharpened Knife will respectively become Verthunder (3), Verthunder 2, and Verflare.", RDM.JobID)]
    RedMageVerFlareFeature = 3507,

    [IconsCombo([RDM.Veraero, UTL.ArrowRight, BLU.BLU15, UTL.Blank, RDM.Veraero2, UTL.ArrowRight, BLU.BLU16, UTL.Blank, RDM.Verholy, UTL.ArrowRight, BLU.BLU17])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("VerHoly (lvl 70+)", "Ice Spikes, Blood Drain and Acorn Bomb will respectively become Veraero (3), Veraero 2, and Verholy.", RDM.JobID)]
    RedMageVerHolyFeature = 3508,

    [IconsCombo([RDM.Jolt, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RDM.Impact, UTL.ArrowRight, BLU.BLU19, UTL.Blank, RDM.Scorch, UTL.ArrowRight, BLU.BLU20])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Scorch (lvl 80+)", "Bomb Toss, Off-Guard and Self-Destruct will respectively become Jolt (3), Impact and Scorch.", RDM.JobID)]
    RedMageScorchFeature = 3509,

    [IconsCombo([RDM.Resolution, UTL.ArrowRight, BLU.BLU21])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Resolution (lvl 90+)", "Transfusion will become Resolution.", RDM.JobID)]
    RedMageResolutionFeature = 3510,

    [IconsCombo([RDM.Jolt, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RDM.Impact, UTL.ArrowRight, BLU.BLU22, UTL.Blank, RDM.GrandImpact, UTL.ArrowRight, BLU.BLU23])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Grand Impact (lvl 96+)", "Bomb Toss, Off-Guard and Faze will respectively become Jolt (3), Impact and Grand Impact.", RDM.JobID)]
    RedMageGrandImpactUncombo = 3511,

    [IconsCombo([RDM.Manafication, UTL.ArrowRight, BLU.BLU24, UTL.Blank, RDM.Prefulgence, UTL.ArrowRight, BLU.BLU25])]
    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Prefulgence (lvl 100)", "Flying Sardine and Snort will respectively become Manafication and Prefulgence.", RDM.JobID)]
    RedMagePrefulgenceUncombo = 3512,

    #endregion
    // ====================================================================================
    #region SAGE (empty)

    #endregion
    // ====================================================================================
    #region SAMURAI

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-11 to your hotbar.", SAM.JobID)]
    SamuraiUncombo = 3401,

    [IconsCombo([SAM.Higanbana, UTL.ArrowRight, BLU.BLU1])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Higanbana (lvl 30+)", "Water Cannon becomes Higanbana.", SAM.JobID)]
    SamuraiHiganbanaFeature = 3403,

    [IconsCombo([SAM.TenkaGoken, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tenka Goken (lvl 40+)", "Flame Thrower becomes Tenka Goken.", SAM.JobID)]
    SamuraiGokenFeature = 3404,

    [IconsCombo([SAM.Midare, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Midare Setsugekka (lvl 50+)", "Aqua Breath becomes Midare Setsugekka.", SAM.JobID)]
    SamuraiMidareFeature = 3405,

    [IconsCombo([SAM.KaeshiGoken, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Kaeshi: Goken (lvl 76+)", "Flying Frenzy becomes Kaeshi: Goken.", SAM.JobID)]
    SamuraiKaeshiGokenFeature = 3407,

    [IconsCombo([SAM.KaeshiSetsugekka, UTL.ArrowRight, BLU.BLU5])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Kaeshi: Setsugekka (lvl 76+)", "Drill Cannons becomes Kaeshi: Setsugekka.", SAM.JobID)]
    SamuraiKaeshiSetsugekkaFeature = 3408,

    [IconsCombo([SAM.OgiNamikiri, UTL.ArrowRight, BLU.BLU6, UTL.Blank, SAM.KaeshiNamikiri, UTL.ArrowRight, BLU.BLU7])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Kaeshi: Namikiri (lvl 90+)", "High Voltage and Loom will respectively become Ogi Namikiri and Kaeshi: Namikiri.", SAM.JobID)]
    SamuraiKaeshiNamikiriFeature = 3409,

    [IconsCombo([SAM.TendoGoken, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Goken (lvl 100)", "Fell Sting becomes Tendo Goken.", SAM.JobID)]
    SamuraiTendoGokenFeature = 3411,

    [IconsCombo([SAM.TendoSetsugekka, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Setsugekka (lvl 100)", "Song of Torment becomes Tendo Setsugekka.", SAM.JobID)]
    SamuraiTendoMidareFeature = 3412,

    [IconsCombo([SAM.TendoKaeshiGoken, UTL.ArrowRight, BLU.BLU10])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Kaeshi Goken (lvl 100)", "Glower bcomes Tendo Kaeshi Goken.", SAM.JobID)]
    SamuraiTendoKaeshiGokenFeature = 3414,

    [IconsCombo([SAM.TendoKaeshiSetsugekka, UTL.ArrowRight, BLU.BLU11])]
    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Kaeshi Setsugekka (lvl 100)", "Plaincracker becomes Tendo Kaeshi Setsugekka.", SAM.JobID)]
    SamuraiTendoKaeshiMidareFeature = 3415,

    #endregion
    // ====================================================================================
    #region SCHOLAR (empty)

    #endregion
    // ====================================================================================
    #region SUMMONER

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-27 to your hotbar.", SMN.JobID)]
    SummonerUncombo = 2700,

    [IconsCombo([SMN.RubyRite, UTL.ArrowRight, BLU.BLU1])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Ifrit Gemshine Feature (lvl 6+)", "Water Cannon becomes Ruby Ruin/Ruby Ruin 2/Ruby Ruin 3/Ruby Rite.", SMN.JobID)]
    SummonerGemshineIfritFeature = 2702,

    [IconsCombo([SMN.TopazRite, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Titan Gemshine Feature (lvl 6+)", "Flame Thrower becomes Topaz Ruin/Topaz Ruin 2/Topaz Ruin 3/Topaz Rite.", SMN.JobID)]
    SummonerGemshineTitanFeature = 2703,

    [IconsCombo([SMN.EmeraldRite, UTL.ArrowRight, BLU.BLU3])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Garuda Gemshine Feature (lvl 6+)", "Aqua Breath becomes Emerald Ruin/Emerald Ruin 2/Emerald Ruin 3/Emerald Rite.", SMN.JobID)]
    SummonerGemshineGarudaFeature = 2704,

    [IconsCombo([SMN.RubyCatastrophe, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Ifrit Brillance Feature (lvl 6+)", "Flying Frenzy becomes Ruby Outburst/Ruby Disaster/Ruby Catastrophe.", SMN.JobID)]
    SummonerBrillanceIfritFeature = 2706,

    [IconsCombo([SMN.TopazCatastrophe, UTL.ArrowRight, BLU.BLU5])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Titan Brillance Feature (lvl 6+)", "Drill Cannons becomes Topaz Outburst/Emerald Disaster/Topaz Catastrophe.", SMN.JobID)]
    SummonerBrillanceTitanFeature = 2707,

    [IconsCombo([SMN.EmeraldCatastrophe, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Garuda Brillance Feature (lvl 6+)", "High Voltage becomes Emerald Outburst/Emerald Disaster/Emerald Catastrophe.", SMN.JobID)]
    SummonerBrillanceGarudaFeature = 2708,

    [IconsCombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.AstralImpulse, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Bahamut's Ruin Feature (lvl 70+)", "Loom and Fell Sting will respectively becomes Ruin 1/2/3 and Astral Impulse.", SMN.JobID)]
    SummonerRuinBahamutFeature = 2710,

    [IconsCombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.FountainOfFire, UTL.ArrowRight, BLU.BLU9])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Phoenix's Ruin Feature (lvl 80+)", "Loom and Song of Torment will respectively becomes Ruin 1/2/3 and Fountain of Fire.", SMN.JobID)]
    SummonerRuinPhoenixFeature = 2711,

    [IconsCombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.UmbralImpulse, UTL.ArrowRight, BLU.BLU10])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Solar Bahamut Ruin Feature (lvl 100)", "Loom and Glower will respectively becomes Ruin 1/2/3 and Umbral Impulse", SMN.JobID)]
    SummonerRuinSolarBahamutFeature = 2712,

    [IconsCombo([SMN.Outburst, UTL.ArrowRight, BLU.BLU11, UTL.Blank, SMN.AstralFlare, UTL.ArrowRight, BLU.BLU12])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Bahamut's Tri-Disaster Feature (lvl 70+)", "Plaincracker and Bristle will respectively becomes Outburst/Tri-Disaster and Astral Flare.", SMN.JobID)]
    SummonerTriDisasterBahamutFeature = 2714,

    [IconsCombo([SMN.Outburst, UTL.ArrowRight, BLU.BLU11, UTL.Blank, SMN.BrandOfPurgatory, UTL.ArrowRight, BLU.BLU13])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Phoenix's Tri-Disaster Feature (lvl 80+)", "Plaincracker and White Wind will respectively becomes Outburst/Tri-Disaster and Brand of Purgatory.", SMN.JobID)]
    SummonerTriDisasterPhoenixFeature = 2715,

    [IconsCombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.UmbralFlare, UTL.ArrowRight, BLU.BLU14])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Solar Bahamut Tri-Disaster Feature (lvl 100)", "Plaincracker and Petrify lvl 5 will respectively becomes Ruin 1/2/3 and Umbral Flare", SMN.JobID)]
    SummonerTriDisasterSolarBahamutFeature = 2716,

    [IconsCombo([SMN.CrimsonCyclone, UTL.ArrowRight, BLU.BLU15, UTL.Blank, SMN.CrimsonStrike, UTL.ArrowRight, BLU.BLU16])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Ifrit's Crimson Cyclone Feature (lvl 86+)", "Sharpened Knife and Ice Spikes will respectively becomes Crimson Cyclone and Crimson Strike.", SMN.JobID)]
    SummonerIfritFlowFeature = 2718,

    [IconsCombo([SMN.Slipstream, UTL.ArrowRight, BLU.BLU17])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Garuda's Slipstream Feature (lvl 86+)", "Blood Drain becomes Slipstream.", SMN.JobID)]
    SummonerTitanFlowFeature = 2719,

    [IconsCombo([SMN.MountainBuster, UTL.ArrowRight, BLU.BLU18])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Titan's Mountain Buster Feature (lvl 86+)", "Acorn Bomb becomes Mountain Buster.", SMN.JobID)]
    SummonerGarudaFlowFeature = 2720,

    [IconsCombo([SMN.Deathflare, UTL.ArrowRight, BLU.BLU19])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Bahamut's Deathflare Feature (lvl 60+)", "Bomb Toss becomes Deathflare.", SMN.JobID)]
    SummonerBahamutFlowFeature = 2721,

    [IconsCombo([SMN.Rekindle, UTL.ArrowRight, BLU.BLU20])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Off-Guard becomes Phoenix's Rekindle.", SMN.JobID)]
    SummonerPhoenixFlowFeature = 2722,

    [IconsCombo([SMN.Sunflare, UTL.ArrowRight, BLU.BLU21])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Solar Bahamut Sunflare Feature (lvl 100)", "Self-destruct becomes Sunflare.", SMN.JobID)]
    SummonerSolarBahamutFlowFeature = 2723,

    [IconsCombo([SMN.EnkindleBahamut, UTL.ArrowRight, BLU.BLU22])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Bahamut's Ahk Morn Feature (lvl 60+)", "Transfusion becomes Bahamut's Enkindle.", SMN.JobID)]
    SummoneBahamutEnkindleFeature = 2725,

    [IconsCombo([SMN.EnkindlePhoenix, UTL.ArrowRight, BLU.BLU23])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Daze becomes Phoenix's Enkindle.", SMN.JobID)]
    SummonerPhoenixEnkindleFeature = 2726,

    [IconsCombo([SMN.EnkindleSolarBahamut, UTL.ArrowRight, BLU.BLU24])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Solar Bahamut's Rekindle Feature (lvl 100)", "Flying Sardine becomes Solar Bahamut's Enkindle.", SMN.JobID)]
    SummonerSolarBahamutEnkindleFeature = 2727,

    [IconsCombo([SMN.Aethercharge, UTL.ArrowRight, BLU.BLU25])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summon Bahamut Feature (lvl 6+)", "Snort becomes Aethercharge/Dreadwyrm Trance/Summon Bahamut.", SMN.JobID)]
    SummonerBahamutSummoningFeature = 2729,

    [IconsCombo([SMN.SummonPhoenix, UTL.ArrowRight, BLU.BLU26])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summon Phoenix Feature (lvl 80+)", "4-tonze Weight becomes Summon Phoenix.", SMN.JobID)]
    SummonerPhoenixSummoningFeature = 2730,

    [IconsCombo([SMN.SummonSolarBahamut, UTL.ArrowRight, BLU.BLU27])]
    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summon Solar Bahamut Feature (lvl 100)", "The Look becomes Summon Solar Bahamut.", SMN.JobID)]
    SummonerSolarBahamutSummoningFeature = 2731,

    #endregion
    // ====================================================================================
    #region VIPER

    [CustomComboInfo("Enable", "All in one. Assign BLU spells from 1 to 40. Yes. 40.", VPR.JobID)]
    ViperUncombo = 4100,

    #endregion
    // ====================================================================================
    #region WARRIOR

    [CustomComboInfo("Enable", "You will have to manually assign BLU spells 1-8 to your hotbar.", WAR.JobID)]
    WarriorUncombo = 2101,

    [IconsCombo([WAR.Decimate, UTL.ArrowRight, BLU.BLU1, UTL.Blank, WAR.ChaoticCyclone, UTL.ArrowRight, BLU.BLU2])]
    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Chaotic Cyclone (lvl 72+)", "Water Cannon and Flame Thrower will respectively become Decimate and Chaotic Cyclone.", WAR.JobID)]
    WarriorChaoticCycloneUncombo = 2102,

    [IconsCombo([WAR.FellCleave, UTL.ArrowRight, BLU.BLU3, UTL.Blank, WAR.InnerChaos, UTL.ArrowRight, BLU.BLU4])]
    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Inner Chaos (lvl 80+)", "Aqua Breath and Flying Frenzy will respectively become Fell Cleave and Inner Chaos.", WAR.JobID)]
    WarriorInnerChaosUncombo = 2103,

    [IconsCombo([WAR.InnerRelease, UTL.ArrowRight, BLU.BLU5, UTL.Blank, WAR.PrimalWrath, UTL.ArrowRight, BLU.BLU6])]
    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Primal Wrath (lvl 96+)", "Drill Cannons and High Voltage will respectively become Inner Release and Primal Wrath.", WAR.JobID)]
    WarriorPrimalWrathUncombo = 2104,

    [IconsCombo([WAR.PrimalRend, UTL.ArrowRight, BLU.BLU7, UTL.Blank, WAR.PrimalRuination, UTL.ArrowRight, BLU.BLU8])]
    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Primal Ruination (lvl 100)", "Loom and Fell Sting will respectively become Primal Rend and Primal Ruination.", WAR.JobID)]
    WarriorPrimalRuinationUncombo = 2105,

    #endregion
    // ====================================================================================
    #region WHITE MAGE (empty)

    #endregion
    // ====================================================================================
    #region DOH (empty)

    #endregion
    // ====================================================================================
    #region DOL (empty)

    #endregion
    // ====================================================================================
}
