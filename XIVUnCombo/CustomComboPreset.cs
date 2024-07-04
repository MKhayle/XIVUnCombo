using XIVUncombo.Attributes;
using XIVUncombo.Combos;

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
    #region ADV

    #endregion
    // ====================================================================================
    #region ASTROLOGIAN

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-10 to your hotbar.", AST.JobID)]
    AstrologianUncombo = 3301,

    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("Cards Uncombo (lvl 30+)", "Splits every cards into separate actions.", AST.JobID)]
    AstrologianCardsUncombo = 3302,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Balance feature (lvl 30+)", "Water Cannon becomes the Balance.", AST.JobID)]
    AstrologianBalanceFeature = 3303,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Arrow feature (lvl 30+)", "Flame Thrower becomes the Arrow.", AST.JobID)]
    AstrologianArrowFeature = 3304,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Spire feature (lvl 30+)", "Aqua Breath becomes the Spire.", AST.JobID)]
    AstrologianSpireFeature = 3305,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Spear feature (lvl 30+)", "Flying Frenzy becomes The Spear.", AST.JobID)]
    AstrologianSpearFeature = 3306,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Bole feature (lvl 30+)", "Drill Cannons becomes The Bole.", AST.JobID)]
    AstrologianBoleFeature = 3307,

    [ParentCombo(AstrologianCardsUncombo)]
    [CustomComboInfo("The Ewer feature (lvl 30+)", "High Voltage becomes The Ewer.", AST.JobID)]
    AstrologianEwerFeature = 3308,

    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("Minor Arcanas Uncombo (lvl 70+)", "Splits both minor arcanas into separate actions.", AST.JobID)]
    AstrologianMinorArcanaUncombo = 3309,

    [ParentCombo(AstrologianMinorArcanaUncombo)]
    [CustomComboInfo("The Lord of Crowns feature (lvl 70+)", "Loom becomes The Lord of Crowns.", AST.JobID)]
    AstrologianLordOfCrownsFeature = 3310,

    [ParentCombo(AstrologianMinorArcanaUncombo)]
    [CustomComboInfo("The Lady of Crowns feature (lvl 70+)", "Fell Sting becomes The Lady of Crowns.", AST.JobID)]
    AstrologianLadyOfCrownsFeature = 3311,

    [ParentCombo(AstrologianUncombo)]
    [CustomComboInfo("Astral/Umbral Draw Uncombo (lvl 70+)", "Song of Torment and Glower will respectively become Astral Draw and Umbral Draw.", AST.JobID)]
    AstrologianUmbralDrawUncombo = 3312,

    #endregion
    // ====================================================================================
    #region BLACK MAGE

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-2 to your hotbar.", BLM.JobID)]
    BlackMageUncombo = 2501,

    [ParentCombo(BlackMageUncombo)]
    [CustomComboInfo("Paradox Uncombo (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Fire 1 and Paradox.", BLM.JobID)]
    BlackMageParadoxUncombo = 2502,

    #endregion
    // ====================================================================================
    #region BARD

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-2 to your hotbar.", BRD.JobID)]
    BardUncombo = 2301,

    [ParentCombo(BardUncombo)]
    [CustomComboInfo("Blast Arrow Uncombo (lvl 90+)", "Water Cannon and Flame Thrower will respectively become Apex Arrow and Blast Arrow.", BRD.JobID)]
    BardBlastArrowUncombo = 2302,

    #endregion
    // ====================================================================================
    #region DANCER

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-19 to your hotbar.", DNC.JobID)]
    DancerUncombo = 3801,

    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Step Actions Uncombo (lvl 15+)", "Splits every action and steps into separate actions.", DNC.JobID)]
    DancerDanceStepsUncombo = 3802,

    [ParentCombo(DancerDanceStepsUncombo)]
    [CustomComboInfo("Emboite feature (lvl 15+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Cascade, Windmill, and Emboite.", DNC.JobID)]
    DancerEmboiteFeature = 3803,

    [ParentCombo(DancerDanceStepsUncombo)]
    [CustomComboInfo("Entrechat feature (lvl 15+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Fountain, Bladeshower, and Entrechat.", DNC.JobID)]
    DancerEntrechatFeature = 3804,

    [ParentCombo(DancerDanceStepsUncombo)]
    [CustomComboInfo("Jete feature (lvl 15+)", "Loom, Fell Sting, and Song of Torment will respectively become Reverse Cascade, Rising Windmill, and Jete.", DNC.JobID)]
    DancerJeteFeature = 3805,

    [ParentCombo(DancerDanceStepsUncombo)]
    [CustomComboInfo("Pirouette feature (lvl 15+)", "Glower, Plaincracker and Bristle will respectively become Fountainfall, Bloodshower, and Pirouette.", DNC.JobID)]
    DancerPirouetteFeature = 3806,

    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Standard and Technical Steps Uncombo (lvl 15+)", "Splits every Dance Step and Dance Finish into separate actions.", DNC.JobID)]
    DancerDancesUncombo = 3807,

    [ParentCombo(DancerDancesUncombo)]
    [CustomComboInfo("Standard Dance feature (lvl 15+)", "Bristle and White Wind become Standard Tech and Standard Finish.", DNC.JobID)]
    DancerStandardDanceFeature = 3808,

    [ParentCombo(DancerDancesUncombo)]
    [CustomComboInfo("Technical Dance feature (lvl 70+)", "Petrify lvl 5 and Sharpened Knife become Technical Step and Technical Finish.", DNC.JobID)]
    DancerTechnicalDanceFeature = 3809,

    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Post-Dance Uncombo (lvl 82+)", "Splits every post-dance Finishers into separate actions.", DNC.JobID)]
    DancerFinishMovesUncombo = 3810,

    [ParentCombo(DancerFinishMovesUncombo)]
    [CustomComboInfo("Tillana feature (lvl 82+)", "Sharpened Knife and Ice Spikes become Technical Finish and Tillana.", DNC.JobID)]
    DancerTillanaFeature = 3811,

    [ParentCombo(DancerFinishMovesUncombo)]
    [CustomComboInfo("Finishing Move feature (lvl 96+)", "White Wind and Blood Drain become Standard Finish and Finishing Move.", DNC.JobID)]
    DancerFinishingMoveFeature = 3812,

    [ParentCombo(DancerUncombo)]
    [CustomComboInfo("Dance of the Dawn Uncombo (lvl 100)", "Acorn Bomb and Bomb Toss become Saber Dance and Dance of the Dawn.", DNC.JobID)]
    DancerDawnUncombo = 3813,

    #endregion
    // ====================================================================================
    #region DARK KNIGHT

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-6 to your hotbar.", DRK.JobID)]
    DarkKnightUncombo = 3201,

    [ParentCombo(DarkKnightUncombo)]
    [CustomComboInfo("Delirium Single Target Uncombo (lvl 96+)", "Water Cannon, Flame Thrower, Aqua Breath and Flying Frenzy will respectively become Bloodspiller, Scarlet Delirium, Comeuppance and Torcleaver.", DRK.JobID)]
    DarkKnightDeliriumSTUncombo = 3202,

    [ParentCombo(DarkKnightUncombo)]
    [CustomComboInfo("Delirium AoE Uncombo (lvl 96+)", "Drill Cannons and High Voltage will respectively become Quietus and Impalement.", DRK.JobID)]
    DarkKnightDeliriumAoEUncombo = 3203,
    #endregion
    // ====================================================================================
    #region DRAGOON

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-7 to your hotbar.", DRG.JobID)]
    DragoonUncombo = 2201,

    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Drakesbane Uncombo (lvl 64+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Wheeling Thrust, Fang and Claw and Drakesbane.", DRG.JobID)]
    DragoonDrakesbaneUncombo = 2202,

    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Raiden Thrust Uncombo (lvl 76+)", "Flying Frenzy and Drill Cannons will respectively become True Thrust and Raiden Thrust.", DRG.JobID)]
    DragoonRaidenThrustUncombo = 2203,

    [ParentCombo(DragoonUncombo)]
    [CustomComboInfo("Draconian Fury Uncombo (lvl 82+)", "High Voltage and Loom will respectively become Doom Spike and Draconian Fury.", DRG.JobID)]
    DragoonDraconianFuryUncombo = 2204,

    #endregion
    // ====================================================================================
    #region GUNBREAKER

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-11 to your hotbar.", GNB.JobID)]
    GunbreakerUnCombo = 3701,

    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Gnashing Fang Uncombo (lvl 60+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Gnashing Fang, Savage Claw and Wicked Talon.", GNB.JobID)]
    GunbreakerGnashingUnCombo = 3702,

    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Gnashing Continuation (lvl 70+)", "Flying Frenzy, Drill Cannons and High Voltage will respectively become Jugular Rip, Abdomen Tear, & Eye Gouge.", GNB.JobID)]
    GunbreakerConsecutionUncombo = 3703,

    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Hypervelocity Continuation (lvl 86+)", "Loom will become Hypervelocity.", GNB.JobID)]
    GunbreakerHypervelocityUncombo = 3704,

    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Fated Brand Continuation (lvl 96+)", "Final Sting will become Fated Brand.", GNB.JobID)]
    GunbreakerFatedBrandUncombo = 3705,

    [ParentCombo(GunbreakerUnCombo)]
    [CustomComboInfo("Reign of Beasts Uncombo (lvl 100)", "Song of Torment, Glower and Plain Cracker will respectively become Reign of Beasts, Noble Blood, and Lionheart.", GNB.JobID)]
    GunbreakerReignUncombo = 3706,

    #endregion
    // ====================================================================================
    #region MACHINIST

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-4 to your hotbar.", MCH.JobID)]
    MachinistUncombo = 3101,

    [ParentCombo(MachinistUncombo)]
    [CustomComboInfo("Wildfire Uncombo (lvl 45+)", "Water Cannon and Flame Thrower will respectively become Wildfire and Detonator.", MCH.JobID)]
    MachinistWildfireUncombo = 3102,

    [ParentCombo(MachinistUncombo)]
    [CustomComboInfo("Excavator Uncombo (lvl 60+)", "Aqua Breath and Flying Frenzy will respectively become Chainsaw and Excavator.", MCH.JobID)]
    MachinistExcavatorUncombo = 3103,

    #endregion
    // ====================================================================================
    #region MONK

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-4 to your hotbar.", MNK.JobID)]
    MonkUncombo = 2001,

    [ParentCombo(MonkUncombo)]
    [CustomComboInfo("Blitz Uncombo (lvl 60+)", "Water Cannon, Flame Thrower, Aqua Breath and Flying Frenzy will respectively become Elixir Field/Elixir Burst, Celestial Revolution, Flint Strike/Rising Phoenix and Tornado Kick/Phantom Rush.", MNK.JobID)]
    MonkBlitzUncombo = 2002,

    #endregion
    // ====================================================================================
    #region NINJA

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-15 to your hotbar.", NIN.JobID)]
    NinjaUncombo = 3001,

    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Ninjutsu Uncombo (lvl 30+)", "Splits every Ninjutsu action into separate actions.", NIN.JobID)]
    NinjaNinjutsuUncombo = 3002,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Fuma Shuriken feature (lvl 30+)", "Water Cannon becomes Fuma Shuriken.", NIN.JobID)]
    NinjaFumaShurikenFeature = 3003,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Katon feature (lvl 35+)", "Flame Thrower becomes Katon.", NIN.JobID)]
    NinjaKatonFeature = 3004,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Raiton feature (lvl 35+)", "Aqua Breath becomes Raiton.", NIN.JobID)]
    NinjaRaitonFeature = 3005,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Hyoton feature (lvl 45+)", " becomes Hyoton.", NIN.JobID)]
    NinjaHyotonFeature = 3006,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Huton feature (lvl 45+)", "Drill Cannons becomes Huton.", NIN.JobID)]
    NinjaHutonFeature = 3007,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Doton feature (lvl 45+)", "High Voltage becomes Doton.", NIN.JobID)]
    NinjaDotonFeature = 3008,

    [ParentCombo(NinjaNinjutsuUncombo)]
    [CustomComboInfo("Suiton feature (lvl 45+)", "Loom becomes Suiton.", NIN.JobID)]
    NinjaSuitonFeature = 3009,

    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Kassatsu Uncombo (lvl 76+)", "Splits both Kassatsu Ninjutsu actions into separate actions.", NIN.JobID)]
    NinjaKassatsuUncombo = 3010,

    [ParentCombo(NinjaKassatsuUncombo)]
    [CustomComboInfo("Goka Mekkyaku feature (lvl 76+)", "Fell Sting becomes Goka Mekkyaku.", NIN.JobID)]
    NinjaGokaMekkyakuFeature = 3011,

    [ParentCombo(NinjaKassatsuUncombo)]
    [CustomComboInfo("Hyosho Ranryu feature (lvl 76+)", "Song of Torment becomes Hyosho Ranryu.", NIN.JobID)]
    NinjaHyoshoRanryuFeature = 3012,

    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Higi Ninki Uncombo (lvl 76+)", "Splits both Higi Ninki actions into separate actions.", NIN.JobID)]
    NinjaNinkiHigiUncombo = 3013,

    [ParentCombo(NinjaNinkiHigiUncombo)]
    [CustomComboInfo("Kuchiyose Gamasen feature (lvl 96+)", "Glower and Plaincracker will respectively become Kuchiyose Ogama and Kuchiyose Gamasen.", NIN.JobID)]
    NinjaKuchiyoseGamasenFeature = 3014,

    [ParentCombo(NinjaNinkiHigiUncombo)]
    [CustomComboInfo("Zesho Meppo feature (lvl 96+)", "Bristle and White Wind will respectively become Bhavacakra and Zesho Meppo.", NIN.JobID)]
    NinjaZeshoMeppoFeature = 3015,

    [ParentCombo(NinjaUncombo)]
    [CustomComboInfo("Tenri Jido Uncombo (lvl 100)", "Petrify lvl 5 and Sharpened Knife become Ten Chi Jin and Tenri Jido.", NIN.JobID)]
    NinjaTenriJidoUncombo = 3016,

    #endregion
    // ====================================================================================
    #region PALADIN

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-9 to your hotbar.", PLD.JobID)]
    PaladinUncombo = 1901,

    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Imperator Uncombo (lvl 96+)", "Water Cannon and Flame Thrower will respectively become Imperator and Blade of Honor.", PLD.JobID)]
    PaladinImperatorBladesUncombo = 1902,

    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Blades Uncombo (lvl 90+)", "Aqua Breath, Flying Frenzy, Drill Cannons and High Voltage will respectively become Confiteor, Blade of Faith, Blade of Truth and Blade of Valor.", PLD.JobID)]
    PaladinBladesUncombo = 1903,

    [ParentCombo(PaladinUncombo)]
    [CustomComboInfo("Atonement Uncombo (lvl 76+)", "Loom, Fell Sting and Song of Torment will respectively become Atonement, Supplication and Sepulchre.", PLD.JobID)]
    PaladinAtonementUncombo = 1904,

    #endregion
    // ====================================================================================
    #region PICTOMANCER

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-15 to your hotbars.", PCT.JobID)]
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
    [CustomComboInfo("Hammer Stamp (lvl 50+)", "White Wind,Level 5 Petrify and Sharpened Knife will respectively become Blizzard in Cyan II, Stone in Yellow II, and Thunder in Magenta II.", PCT.JobID)]
    PictomancerHammerUncombo = 4206,

    #endregion
    // ====================================================================================
    #region REAPER

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-2 to your hotbar.", RPR.JobID)]
    ReaperUncombo = 3901,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Unveiled Gibbet/Gallows Uncombo (lvl 70+)", "Water Cannon, Flame Thrower and Aqua Breath will respectively become Blood Stalk, Unveiled Gibbet and Unveiled Gallows.", RPR.JobID)]
    ReaperUnveiledUncombo = 3902,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Regress Uncombo (lvl 74+)", "Flying Frenzy, Drill Cannons, and High Voltage will respectively become Hell's Ingress, Hell's Egress and Regress.", RPR.JobID)]
    ReaperRegressUncombo = 3903,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Void/Cross/Grim Reaping Uncombo (lvl 80+)", "Loom, Fell Sting, Song of Torment, Glower, Plaincracker and Bristle will respectively become Gibbet, Gallows, Guillotine, Void Reaping, Cross Reaping, and Grim Reaping.", RPR.JobID)]
    ReaperReapingUncombo = 3904,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Harvest Moon Uncombo (lvl 82+)", "White Wind and Petrify lvl 5 will respectively become Soulsow and Harvest Moon.", RPR.JobID)]
    ReaperHarvestMoonUncombo = 3905,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Lemure Uncombo (lvl 86+)", "Water Cannon, Sharpened Knife, Ice Spikes, Blood Drain will respectively become Blood Stalk, Grim Swathe, Lemure's Slice and Lemure's Scythe.", RPR.JobID)]
    ReaperLemureUncombo = 3906,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Sacrificium Uncombo (lvl 92+)", "Acorn Bom and Bomb Toss will respectively become Glutonny and Sacrificium.", RPR.JobID)]
    ReaperSacrificiumUncombo = 3907,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Executioner Uncombo (lvl 96+)", "Loom, Fell Sting, Song of Torment, Off-Guard, Self-Destruct and Transfusion will respectively become Gibbet, Gallows, Guillotine, Executioner's Gibbet, Executioner's Gallows and Executioner's Guillotine.", RPR.JobID)]
    ReaperExecutionerUncombo = 3908,

    [ParentCombo(ReaperUncombo)]
    [CustomComboInfo("Perfectio Uncombo (lvl 100)", "Faze and Flying Sardine will respectively become Communio and Perfectio.", RPR.JobID)]
    ReaperPerfectioUncombo = 3909,

    #endregion
    // ====================================================================================
    #region RED MAGE

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-25 to your hotbar.", RDM.JobID)]
    RedMageUncombo = 3501,

    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Enchanted Uncombo (lvl 1+)", "Split the Weaponskills and their Enchanted versions.", RDM.JobID)]
    RedMageEnchantedUncombo = 3502,

    [ParentCombo(RedMageEnchantedUncombo)]
    [CustomComboInfo("Enchanted Melee feature (lvl 1+)", "Water Cannon, Flame Thrower, Aqua Breath, Flying Frenzy, Drill Cannons and High Voltage will respectively become Riposte, Zwerchhau, Redoublement and their Enchanted versions.", RDM.JobID)]
    RedMageEnchantedSTFeature = 3503,

    [ParentCombo(RedMageEnchantedUncombo)]
    [CustomComboInfo("Enchanted Moulinet feature (lvl 52+)", "Loom, Fell Sting, Song of Torment and Glower will respectively become Moulinet, Enchanted Moulinet, Enchanted Moulinet Deux and Enchanted Moulinet Trois.", RDM.JobID)]
    RedMageEnchantedAoEFeature = 3504,

    [ParentCombo(RedMageEnchantedUncombo)]
    [CustomComboInfo("Enchanted Reprise feature (lvl 76+)", "Plaincracker and Bristle will respectively become Reprise and Enchanted Reprise.", RDM.JobID)]
    RedMageEnchantedRangedFeature = 3505,

    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Finishers Uncombo (lvl 68+)", "Splits the Finishers from their bound actions", RDM.JobID)]
    RedMageFinishersUncombo = 3506,

    [ParentCombo(RedMageFinishersUncombo)]
    [CustomComboInfo("VerFlare feature (lvl 68+)", "White Wind, Petrify lvl 5 and Sharpened Knife will respectively become Verthunder (3), Verthunder 2, and Verflare.", RDM.JobID)]
    RedMageVerFlareFeature = 3507,

    [ParentCombo(RedMageFinishersUncombo)]
    [CustomComboInfo("VerHoly feature (lvl 70+)", "Ice Spikes, Blood Drain and Acorn Bomb will respectively become Veraero (3), Veraero 2, and Verholy.", RDM.JobID)]
    RedMageVerHolyFeature = 3508,

    [ParentCombo(RedMageFinishersUncombo)]
    [CustomComboInfo("Scorch feature (lvl 80+)", "Bomb Toss, Off-Guard and Self-Destruct will respectively become Jolt (3), Impact and Scorch.", RDM.JobID)]
    RedMageScorchFeature = 3509,

    [ParentCombo(RedMageFinishersUncombo)]
    [CustomComboInfo("Resolution feature (lvl 90+)", "Transfusion will become Resolution.", RDM.JobID)]
    RedMageResolutionFeature = 3510,

    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Grand Impact Uncombo (lvl 96+)", "Bomb Toss, Off-Guard and Faze will respectively become Jolt (3), Impact and Grand Impact.", RDM.JobID)]
    RedMageGrandImpactUncombo = 3511,

    [ParentCombo(RedMageUncombo)]
    [CustomComboInfo("Prefulgence Uncombo (lvl 100)", "Flying Sardine and Snort will respectively become Manafication and Prefulgence.", RDM.JobID)]
    RedMagePrefulgenceUncombo = 3512,

    #endregion
    // ====================================================================================
    #region SAGE

    #endregion
    // ====================================================================================
    #region SAMURAI

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-11 to your hotbar.", SAM.JobID)]
    SamuraiUncombo = 3401,

    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Iaijutsu Uncombo (lvl 30+)", "Splits every Iaijutsu action into separate actions.", SAM.JobID)]
    SamuraiIaijutsuUncombo = 3402,

    [ParentCombo(SamuraiIaijutsuUncombo)]
    [CustomComboInfo("Higanbana feature (lvl 30+)", "Water Cannon becomes Higanbana.", SAM.JobID)]
    SamuraiHiganbanaFeature = 3403,

    [ParentCombo(SamuraiIaijutsuUncombo)]
    [CustomComboInfo("Tenka Goken feature (lvl 40+)", "Flame Thrower becomes Tenka Goken.", SAM.JobID)]
    SamuraiGokenFeature = 3404,

    [ParentCombo(SamuraiIaijutsuUncombo)]
    [CustomComboInfo("Midare Setsugekka feature (lvl 50+)", "Aqua Breath becomes Midare Setsugekka.", SAM.JobID)]
    SamuraiMidareFeature = 3405,

    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tsubame-gaeshi Uncombo (lvl 76+)", "Splits every Tsubame-gaeshi action into separate actions.", SAM.JobID)]
    SamuraiTsubameGaeshiUncombo = 3406,

    [ParentCombo(SamuraiTsubameGaeshiUncombo)]
    [CustomComboInfo("Kaeshi: Goken feature (lvl 76+)", "Flying Frenzy becomes Kaeshin: Goken.", SAM.JobID)]
    SamuraiKaeshiGokenFeature = 3407,

    [ParentCombo(SamuraiTsubameGaeshiUncombo)]
    [CustomComboInfo("Kaeshi: Setsugekka feature (lvl 76+)", "Drill Cannons becomes Kaeshi: Setsugekka.", SAM.JobID)]
    SamuraiKaeshiSetsugekkaFeature = 3408,

    [ParentCombo(SamuraiTsubameGaeshiUncombo)]
    [CustomComboInfo("Kaeshi: Namikiri (lvl 90+)", "High Voltage and Loom will respectively become Ogi Namikiri and Kaeshi: Namikiri.", SAM.JobID)]
    SamuraiKaeshiNamikiriFeature = 3409,

    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Uncombo (lvl 100)", "Splits every Tendo action into separate actions.", SAM.JobID)]
    SamuraiTendoUncombo = 3410,

    [ParentCombo(SamuraiTendoUncombo)]
    [CustomComboInfo("Tendo Goken feature (lvl 100)", "Fell Sting becomes Tendo Goken.", SAM.JobID)]
    SamuraiTendoGokenFeature = 3411,

    [ParentCombo(SamuraiTendoUncombo)]
    [CustomComboInfo("Tendo Setsugekka feature (lvl 100)", "Song of Torment becomes Tendo Setsugekka.", SAM.JobID)]
    SamuraiTendoMidareFeature = 3412,

    [ParentCombo(SamuraiUncombo)]
    [CustomComboInfo("Tendo Kaeshi Uncombo (lvl 100)", "Splits every Tendo Kaeshi action into separate actions.", SAM.JobID)]
    SamuraiTendoKaeshiUncombo = 3413,

    [ParentCombo(SamuraiTendoKaeshiUncombo)]
    [CustomComboInfo("Tendo Kaeshi Goken feature (lvl 100)", "Glower bcomes Tendo Kaeshi Goken.", SAM.JobID)]
    SamuraiTendoKaeshiGokenFeature = 3414,

    [ParentCombo(SamuraiTendoKaeshiUncombo)]
    [CustomComboInfo("Tendo Kaeshi Setsugekka feature (lvl 100)", "Plaincracker becomes Tendo Kaeshi Setsugekka.", SAM.JobID)]
    SamuraiTendoKaeshiMidareFeature = 3415,

    #endregion
    // ====================================================================================
    #region SCHOLAR

    #endregion
    // ====================================================================================
    #region SUMMONER

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-27 to your hotbar.", SMN.JobID)]
    SummonerUncombo = 2700,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Gemshine Uncombo (lvl 6+)", "Splits every Gemshine action into separate actions.", SMN.JobID)]
    SummonerGemshineUncombo = 2701,

    [ParentCombo(SummonerGemshineUncombo)]
    [CustomComboInfo("Ifrit Gemshine Feature (lvl 6+)", "Water Cannon becomes Ruby Ruin/Ruby Ruin 2/Ruby Ruin 3/Ruby Rite.", SMN.JobID)]
    SummonerGemshineIfritFeature = 2702,

    [ParentCombo(SummonerGemshineUncombo)]
    [CustomComboInfo("Titan Gemshine Feature (lvl 6+)", "Flame Thrower becomes Topaz Ruin/Topaz Ruin 2/Topaz Ruin 3/Topaz Rite.", SMN.JobID)]
    SummonerGemshineTitanFeature = 2703,

    [ParentCombo(SummonerGemshineUncombo)]
    [CustomComboInfo("Garuda Gemshine Feature (lvl 6+)", "Aqua Breath becomes Emerald Ruin/Emerald Ruin 2/Emerald Ruin 3/Emerald Rite.", SMN.JobID)]
    SummonerGemshineGarudaFeature = 2704,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Brillance Uncombo (lvl 26+)", "Splits every Precious Brillance action into separate actions.", SMN.JobID)]
    SummonerBrillanceUncombo = 2705,

    [ParentCombo(SummonerBrillanceUncombo)]
    [CustomComboInfo("Ifrit Brillance Feature (lvl 6+)", "Flying Frenzy becomes Ruby Outburst/Ruby Disaster/Ruby Catastrophe.", SMN.JobID)]
    SummonerBrillanceIfritFeature = 2706,

    [ParentCombo(SummonerBrillanceUncombo)]
    [CustomComboInfo("Titan Brillance Feature (lvl 6+)", "Drill Cannons becomes Topaz Outburst/Emerald Disaster/Topaz Catastrophe.", SMN.JobID)]
    SummonerBrillanceTitanFeature = 2707,

    [ParentCombo(SummonerBrillanceUncombo)]
    [CustomComboInfo("Garuda Brillance Feature (lvl 6+)", "High Voltage becomes Emerald Outburst/Emerald Disaster/Emerald Catastrophe.", SMN.JobID)]
    SummonerBrillanceGarudaFeature = 2708,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summoned Ruin Uncombo (lvl 70+)", "Splits every Summon's Ruin action into separate actions.", SMN.JobID)]
    SummonerRuinUncombo = 2709,

    [ParentCombo(SummonerRuinUncombo)]
    [CustomComboInfo("Bahamut's Ruin Feature (lvl 70+)", "Loom and Fell Sting will respectively becomes Ruin 1/2/3 and Astral Impulse.", SMN.JobID)]
    SummonerRuinBahamutFeature = 2710,

    [ParentCombo(SummonerRuinUncombo)]
    [CustomComboInfo("Phoenix's Ruin Feature (lvl 80+)", "Loom and Song of Torment will respectively becomes Ruin 1/2/3 and Fountain of Fire.", SMN.JobID)]
    SummonerRuinPhoenixFeature = 2711,

    [ParentCombo(SummonerRuinUncombo)]
    [CustomComboInfo("Solar Bahamut Ruin Feature (lvl 100)", "Loom and Glower will respectively becomes Ruin 1/2/3 and Umbral Impulse", SMN.JobID)]
    SummonerRuinSolarBahamutFeature = 2712,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summoned Tri-Disaster Uncombo (lvl 70+)", "Splits every Summon's Tri-Disaster action into separate actions.", SMN.JobID)]
    SummonerTriDisasterUncombo = 2713,

    [ParentCombo(SummonerTriDisasterUncombo)]
    [CustomComboInfo("Bahamut's Tri-Disaster Feature (lvl 70+)", "Plaincracker and Bristle will respectively becomes Outburst/Tri-Disaster and Astral Flare.", SMN.JobID)]
    SummonerTriDisasterBahamutFeature = 2714,

    [ParentCombo(SummonerTriDisasterUncombo)]
    [CustomComboInfo("Phoenix's Tri-Disaster Feature (lvl 80+)", "Plaincracker and White Wind will respectively becomes Outburst/Tri-Disaster and Brand of Purgatory.", SMN.JobID)]
    SummonerTriDisasterPhoenixFeature = 2715,

    [ParentCombo(SummonerTriDisasterUncombo)]
    [CustomComboInfo("Solar Bahamut Tri-Disaster Feature (lvl 100)", "Plaincracker and Petrify lvl 5 will respectively becomes Ruin 1/2/3 and Umbral Flare", SMN.JobID)]
    SummonerTriDisasterSolarBahamutFeature = 2716,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Astral Flow Uncombo (lvl 60+)", "Splits every Summon's Astral Flow action into separate actions.", SMN.JobID)]
    SummonerAstralFlowUncombo = 2717,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Ifrit's Crimson Cyclone Feature (lvl 86+)", "Sharpened Knife and Ice Spikes will respectively becomes Crimson Cyclone and Crimson Strike.", SMN.JobID)]
    SummonerIfritFlowFeature = 2718,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Garuda's Slipstream Feature (lvl 86+)", "Blood Drain becomes Slipstream.", SMN.JobID)]
    SummonerTitanFlowFeature = 2719,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Titan's Mountain Buster Feature (lvl 86+)", "Acorn Bomb becomes Mountain Buster.", SMN.JobID)]
    SummonerGarudaFlowFeature = 2720,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Bahamut's Deathflare Feature (lvl 60+)", "Bomb Toss becomes Deathflare.", SMN.JobID)]
    SummonerBahamutFlowFeature = 2721,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Off-Guard becomes Rekindle.", SMN.JobID)]
    SummonerPhoenixFlowFeature = 2722,

    [ParentCombo(SummonerAstralFlowUncombo)]
    [CustomComboInfo("Solar Bahamut Sunflare Feature (lvl 100)", "Self-destruct becomes Sunflare.", SMN.JobID)]
    SummonerSolarBahamutFlowFeature = 2723,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Enkindle Uncombo (lvl 70+)", "Splits every Summon's Enkindle action into separate actions.", SMN.JobID)]
    SummonerEnkindleUncombo = 2724,

    [ParentCombo(SummonerEnkindleUncombo)]
    [CustomComboInfo("Bahamut's Ahk Morn Feature (lvl 60+)", "Transfusion becomes Bahamut's Rekindle.", SMN.JobID)]
    SummoneBahamutEnkindleFeature = 2725,

    [ParentCombo(SummonerEnkindleUncombo)]
    [CustomComboInfo("Phoenix's Rekindle Feature (lvl 80+)", "Daze becomes Phoenix's Rekindle.", SMN.JobID)]
    SummonerPhoenixEnkindleFeature = 2726,

    [ParentCombo(SummonerEnkindleUncombo)]
    [CustomComboInfo("Solar Bahamut's Rekindle Feature (lvl 100)", "Flying Sardine becomes Solar Bahamut's Rekindle.", SMN.JobID)]
    SummonerSolarBahamutEnkindleFeature = 2727,

    [ParentCombo(SummonerUncombo)]
    [CustomComboInfo("Summoning Uncombo (lvl 70+)", "Splits every Summon's Summoning action into separate actions.", SMN.JobID)]
    SummonerSummoningUncombo = 2728,

    [ParentCombo(SummonerSummoningUncombo)]
    [CustomComboInfo("Summon Bahamut Feature (lvl 6+)", "Snort becomes Aethercharge/Dreadwyrm Trance/Summon Bahamut.", SMN.JobID)]
    SummonerBahamutSummoningFeature = 2729,

    [ParentCombo(SummonerSummoningUncombo)]
    [CustomComboInfo("Summon Phoenix Feature (lvl 80+)", "4-tonze Weight becomes Summon Phoenix.", SMN.JobID)]
    SummonerPhoenixSummoningFeature = 2730,

    [ParentCombo(SummonerSummoningUncombo)]
    [CustomComboInfo("Summon Solar Bahamut Feature (lvl 100)", "The Look becomes Summon Solar Bahamut.", SMN.JobID)]
    SummonerSolarBahamutSummoningFeature = 2731,

    #endregion
    // ====================================================================================
    #region VIPER

    [CustomComboInfo("Enable Uncombo", "All in one. Assign BLU spells from 1 to 40. Yes. 40.", VPR.JobID)]
    ViperUncombo = 4100,

    #endregion
    // ====================================================================================
    #region WARRIOR

    [CustomComboInfo("Enables Uncombo", "You will have to manually assign BLU spells 1-8 to your hotbar.", WAR.JobID)]
    WarriorUncombo = 2101,

    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Chaotic Cyclone (lvl 72+)", "Water Cannon and Flame Thrower will respectively become Decimate and Chaotic Cyclone.", WAR.JobID)]
    WarriorChaoticCycloneUncombo = 2102,

    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Inner Chaos (lvl 80+)", "Aqua Breath and Flying Frenzy will respectively become Fell Cleave and Inner Chaos.", WAR.JobID)]
    WarriorInnerChaosUncombo = 2103,

    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Primal Wrath Uncombo (lvl 96+)", "Drill Cannons and High Voltage will respectively become Inner Release and Primal Wrath.", WAR.JobID)]
    WarriorPrimalWrathUncombo = 2104,

    [ParentCombo(WarriorUncombo)]
    [CustomComboInfo("Primal Ruination Uncombo (lvl 100)", "Loom and Fell Sting will respectively become Primal Rend and Primal Ruination.", WAR.JobID)]
    WarriorPrimalRuinationUncombo = 2105,

    #endregion
    // ====================================================================================
    #region WHITE MAGE

    #endregion
    // ====================================================================================
    #region DOH

    #endregion
    // ====================================================================================
    #region DOL

    #endregion
    // ====================================================================================
}
