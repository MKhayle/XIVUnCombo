using XIVUncombo.Attributes;
using XIVUncombo.Uncombos;
using UTL = XIVUncombo.Attributes.IconsUncomboAttribute;

namespace XIVUncombo;

/// <summary>
/// Combo presets.
/// </summary>
public enum CustomUncomboPreset
{
    // ====================================================================================
    #region Misc

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
    AdvAny = 0,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
    AstAny = AdvAny + AST.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
    BlmAny = AdvAny + BLM.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
    BrdAny = AdvAny + BRD.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
    DncAny = AdvAny + DNC.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
    DohAny = AdvAny + DOH.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
    DolAny = AdvAny + DOL.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
    DrgAny = AdvAny + DRG.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
    DrkAny = AdvAny + DRK.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
    GnbAny = AdvAny + GNB.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
    MchAny = AdvAny + MCH.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
    MnkAny = AdvAny + MNK.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
    NinAny = AdvAny + NIN.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
    PldAny = AdvAny + PLD.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
    RdmAny = AdvAny + RDM.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
    RprAny = AdvAny + RPR.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
    SamAny = AdvAny + SAM.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
    SchAny = AdvAny + SCH.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
    SgeAny = AdvAny + SGE.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
    SmnAny = AdvAny + SMN.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
    WarAny = AdvAny + WAR.JobID,

    [CustomUncomboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
    WhmAny = AdvAny + WHM.JobID,

    [CustomUncomboInfo("Disabled", "This should not be used.", ADV.JobID)]
    Disabled = 99999,

    #endregion
    // ====================================================================================
    #region ADV (empty)

    #endregion
    // ====================================================================================
    #region ASTROLOGIAN
    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-10 to your hotbar.", AST.JobID)]
    AstrologianUncombo = 3301,

    [IconsUncombo([AST.Balance, UTL.ArrowRight, BLU.BLU1])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Balance (lvl 30+)", "Water Cannon becomes the Balance.", AST.JobID)]
    AstrologianBalanceFeature = 3303,

    [IconsUncombo([AST.Arrow, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Arrow (lvl 30+)", "Flame Thrower becomes the Arrow.", AST.JobID)]
    AstrologianArrowFeature = 3304,

    [IconsUncombo([AST.Spire, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Spire (lvl 30+)", "Aqua Breath becomes the Spire.", AST.JobID)]
    AstrologianSpireFeature = 3305,

    [IconsUncombo([AST.Spear, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Spear (lvl 30+)", "Flying Frenzy becomes The Spear.", AST.JobID)]
    AstrologianSpearFeature = 3306,

    [IconsUncombo([AST.Bole, UTL.ArrowRight, BLU.BLU5])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Bole (lvl 30+)", "Drill Cannons becomes The Bole.", AST.JobID)]
    AstrologianBoleFeature = 3307,

    [IconsUncombo([AST.Ewer, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Ewer (lvl 30+)", "High Voltage becomes The Ewer.", AST.JobID)]
    AstrologianEwerFeature = 3308,

    [IconsUncombo([AST.LordOfCrowns, UTL.ArrowRight, BLU.BLU7])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Lord of Crowns (lvl 70+)", "Loom becomes The Lord of Crowns.", AST.JobID)]
    AstrologianLordOfCrownsFeature = 3310,

    [IconsUncombo([AST.LadyOfCrowns, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("The Lady of Crowns (lvl 70+)", "Fell Sting becomes The Lady of Crowns.", AST.JobID)]
    AstrologianLadyOfCrownsFeature = 3311,

    [IconsUncombo([AST.AstralDraw, UTL.ArrowRight, BLU.BLU9, UTL.Blank, AST.UmbralDraw, UTL.ArrowRight, BLU.BLU10])]
    [ParentUncombo(AstrologianUncombo)]
    [CustomUncomboInfo("Astral/Umbral Draw (lvl 70+)", "Song of Torment and Glower will respectively become Astral Draw and Umbral Draw.", AST.JobID)]
    AstrologianUmbralDrawUncombo = 3312,

    #endregion
    // ====================================================================================
    #region BLACK MAGE

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-2 to your hotbar.", BLM.JobID)]
    BlackMageUncombo = 2501,

    [IconsUncombo([BLM.Fire, UTL.ArrowRight, BLU.BLU1, UTL.Blank, BLM.Paradox, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(BlackMageUncombo)]
    [CustomUncomboInfo("Paradox (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Fire 1 and Paradox.", BLM.JobID)]
    BlackMageParadoxUncombo = 2502,

    #endregion
    // ====================================================================================
    #region BARD

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-2 to your hotbar.", BRD.JobID)]
    BardUncombo = 2301,

    [IconsUncombo([BRD.ApexArrow, UTL.ArrowRight, BLU.BLU1, UTL.Blank, BRD.BlastArrow, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(BardUncombo)]
    [CustomUncomboInfo("Blast Arrow (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Apex Arrow and Blast Arrow.", BRD.JobID)]
    BardBlastArrowUncombo = 2302,

    #endregion
    // ====================================================================================
    #region DANCER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-20 to your hotbar.", DNC.JobID)]
    DancerUncombo = 3801,

    [IconsUncombo([DNC.Cascade, UTL.ArrowRight, BLU.BLU1, UTL.Blank, DNC.Windmill, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DNC.Emboite, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Emboite (lvl 15+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Cascade, Windmill, and Emboite.", DNC.JobID)]
    DancerEmboiteFeature = 3803,

    [IconsUncombo([DNC.Fountain, UTL.ArrowRight, BLU.BLU4, UTL.Blank, DNC.Bladeshower, UTL.ArrowRight, BLU.BLU5, UTL.Blank, DNC.Entrechat, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Entrechat (lvl 15+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Fountain, Bladeshower, and Entrechat.", DNC.JobID)]
    DancerEntrechatFeature = 3804,

    [IconsUncombo([DNC.ReverseCascade, UTL.ArrowRight, BLU.BLU7, UTL.Blank, DNC.RisingWindmill, UTL.ArrowRight, BLU.BLU8, UTL.Blank, DNC.Jete, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Jete (lvl 15+)", "Loom, Fell Sting, and Song of Torment will respectively become Reverse Cascade, Rising Windmill, and Jete.", DNC.JobID)]
    DancerJeteFeature = 3805,

    [IconsUncombo([DNC.Fountainfall, UTL.ArrowRight, BLU.BLU10, UTL.Blank, DNC.Bloodshower, UTL.ArrowRight, BLU.BLU11, UTL.Blank, DNC.Pirouette, UTL.ArrowRight, BLU.BLU12])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Pirouette (lvl 15+)", "Glower, Plaincracker and Bristle will respectively become Fountainfall, Bloodshower, and Pirouette.", DNC.JobID)]
    DancerPirouetteFeature = 3806,

    [IconsUncombo([DNC.StandardStep, UTL.ArrowRight, BLU.BLU13, UTL.Blank, DNC.StandardFinish, UTL.ArrowRight, BLU.BLU14])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Standard Dance (lvl 15+)", "White Wind and Petrify lvl 5 become Standard Step and Standard Finish.", DNC.JobID)]
    DancerStandardDanceFeature = 3808,

    [IconsUncombo([DNC.TechnicalStep, UTL.ArrowRight, BLU.BLU15, UTL.Blank, DNC.TechnicalFinish, UTL.ArrowRight, BLU.BLU16])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Technical Dance (lvl 70+)", "Sharpened Knife and Ice Spikes become Technical Step and Technical Finish.", DNC.JobID)]
    DancerTechnicalDanceFeature = 3809,

    [IconsUncombo([DNC.TechnicalFinish, UTL.ArrowRight, BLU.BLU16, UTL.Blank, DNC.Tillana, UTL.ArrowRight, BLU.BLU17])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Tillana (lvl 82+)", "Ice Spikes and Blood Drain become Technical Finish and Tillana.", DNC.JobID)]
    DancerTillanaFeature = 3811,

    [IconsUncombo([DNC.StandardFinish, UTL.ArrowRight, BLU.BLU14, UTL.Blank, DNC.FinishingMove, UTL.ArrowRight, BLU.BLU18])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Finishing Move (lvl 96+)", "Petrify lvl 5 and Acorn Bomb become Standard Finish and Finishing Move.", DNC.JobID)]
    DancerFinishingMoveFeature = 3812,

    [IconsUncombo([DNC.SaberDance, UTL.ArrowRight, BLU.BLU19, UTL.Blank, DNC.DanceOfTheDawn, UTL.ArrowRight, BLU.BLU20])]
    [ParentUncombo(DancerUncombo)]
    [CustomUncomboInfo("Dance of the Dawn (lvl 100)", "Bomb Toss and Off-Guard become Saber Dance and Dance of the Dawn.", DNC.JobID)]
    DancerDawnUncombo = 3813,

    #endregion
    // ====================================================================================
    #region DARK KNIGHT

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-6 to your hotbar.", DRK.JobID)]
    DarkKnightUncombo = 3201,

    [IconsUncombo([DRK.Bloodspiller, UTL.ArrowRight, BLU.BLU1, UTL.Blank, UTL.Blank, DRK.ScarletDelirium, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DRK.Comeuppance, UTL.ArrowRight, BLU.BLU3, DRK.Torcleaver, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(DarkKnightUncombo)]
    [CustomUncomboInfo("Delirium Single Target (lvl 96+)", "Water Cannon, Flame Thrower, Aqua Breath and Flying Frenzy will respectively become Bloodspiller, Scarlet Delirium, Comeuppance and Torcleaver.", DRK.JobID)]
    DarkKnightDeliriumSTUncombo = 3202,

    [IconsUncombo([DRK.Quietus, UTL.ArrowRight, BLU.BLU5, UTL.Blank, DRK.Impalement, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(DarkKnightUncombo)]
    [CustomUncomboInfo("Delirium AoE (lvl 96+)", "Drill Cannons and High Voltage will respectively become Quietus and Impalement.", DRK.JobID)]
    DarkKnightDeliriumAoEUncombo = 3203,
    #endregion
    // ====================================================================================
    #region DRAGOON

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-7 to your hotbar.", DRG.JobID)]
    DragoonUncombo = 2201,

    [IconsUncombo([DRG.WheelingThrust, UTL.ArrowRight, BLU.BLU1, UTL.Blank, DRG.FangAndClaw, UTL.ArrowRight, BLU.BLU2, UTL.Blank, DRG.Drakesbane, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(DragoonUncombo)]
    [CustomUncomboInfo("Drakesbane (lvl 64+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Wheeling Thrust, Fang and Claw and Drakesbane.", DRG.JobID)]
    DragoonDrakesbaneUncombo = 2202,

    [IconsUncombo([DRG.TrueThrust, UTL.ArrowRight, BLU.BLU4, UTL.Blank, DRG.RaidenThrust, UTL.ArrowRight, BLU.BLU5])]
    [ParentUncombo(DragoonUncombo)]
    [CustomUncomboInfo("Raiden Thrust (lvl 76+)", "Flying Frenzy and Drill Cannons will respectively become True Thrust and Raiden Thrust.", DRG.JobID)]
    DragoonRaidenThrustUncombo = 2203,

    [IconsUncombo([DRG.DoomSpike, UTL.ArrowRight, BLU.BLU6, UTL.Blank, DRG.DraconianFury, UTL.ArrowRight, BLU.BLU7])]
    [ParentUncombo(DragoonUncombo)]
    [CustomUncomboInfo("Draconian Fury (lvl 82+)", "High Voltage and Loom will respectively become Doom Spike and Draconian Fury.", DRG.JobID)]
    DragoonDraconianFuryUncombo = 2204,

    #endregion
    // ====================================================================================
    #region GUNBREAKER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-11 to your hotbar.", GNB.JobID)]
    GunbreakerUnCombo = 3701,

    [IconsUncombo([GNB.GnashingFang, UTL.ArrowRight, BLU.BLU1, UTL.Blank, GNB.SavageClaw, UTL.ArrowRight, BLU.BLU2, UTL.Blank, GNB.WickedTalon, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(GunbreakerUnCombo)]
    [CustomUncomboInfo("Gnashing Fang (lvl 60+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Gnashing Fang, Savage Claw and Wicked Talon.", GNB.JobID)]
    GunbreakerGnashingUnCombo = 3702,

    [IconsUncombo([GNB.JugularRip, UTL.ArrowRight, BLU.BLU4, UTL.Blank, GNB.AbdomenTear, UTL.ArrowRight, BLU.BLU5, UTL.Blank, GNB.EyeGouge, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(GunbreakerUnCombo)]
    [CustomUncomboInfo("Gnashing Continuation (lvl 70+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Jugular Rip, Abdomen Tear, & Eye Gouge.", GNB.JobID)]
    GunbreakerConsecutionUncombo = 3703,

    [IconsUncombo([GNB.Hypervelocity, UTL.ArrowRight, BLU.BLU7])]
    [ParentUncombo(GunbreakerUnCombo)]
    [CustomUncomboInfo("Hypervelocity Continuation (lvl 86+)", "Loom will become Hypervelocity.", GNB.JobID)]
    GunbreakerHypervelocityUncombo = 3704,

    [IconsUncombo([GNB.FatedBrand, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(GunbreakerUnCombo)]
    [CustomUncomboInfo("Fated Brand Continuation (lvl 96+)", "Final Sting will become Fated Brand.", GNB.JobID)]
    GunbreakerFatedBrandUncombo = 3705,

    [IconsUncombo([GNB.ReignOfBeasts, UTL.ArrowRight, BLU.BLU9, UTL.Blank, GNB.NobleBlood, UTL.ArrowRight, BLU.BLU10, UTL.Blank, GNB.LionHeart, UTL.ArrowRight, BLU.BLU11])]
    [ParentUncombo(GunbreakerUnCombo)]
    [CustomUncomboInfo("Reign of Beasts (lvl 100)", "Song of Torment, Glower and Plain Cracker will respectively become Reign of Beasts, Noble Blood, and Lionheart.", GNB.JobID)]
    GunbreakerReignUncombo = 3706,

    #endregion
    // ====================================================================================
    #region MACHINIST

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-4 to your hotbar.", MCH.JobID)]
    MachinistUncombo = 3101,

    [IconsUncombo([MCH.Wildfire, UTL.ArrowRight, BLU.BLU1, UTL.Blank, MCH.Detonator, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(MachinistUncombo)]
    [CustomUncomboInfo("Wildfire (lvl 45+)", "Water Cannon and Flame Thrower will respectively become Wildfire and Detonator.", MCH.JobID)]
    MachinistWildfireUncombo = 3102,

    [IconsUncombo([MCH.Chainsaw, UTL.ArrowRight, BLU.BLU3, UTL.Blank, MCH.Excavator, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(MachinistUncombo)]
    [CustomUncomboInfo("Excavator (lvl 60+)", "Aqua Breath and Flying Frenzy will respectively become Chainsaw and Excavator.", MCH.JobID)]
    MachinistExcavatorUncombo = 3103,

    #endregion
    // ====================================================================================
    #region MONK

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-4 to your hotbar.", MNK.JobID)]
    MonkUncombo = 2001,

    [IconsUncombo([MNK.ElixirField, UTL.ArrowRight, BLU.BLU1])]
    [ParentUncombo(MonkUncombo)]
    [CustomUncomboInfo("Elixir Field/Burst (lvl 60+)", "Water Cannon will become Elixir Field/Elixir Burst.", MNK.JobID)]
    MonkBlitzElixirUncombo = 2002,

    [IconsUncombo([MNK.CelestialRevolution, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(MonkUncombo)]
    [CustomUncomboInfo("Celestial Revolution (lvl 60+)", "Flame Thrower will become Celestial Revolution.", MNK.JobID)]
    MonkBlitzCelestialUncombo = 2003,

    [IconsUncombo([MNK.FlintStrike, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(MonkUncombo)]
    [CustomUncomboInfo("Flint Strike/Rising Phoenix (lvl 60+)", "Aqua Breath will become Flint Strike/Rising Phoenix.", MNK.JobID)]
    MonkBlitzFlintUncombo = 2004,

    [IconsUncombo([MNK.TornadoKick, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(MonkUncombo)]
    [CustomUncomboInfo("Tornado Kick/Phantom Rush (lvl 60+)", "Flying Frenzy will become Tornado Kick/Phantom Rush.", MNK.JobID)]
    MonkBlitzTornadoUncombo = 2005,

    #endregion
    // ====================================================================================
    #region NINJA

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-15 to your hotbar.", NIN.JobID)]
    NinjaUncombo = 3001,

    [IconsUncombo([NIN.FumaShuriken, UTL.ArrowRight, BLU.BLU1])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Fuma Shuriken (lvl 30+)", "Water Cannon becomes Fuma Shuriken.", NIN.JobID)]
    NinjaFumaShurikenFeature = 3003,

    [IconsUncombo([NIN.Katon, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Katon (lvl 35+)", "Flame Thrower becomes Katon.", NIN.JobID)]
    NinjaKatonFeature = 3004,

    [IconsUncombo([NIN.Raiton, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Raiton (lvl 35+)", "Aqua Breath becomes Raiton.", NIN.JobID)]
    NinjaRaitonFeature = 3005,

    [IconsUncombo([NIN.Hyoton, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Hyoton (lvl 45+)", " becomes Hyoton.", NIN.JobID)]
    NinjaHyotonFeature = 3006,

    [IconsUncombo([NIN.Huton, UTL.ArrowRight, BLU.BLU5])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Huton (lvl 45+)", "Drill Cannons becomes Huton.", NIN.JobID)]
    NinjaHutonFeature = 3007,

    [IconsUncombo([NIN.Doton, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Doton (lvl 45+)", "High Voltage becomes Doton.", NIN.JobID)]
    NinjaDotonFeature = 3008,

    [IconsUncombo([NIN.Suiton, UTL.ArrowRight, BLU.BLU7])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Suiton (lvl 45+)", "Loom becomes Suiton.", NIN.JobID)]
    NinjaSuitonFeature = 3009,

    [IconsUncombo([NIN.GokkaMekkyaku, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Goka Mekkyaku (lvl 76+)", "Fell Sting becomes Goka Mekkyaku.", NIN.JobID)]
    NinjaGokaMekkyakuFeature = 3011,

    [IconsUncombo([NIN.HyoshoRanryu, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Hyosho Ranryu (lvl 76+)", "Song of Torment becomes Hyosho Ranryu.", NIN.JobID)]
    NinjaHyoshoRanryuFeature = 3012,

    [IconsUncombo([NIN.KuchiyoseOgama, UTL.ArrowRight, BLU.BLU10, NIN.KuchiyoseGamasen, UTL.ArrowRight, BLU.BLU11])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Kuchiyose Gamasen (lvl 96+)", "Glower and Plaincracker will respectively become Kuchiyose Ogama and Kuchiyose Gamasen.", NIN.JobID)]
    NinjaKuchiyoseGamasenFeature = 3014,

    [IconsUncombo([NIN.Bhavacakra, UTL.ArrowRight, BLU.BLU12, UTL.Blank, NIN.ZeshoMeppo, UTL.ArrowRight, BLU.BLU13])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Zesho Meppo (lvl 96+)", "Bristle and White Wind will respectively become Bhavacakra and Zesho Meppo.", NIN.JobID)]
    NinjaZeshoMeppoFeature = 3015,

    [IconsUncombo([NIN.TenChiJin, UTL.ArrowRight, BLU.BLU14, UTL.Blank, NIN.TenriJido, UTL.ArrowRight, BLU.BLU15])]
    [ParentUncombo(NinjaUncombo)]
    [CustomUncomboInfo("Tenri Jido (lvl 100)", "Petrify lvl 5 and Sharpened Knife become Ten Chi Jin and Tenri Jido.", NIN.JobID)]
    NinjaTenriJidoUncombo = 3016,

    #endregion
    // ====================================================================================
    #region PALADIN

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-9 to your hotbar.", PLD.JobID)]
    PaladinUncombo = 1901,

    [IconsUncombo([PLD.Imperator, UTL.ArrowRight, BLU.BLU1, UTL.Blank, PLD.BladeOfHonor, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(PaladinUncombo)]
    [CustomUncomboInfo("Imperator (lvl 96+)", "Water Cannon and Flame Thrower will respectively become Imperator and Blade of Honor.", PLD.JobID)]
    PaladinImperatorBladesUncombo = 1902,

    [IconsUncombo([PLD.Confiteor, UTL.ArrowRight, BLU.BLU3, UTL.Blank, PLD.BladeOfFaith, UTL.ArrowRight, BLU.BLU4, UTL.Blank, PLD.BladeOfTruth, UTL.ArrowRight, BLU.BLU5, UTL.Blank, PLD.BladeOfValor, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(PaladinUncombo)]
    [CustomUncomboInfo("Blades (lvl 90+)", "Aqua Breath, Flying Frenzy, Drill Cannons and High Voltage will respectively become Confiteor, Blade of Faith, Blade of Truth and Blade of Valor.", PLD.JobID)]
    PaladinBladesUncombo = 1903,

    [IconsUncombo([PLD.Atonement, UTL.ArrowRight, BLU.BLU7, UTL.Blank, PLD.Supplication, UTL.ArrowRight, BLU.BLU8, UTL.Blank, PLD.Sepulchre, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(PaladinUncombo)]
    [CustomUncomboInfo("Atonement (lvl 76+)", "Loom, Fell Sting and Song of Torment will respectively become Atonement, Supplication and Sepulchre.", PLD.JobID)]
    PaladinAtonementUncombo = 1904,

    #endregion
    // ====================================================================================
    #region PICTOMANCER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-15 to your hotbars.", PCT.JobID)]
    PictomancerUncombo = 4201,

    [IconsUncombo([PCT.FireRed, UTL.ArrowRight, BLU.BLU1, UTL.Blank, PCT.AeroGreen, UTL.ArrowRight, BLU.BLU2, UTL.Blank, PCT.WaterBlue, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Fire in Red (lvl 1+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Fire in Red, Aero in Green, and Water in Blue.", PCT.JobID)]
    PictomancerFireUncombo = 4202,

    [IconsUncombo([PCT.BlizzardCyan, UTL.ArrowRight, BLU.BLU4, UTL.Blank, PCT.EarthYellow, UTL.ArrowRight, BLU.BLU5, UTL.Blank, PCT.ThunderMagenta, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Blizzard in Cyan (lvl 60+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Blizzard in Cyan, Stone in Yellow, and Thunder in Magenta.", PCT.JobID)]
    PictomancerBlizzardUncombo = 4203,

    [IconsUncombo([PCT.ExtraFireRed, UTL.ArrowRight, BLU.BLU7, UTL.Blank, PCT.ExtraAeroGreen, UTL.ArrowRight, BLU.BLU8, UTL.Blank, PCT.ExtraWaterBlue, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Fire II in Red (lvl 50+)", "Loom, Final Sting and Song of Torment will respectively become Fire in Red II, Aero in Green II, and Water in Blue II.", PCT.JobID)]
    PictomancerFire2Uncombo = 4204,

    [IconsUncombo([PCT.ExtraBlizzardCyan, UTL.ArrowRight, BLU.BLU10, UTL.Blank, PCT.ExtraEarthYellow, UTL.ArrowRight, BLU.BLU11, UTL.Blank, PCT.ExtraThunderMagenta, UTL.ArrowRight, BLU.BLU12])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Blizzard II in Cyan (lvl 60+)", "Glower, Plain Cracker and Bristle will respectively become Blizzard in Cyan II, Stone in Yellow II, and Thunder in Magenta II.", PCT.JobID)]
    PictomancerBlizzard2Uncombo = 4205,

    [IconsUncombo([PCT.PomMotif, UTL.ArrowRight, BLU.BLU13, UTL.Blank, PCT.PomMuse, UTL.ArrowRight, BLU.BLU14, UTL.Blank, PCT.WingMotif, UTL.ArrowRight, BLU.BLU15, UTL.Blank, PCT.WingedMuse, UTL.ArrowRight, BLU.BLU16])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Early Creature (lvl 30+)", "White Wind, Level 5 Petrify, Sharpened Knife and Ice Spikes will respectively become Pom Motif, Pom Muse, Wing Motif and Winged Muse.", PCT.JobID)]
    PictomancerEarlyCreatureUncombo = 4206,

    [IconsUncombo([PCT.HammerMotif, UTL.ArrowRight, BLU.BLU17, UTL.Blank, PCT.HammerStamp, UTL.ArrowRight, BLU.BLU18, UTL.Blank, PCT.HammerBrush, UTL.ArrowRight, BLU.BLU19, UTL.Blank, PCT.PolishingHammer, UTL.ArrowRight, BLU.BLU20])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Hammer Stamp (lvl 50+)", "Blood Drain, Acorn Bomb, Bomb Toss and Off-guard will respectively become Hammer Motif, Hammer Stamp, and Thunder in Magenta II.", PCT.JobID)]
    PictomancerHammerUncombo = 4207,

    [IconsUncombo([PCT.ClawMotif, UTL.ArrowRight, BLU.BLU21, UTL.Blank, PCT.ClawedMuse, UTL.ArrowRight, BLU.BLU22, UTL.Blank, PCT.MawMotif, UTL.ArrowRight, BLU.BLU23, UTL.Blank, PCT.FangedMuse, UTL.ArrowRight, BLU.BLU24])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Late Creature (lvl 96+)", "Self-destruct, Transfusion, Faze and Flying Sardine will respectively become Claw Motif, Clawed Muse, Maw Motif and Fanged Muse.", PCT.JobID)]
    PictomancerLateCreatureUncombo = 4208,

    [IconsUncombo([PCT.MogOftheAges, UTL.ArrowRight, BLU.BLU25, UTL.Blank, PCT.Retribution, UTL.ArrowRight, BLU.BLU26])]
    [ParentUncombo(PictomancerUncombo)]
    [CustomUncomboInfo("Marthym of the Ages (lvl 30+)", "Snort and 4-tonze Weight will respectively become Mog of the Ages and Retribution of the Madeen.", PCT.JobID)]
    PictomancerMogUncombo = 4209,

    #endregion
    // ====================================================================================
    #region REAPER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-24 to your hotbar.", RPR.JobID)]
    ReaperUncombo = 3901,

    [IconsUncombo([RPR.BloodStalk, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RPR.UnveiledGibbet, UTL.ArrowRight, BLU.BLU2, UTL.Blank, RPR.UnveiledGallows, UTL.ArrowRight, BLU.BLU3 ])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Unveiled Gibbet/Gallows (lvl 70+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Blood Stalk, Unveiled Gibbet and Unveiled Gallows.", RPR.JobID)]
    ReaperUnveiledUncombo = 3902,

    [IconsUncombo([RPR.HellsIngress, UTL.ArrowRight, BLU.BLU4, UTL.Blank, RPR.HellsEgress, UTL.ArrowRight, BLU.BLU5, UTL.Blank, RPR.Regress, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Regress (lvl 74+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Hell's Ingress, Hell's Egress and Regress.", RPR.JobID)]
    ReaperRegressUncombo = 3903,

    [IconsUncombo([RPR.Gibbet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RPR.VoidReaping, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Void Reaping (lvl 80+)", "Loom and Fell Sting will respectively become Gibbet and Void Reaping.", RPR.JobID)]
    ReaperVoidReapingUncombo = 3904,

    [IconsUncombo([RPR.Gallows, UTL.ArrowRight, BLU.BLU9, UTL.Blank, RPR.CrossReaping, UTL.ArrowRight, BLU.BLU10])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Cross Reaping (lvl 80+)", "Song of Torment and Glower will respectively become Gallows and Cross Reaping.", RPR.JobID)]
    ReaperCrossReapingUncombo = 3905,

    [IconsUncombo([RPR.Guillotine, UTL.ArrowRight, BLU.BLU11, UTL.Blank, RPR.GrimReaping, UTL.ArrowRight, BLU.BLU12])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Grim Reaping (lvl 80+)", "Plaincracker and Bristle will respectively become Guillotine and Grim Reaping.", RPR.JobID)]
    ReaperGrimReapingUncombo = 3906,

    [IconsUncombo([RPR.Soulsow, UTL.ArrowRight, BLU.BLU13, UTL.Blank, RPR.HarvestMoon, UTL.ArrowRight, BLU.BLU14])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Harvest Moon (lvl 82+)", "White Wind and Petrify lvl 5 will respectively become Soulsow and Harvest Moon.", RPR.JobID)]
    ReaperHarvestMoonUncombo = 3907,

    [IconsUncombo([RPR.BloodStalk, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RPR.GrimSwathe, UTL.ArrowRight, BLU.BLU15, UTL.Blank, RPR.LemuresSlice, UTL.ArrowRight, BLU.BLU16, UTL.Blank, RPR.LemuresScythe, UTL.ArrowRight, BLU.BLU17])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Lemure (lvl 86+)", "Water Cannon, Sharpened Knife, Ice Spikes, Blood Drain will respectively become Blood Stalk, Grim Swathe, Lemure's Slice and Lemure's Scythe.", RPR.JobID)]
    ReaperLemureUncombo = 3908,

    [IconsUncombo([RPR.Gluttony, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RPR.Sacrificium, UTL.ArrowRight, BLU.BLU19])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Sacrificium (lvl 92+)", "Acorn Bom and Bomb Toss will respectively become Glutonny and Sacrificium.", RPR.JobID)]
    ReaperSacrificiumUncombo = 3909,

    [IconsUncombo([RPR.Gibbet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RPR.ExecutionerGibet, UTL.ArrowRight, BLU.BLU20])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Executioner Gibbet (lvl 96+)", "Loom and Off-Guard will respectively become Gibbet and Executioner's Gibbet.", RPR.JobID)]
    ReaperExecutionerGibbetUncombo = 3910,

    [IconsUncombo([RPR.Gallows, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RPR.ExecutionerGallows, UTL.ArrowRight, BLU.BLU21])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Executioner Gallows (lvl 96+)", "Fell Sting and Self-Destruct will respectively become Gallows and Executioner's Gallows.", RPR.JobID)]
    ReaperExecutionerGallowsUncombo = 3911,

    [IconsUncombo([RPR.Guillotine, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RPR.ExecutionerGuillotine, UTL.ArrowRight, BLU.BLU22])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Executioner Guillotine (lvl 96+)", "Song of Torment and Transfusion will respectively become Guillotine and Executioner's Guillotine.", RPR.JobID)]
    ReaperExecutionerGuillotineUncombo = 3912,

    [IconsUncombo([RPR.Communio, UTL.ArrowRight, BLU.BLU23, UTL.Blank, RPR.Perfectio, UTL.ArrowRight, BLU.BLU24])]
    [ParentUncombo(ReaperUncombo)]
    [CustomUncomboInfo("Perfectio (lvl 100)", "Faze and Flying Sardine will respectively become Communio and Perfectio.", RPR.JobID)]
    ReaperPerfectioUncombo = 3913,

    #endregion
    // ====================================================================================
    #region RED MAGE

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-25 to your hotbar.", RDM.JobID)]
    RedMageUncombo = 3501,

    [IconsUncombo([RDM.Riposte, UTL.ArrowRight, BLU.BLU1, UTL.Blank, RDM.Zwerchhau, UTL.ArrowRight, BLU.BLU2, UTL.Blank, RDM.Redoublement, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Non-Enchanted Melee (lvl 1+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Riposte, Zwerchhau, Redoublement.", RDM.JobID)]
    RedMageNonEnchantedSTFeature = 3502,

    [IconsUncombo([RDM.EnchantedRiposte, UTL.ArrowRight, BLU.BLU4, UTL.Blank, RDM.EnchantedZwerchhau, UTL.ArrowRight, BLU.BLU5, UTL.Blank, RDM.EnchantedRedoublement, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Enchanted Melee (lvl 1+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Enchanted Riposte, Enchanted Zwerchhau and Enchanted Redoublement.", RDM.JobID)]
    RedMageEnchantedSTFeature = 3503,

    [IconsUncombo([RDM.EnchantedMoulinet, UTL.ArrowRight, BLU.BLU7, UTL.Blank, RDM.EnchantedMoulinetDeux, UTL.ArrowRight, BLU.BLU8, UTL.Blank, RDM.EnchantedMoulinetTrois, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Enchanted Moulinet (lvl 52+)", "Loom, Fell Sting, Song of Torment and Glower will respectively become Moulinet, Enchanted Moulinet, Enchanted Moulinet Deux and Enchanted Moulinet Trois.", RDM.JobID)]
    RedMageEnchantedAoEFeature = 3504,

    [IconsUncombo([RDM.Reprise, UTL.ArrowRight, BLU.BLU10, UTL.Blank, RDM.EnchantedReprise, UTL.ArrowRight, BLU.BLU11])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Enchanted Reprise (lvl 76+)", "Plaincracker and Bristle will respectively become Reprise and Enchanted Reprise.", RDM.JobID)]
    RedMageEnchantedRangedFeature = 3505,

    [IconsUncombo([RDM.Verthunder, UTL.ArrowRight, BLU.BLU12, UTL.Blank, RDM.Verthunder2, UTL.ArrowRight, BLU.BLU13, UTL.Blank, RDM.Verflare, UTL.ArrowRight, BLU.BLU14])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("VerFlare (lvl 68+)", "White Wind, Petrify lvl 5 and Sharpened Knife will respectively become Verthunder (3), Verthunder 2, and Verflare.", RDM.JobID)]
    RedMageVerFlareFeature = 3507,

    [IconsUncombo([RDM.Veraero, UTL.ArrowRight, BLU.BLU15, UTL.Blank, RDM.Veraero2, UTL.ArrowRight, BLU.BLU16, UTL.Blank, RDM.Verholy, UTL.ArrowRight, BLU.BLU17])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("VerHoly (lvl 70+)", "Ice Spikes, Blood Drain and Acorn Bomb will respectively become Veraero (3), Veraero 2, and Verholy.", RDM.JobID)]
    RedMageVerHolyFeature = 3508,

    [IconsUncombo([RDM.Jolt, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RDM.Impact, UTL.ArrowRight, BLU.BLU19, UTL.Blank, RDM.Scorch, UTL.ArrowRight, BLU.BLU20])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Scorch (lvl 80+)", "Bomb Toss, Off-Guard and Self-Destruct will respectively become Jolt (3), Impact and Scorch.", RDM.JobID)]
    RedMageScorchFeature = 3509,

    [IconsUncombo([RDM.Resolution, UTL.ArrowRight, BLU.BLU21])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Resolution (lvl 90+)", "Transfusion will become Resolution.", RDM.JobID)]
    RedMageResolutionFeature = 3510,

    [IconsUncombo([RDM.Jolt, UTL.ArrowRight, BLU.BLU18, UTL.Blank, RDM.Impact, UTL.ArrowRight, BLU.BLU22, UTL.Blank, RDM.GrandImpact, UTL.ArrowRight, BLU.BLU23])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Grand Impact (lvl 96+)", "Bomb Toss, Off-Guard and Faze will respectively become Jolt (3), Impact and Grand Impact.", RDM.JobID)]
    RedMageGrandImpactUncombo = 3511,

    [IconsUncombo([RDM.Manafication, UTL.ArrowRight, BLU.BLU24, UTL.Blank, RDM.Prefulgence, UTL.ArrowRight, BLU.BLU25])]
    [ParentUncombo(RedMageUncombo)]
    [CustomUncomboInfo("Prefulgence (lvl 100)", "Flying Sardine and Snort will respectively become Manafication and Prefulgence.", RDM.JobID)]
    RedMagePrefulgenceUncombo = 3512,

    #endregion
    // ====================================================================================
    #region SAGE (empty)

    #endregion
    // ====================================================================================
    #region SAMURAI

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-11 to your hotbar.", SAM.JobID)]
    SamuraiUncombo = 3401,

    [IconsUncombo([SAM.Higanbana, UTL.ArrowRight, BLU.BLU1])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Higanbana (lvl 30+)", "Water Cannon becomes Higanbana.", SAM.JobID)]
    SamuraiHiganbanaFeature = 3403,

    [IconsUncombo([SAM.TenkaGoken, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Tenka Goken (lvl 40+)", "Flame Thrower becomes Tenka Goken.", SAM.JobID)]
    SamuraiGokenFeature = 3404,

    [IconsUncombo([SAM.Midare, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Midare Setsugekka (lvl 50+)", "Aqua Breath becomes Midare Setsugekka.", SAM.JobID)]
    SamuraiMidareFeature = 3405,

    [IconsUncombo([SAM.KaeshiGoken, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Kaeshi: Goken (lvl 76+)", "Flying Frenzy becomes Kaeshi: Goken.", SAM.JobID)]
    SamuraiKaeshiGokenFeature = 3407,

    [IconsUncombo([SAM.KaeshiSetsugekka, UTL.ArrowRight, BLU.BLU5])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Kaeshi: Setsugekka (lvl 76+)", "Drill Cannons becomes Kaeshi: Setsugekka.", SAM.JobID)]
    SamuraiKaeshiSetsugekkaFeature = 3408,

    [IconsUncombo([SAM.OgiNamikiri, UTL.ArrowRight, BLU.BLU6, UTL.Blank, SAM.KaeshiNamikiri, UTL.ArrowRight, BLU.BLU7])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Kaeshi: Namikiri (lvl 90+)", "High Voltage and Loom will respectively become Ogi Namikiri and Kaeshi: Namikiri.", SAM.JobID)]
    SamuraiKaeshiNamikiriFeature = 3409,

    [IconsUncombo([SAM.TendoGoken, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Tendo Goken (lvl 100)", "Fell Sting becomes Tendo Goken.", SAM.JobID)]
    SamuraiTendoGokenFeature = 3411,

    [IconsUncombo([SAM.TendoSetsugekka, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Tendo Setsugekka (lvl 100)", "Song of Torment becomes Tendo Setsugekka.", SAM.JobID)]
    SamuraiTendoMidareFeature = 3412,

    [IconsUncombo([SAM.TendoKaeshiGoken, UTL.ArrowRight, BLU.BLU10])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Tendo Kaeshi Goken (lvl 100)", "Glower bcomes Tendo Kaeshi Goken.", SAM.JobID)]
    SamuraiTendoKaeshiGokenFeature = 3414,

    [IconsUncombo([SAM.TendoKaeshiSetsugekka, UTL.ArrowRight, BLU.BLU11])]
    [ParentUncombo(SamuraiUncombo)]
    [CustomUncomboInfo("Tendo Kaeshi Setsugekka (lvl 100)", "Plaincracker becomes Tendo Kaeshi Setsugekka.", SAM.JobID)]
    SamuraiTendoKaeshiMidareFeature = 3415,

    #endregion
    // ====================================================================================
    #region SCHOLAR (empty)

    #endregion
    // ====================================================================================
    #region SUMMONER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-27 to your hotbar.", SMN.JobID)]
    SummonerUncombo = 2700,

    [IconsUncombo([SMN.RubyRite, UTL.ArrowRight, BLU.BLU1])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Ifrit Gemshine Feature (lvl 6+)", "Water Cannon becomes Ruby Ruin/Ruby Ruin 2/Ruby Ruin 3/Ruby Rite.", SMN.JobID)]
    SummonerGemshineIfritFeature = 2702,

    [IconsUncombo([SMN.TopazRite, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Titan Gemshine Feature (lvl 6+)", "Flame Thrower becomes Topaz Ruin/Topaz Ruin 2/Topaz Ruin 3/Topaz Rite.", SMN.JobID)]
    SummonerGemshineTitanFeature = 2703,

    [IconsUncombo([SMN.EmeraldRite, UTL.ArrowRight, BLU.BLU3])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Garuda Gemshine Feature (lvl 6+)", "Aqua Breath becomes Emerald Ruin/Emerald Ruin 2/Emerald Ruin 3/Emerald Rite.", SMN.JobID)]
    SummonerGemshineGarudaFeature = 2704,

    [IconsUncombo([SMN.RubyCatastrophe, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Ifrit Brillance Feature (lvl 6+)", "Flying Frenzy becomes Ruby Outburst/Ruby Disaster/Ruby Catastrophe.", SMN.JobID)]
    SummonerBrillanceIfritFeature = 2706,

    [IconsUncombo([SMN.TopazCatastrophe, UTL.ArrowRight, BLU.BLU5])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Titan Brillance Feature (lvl 6+)", "Drill Cannons becomes Topaz Outburst/Emerald Disaster/Topaz Catastrophe.", SMN.JobID)]
    SummonerBrillanceTitanFeature = 2707,

    [IconsUncombo([SMN.EmeraldCatastrophe, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Garuda Brillance Feature (lvl 6+)", "High Voltage becomes Emerald Outburst/Emerald Disaster/Emerald Catastrophe.", SMN.JobID)]
    SummonerBrillanceGarudaFeature = 2708,

    [IconsUncombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.AstralImpulse, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Bahamut's Ruin Feature (lvl 70+)", "Loom and Fell Sting will respectively becomes Ruin 1/2/3 and Astral Impulse.", SMN.JobID)]
    SummonerRuinBahamutFeature = 2710,

    [IconsUncombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.FountainOfFire, UTL.ArrowRight, BLU.BLU9])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Phoenix's Ruin Feature (lvl 80+)", "Loom and Song of Torment will respectively becomes Ruin 1/2/3 and Fountain of Fire.", SMN.JobID)]
    SummonerRuinPhoenixFeature = 2711,

    [IconsUncombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.UmbralImpulse, UTL.ArrowRight, BLU.BLU10])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Solar Bahamut Ruin Feature (lvl 100)", "Loom and Glower will respectively becomes Ruin 1/2/3 and Umbral Impulse", SMN.JobID)]
    SummonerRuinSolarBahamutFeature = 2712,

    [IconsUncombo([SMN.Outburst, UTL.ArrowRight, BLU.BLU11, UTL.Blank, SMN.AstralFlare, UTL.ArrowRight, BLU.BLU12])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Bahamut's Tri-Disaster Feature (lvl 70+)", "Plaincracker and Bristle will respectively becomes Outburst/Tri-Disaster and Astral Flare.", SMN.JobID)]
    SummonerTriDisasterBahamutFeature = 2714,

    [IconsUncombo([SMN.Outburst, UTL.ArrowRight, BLU.BLU11, UTL.Blank, SMN.BrandOfPurgatory, UTL.ArrowRight, BLU.BLU13])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Phoenix's Tri-Disaster Feature (lvl 80+)", "Plaincracker and White Wind will respectively becomes Outburst/Tri-Disaster and Brand of Purgatory.", SMN.JobID)]
    SummonerTriDisasterPhoenixFeature = 2715,

    [IconsUncombo([SMN.Ruin, UTL.ArrowRight, BLU.BLU7, UTL.Blank, SMN.UmbralFlare, UTL.ArrowRight, BLU.BLU14])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Solar Bahamut Tri-Disaster Feature (lvl 100)", "Plaincracker and Petrify lvl 5 will respectively becomes Ruin 1/2/3 and Umbral Flare", SMN.JobID)]
    SummonerTriDisasterSolarBahamutFeature = 2716,

    [IconsUncombo([SMN.CrimsonCyclone, UTL.ArrowRight, BLU.BLU15, UTL.Blank, SMN.CrimsonStrike, UTL.ArrowRight, BLU.BLU16])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Ifrit's Crimson Cyclone Feature (lvl 86+)", "Sharpened Knife and Ice Spikes will respectively becomes Crimson Cyclone and Crimson Strike.", SMN.JobID)]
    SummonerIfritFlowFeature = 2718,

    [IconsUncombo([SMN.Slipstream, UTL.ArrowRight, BLU.BLU17])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Garuda's Slipstream Feature (lvl 86+)", "Blood Drain becomes Slipstream.", SMN.JobID)]
    SummonerTitanFlowFeature = 2719,

    [IconsUncombo([SMN.MountainBuster, UTL.ArrowRight, BLU.BLU18])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Titan's Mountain Buster Feature (lvl 86+)", "Acorn Bomb becomes Mountain Buster.", SMN.JobID)]
    SummonerGarudaFlowFeature = 2720,

    [IconsUncombo([SMN.Deathflare, UTL.ArrowRight, BLU.BLU19])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Bahamut's Deathflare Feature (lvl 60+)", "Bomb Toss becomes Deathflare.", SMN.JobID)]
    SummonerBahamutFlowFeature = 2721,

    [IconsUncombo([SMN.Rekindle, UTL.ArrowRight, BLU.BLU20])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Off-Guard becomes Phoenix's Rekindle.", SMN.JobID)]
    SummonerPhoenixFlowFeature = 2722,

    [IconsUncombo([SMN.Sunflare, UTL.ArrowRight, BLU.BLU21])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Solar Bahamut Sunflare Feature (lvl 100)", "Self-destruct becomes Sunflare.", SMN.JobID)]
    SummonerSolarBahamutFlowFeature = 2723,

    [IconsUncombo([SMN.EnkindleBahamut, UTL.ArrowRight, BLU.BLU22])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Bahamut's Ahk Morn Feature (lvl 60+)", "Transfusion becomes Bahamut's Enkindle.", SMN.JobID)]
    SummoneBahamutEnkindleFeature = 2725,

    [IconsUncombo([SMN.EnkindlePhoenix, UTL.ArrowRight, BLU.BLU23])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Daze becomes Phoenix's Enkindle.", SMN.JobID)]
    SummonerPhoenixEnkindleFeature = 2726,

    [IconsUncombo([SMN.EnkindleSolarBahamut, UTL.ArrowRight, BLU.BLU24])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Solar Bahamut's Rekindle Feature (lvl 100)", "Flying Sardine becomes Solar Bahamut's Enkindle.", SMN.JobID)]
    SummonerSolarBahamutEnkindleFeature = 2727,

    [IconsUncombo([SMN.Aethercharge, UTL.ArrowRight, BLU.BLU25])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Summon Bahamut Feature (lvl 6+)", "Snort becomes Aethercharge/Dreadwyrm Trance/Summon Bahamut.", SMN.JobID)]
    SummonerBahamutSummoningFeature = 2729,

    [IconsUncombo([SMN.SummonPhoenix, UTL.ArrowRight, BLU.BLU26])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Summon Phoenix Feature (lvl 80+)", "4-tonze Weight becomes Summon Phoenix.", SMN.JobID)]
    SummonerPhoenixSummoningFeature = 2730,

    [IconsUncombo([SMN.SummonSolarBahamut, UTL.ArrowRight, BLU.BLU27])]
    [ParentUncombo(SummonerUncombo)]
    [CustomUncomboInfo("Summon Solar Bahamut Feature (lvl 100)", "The Look becomes Summon Solar Bahamut.", SMN.JobID)]
    SummonerSolarBahamutSummoningFeature = 2731,

    #endregion
    // ====================================================================================
    #region VIPER

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-32 to your hotbar.", VPR.JobID)]
    ViperUncombo = 4100,

    [IconsUncombo([VPR.SteelFangs, UTL.ArrowRight, BLU.BLU1, UTL.Blank, VPR.HuntersSting, UTL.ArrowRight, BLU.BLU2, UTL.Blank, VPR.FlankstingStrike, UTL.ArrowRight, BLU.BLU3, UTL.Blank, VPR.HindstingStrike, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Steel Fangs (lvl 1+)", "Water Cannon, Flame Thrower, Aqua Breath and Flying Frenzy respectively become Steel Fangs, Hunter's Sting, Flanksting Strike and Hindsting Strike.", VPR.JobID)]
    ViperSteelUncombo = 4101,

    [IconsUncombo([VPR.DreadFangs, UTL.ArrowRight, BLU.BLU5, UTL.Blank, VPR.SwiftskinsSting, UTL.ArrowRight, BLU.BLU6, UTL.Blank, VPR.FlanksbaneFang, UTL.ArrowRight, BLU.BLU7, UTL.Blank, VPR.HindsbaneFang, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Dread Fangs (lvl 10+)", "Drill Cannons, High Voltage, Loom and Final Sting respectively become Dread Fangs, Swiftskin's Sting, Flanksbane Fang and Hindsbane Fang.", VPR.JobID)]
    ViperDreadUncombo = 4102,

    [IconsUncombo([VPR.SteelMaw, UTL.ArrowRight, BLU.BLU9, UTL.Blank, VPR.HuntersBite, UTL.ArrowRight, BLU.BLU10, UTL.Blank, VPR.JaggedMaw, UTL.ArrowRight, BLU.BLU11])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Steel Maw (lvl 25+)", "Song Of Torment, Glower and Plaincracker respectively become Steel Maw, Hunter's Bite and Jagged Maw.", VPR.JobID)]
    ViperSteelMawUncombo = 4103,

    [IconsUncombo([VPR.DreadMaw, UTL.ArrowRight, BLU.BLU12, UTL.Blank, VPR.SwiftskinsBite, UTL.ArrowRight, BLU.BLU13, UTL.Blank, VPR.BloodiedMaw, UTL.ArrowRight, BLU.BLU14])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Dread Maw (lvl 35+)", "Bristle, White Wind and Level 5 Petrify respectively become Dread Maw, Swiftskin's Bite and Bloodied Maw.", VPR.JobID)]
    ViperDreadMawUncombo = 4104,

    [IconsUncombo([VPR.DeathRattle, UTL.ArrowRight, BLU.BLU15, UTL.Blank, VPR.LastLash, UTL.ArrowRight, BLU.BLU16])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Serpent Tail (lvl 55+)", "Sharpened Knife and Ice Spikes respectively become Death Rattle and Last Lash.", VPR.JobID)]
    ViperSerpentTailUncombo = 4105,

    [IconsUncombo([VPR.TwinfangBite, UTL.ArrowRight, BLU.BLU17, UTL.Blank, VPR.TwinfangThresh, UTL.ArrowRight, BLU.BLU18, UTL.Blank, VPR.UncoiledTwinFangs, UTL.ArrowRight, BLU.BLU19])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Twin Fang (lvl 75+)", "Blood Drain, Acorn Bomb and Bomb Toss respectively become Twinfang Bite, Twinfang Thresh and Uncoiled Twin Fangs.", VPR.JobID)]
    ViperTwinFangUncombo = 4106,

    [IconsUncombo([VPR.TwinbloodBite, UTL.ArrowRight, BLU.BLU20, UTL.Blank, VPR.TwinbloodThresh, UTL.ArrowRight, BLU.BLU21, UTL.Blank, VPR.UncoiledTwinBlood, UTL.ArrowRight, BLU.BLU22])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Twin Blood (lvl 75+)", "Off-guard, Self-destruct and Transfusion respectively become Twinblood Bite, Twinblood Thresh and Uncoiled Twin Blood.", VPR.JobID)]
    ViperTwinBloodUncombo = 4107,

    [IconsUncombo([VPR.Reawaken, UTL.ArrowRight, BLU.BLU23, UTL.Blank, VPR.Ouroboros, UTL.ArrowRight, BLU.BLU24])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Reawaken (lvl 90+)", "Faze and Flying Sardine respectively become Reawaken and Ouroboros.", VPR.JobID)]
    ViperReawakenUncombo = 4108,

    [IconsUncombo([VPR.Generation1, UTL.ArrowRight, BLU.BLU25, UTL.Blank, VPR.Generation2, UTL.ArrowRight, BLU.BLU26, UTL.Blank, VPR.Generation3, UTL.ArrowRight, BLU.BLU27, UTL.Blank, VPR.Generation4, UTL.ArrowRight, BLU.BLU28])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Generations (lv90+)", "Snort, 4-tonze Weight, The Look and Bad Breath respectively become First Generation, Second Generation, Third Generation and Fourth Generation.", VPR.JobID)]
    ViperGenerationsUncombo = 4109,

    [IconsUncombo([VPR.Legacy1, UTL.ArrowRight, BLU.BLU29, UTL.Blank, VPR.Legacy2, UTL.ArrowRight, BLU.BLU30, UTL.Blank, VPR.Legacy3, UTL.ArrowRight, BLU.BLU31, UTL.Blank, VPR.Legacy4, UTL.ArrowRight, BLU.BLU32])]
    [ParentUncombo(ViperUncombo)]
    [CustomUncomboInfo("Legacies (lv100+)", "Diamondback, Mighty Guard, Sticky Tongue and Toad Oil respectively become First Legacy, Second Legacy, Third Legacy and Fourth Legacy.", VPR.JobID)]
    ViperLegaciesUncombo = 4110,

    #endregion
    // ====================================================================================
    #region WARRIOR

    [CustomUncomboInfo("Enable", "You will have to manually assign BLU spells 1-8 to your hotbar.", WAR.JobID)]
    WarriorUncombo = 2101,

    [IconsUncombo([WAR.Decimate, UTL.ArrowRight, BLU.BLU1, UTL.Blank, WAR.ChaoticCyclone, UTL.ArrowRight, BLU.BLU2])]
    [ParentUncombo(WarriorUncombo)]
    [CustomUncomboInfo("Chaotic Cyclone (lvl 72+)", "Water Cannon and Flame Thrower will respectively become Decimate and Chaotic Cyclone.", WAR.JobID)]
    WarriorChaoticCycloneUncombo = 2102,

    [IconsUncombo([WAR.FellCleave, UTL.ArrowRight, BLU.BLU3, UTL.Blank, WAR.InnerChaos, UTL.ArrowRight, BLU.BLU4])]
    [ParentUncombo(WarriorUncombo)]
    [CustomUncomboInfo("Inner Chaos (lvl 80+)", "Aqua Breath and Flying Frenzy will respectively become Fell Cleave and Inner Chaos.", WAR.JobID)]
    WarriorInnerChaosUncombo = 2103,

    [IconsUncombo([WAR.InnerRelease, UTL.ArrowRight, BLU.BLU5, UTL.Blank, WAR.PrimalWrath, UTL.ArrowRight, BLU.BLU6])]
    [ParentUncombo(WarriorUncombo)]
    [CustomUncomboInfo("Primal Wrath (lvl 96+)", "Drill Cannons and High Voltage will respectively become Inner Release and Primal Wrath.", WAR.JobID)]
    WarriorPrimalWrathUncombo = 2104,

    [IconsUncombo([WAR.PrimalRend, UTL.ArrowRight, BLU.BLU7, UTL.Blank, WAR.PrimalRuination, UTL.ArrowRight, BLU.BLU8])]
    [ParentUncombo(WarriorUncombo)]
    [CustomUncomboInfo("Primal Ruination (lvl 100)", "Loom and Fell Sting will respectively become Primal Rend and Primal Ruination.", WAR.JobID)]
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
