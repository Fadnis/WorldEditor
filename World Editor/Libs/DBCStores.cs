using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBCLib;
using DBCLib.Structures335;

namespace World_Editor.DBC
{
    public static partial class DBCStores
    {
        #region Déclarations des DBCs
        public static DBCFile<AchievementEntry> Achievement { get; private set; }
        public static DBCFile<AchievementCategoryEntry> AchievementCategory { get; private set; }
        public static DBCFile<AchievementCriteriaEntry> AchievementCriteria { get; private set; }
        //public static DBCFile<AnimationDataEntry> AnimationData { get; private set; }
        //public static DBCFile<AreaGroupEntry> AreaGroup { get; private set; }
        public static DBCFile<AreaPOIEntry> AreaPOI { get; private set; }
        public static DBCFile<AreaTableEntry> AreaTable { get; private set; }
        //public static DBCFile<AreaTriggerEntry> AreaTrigger { get; private set; }
        //public static DBCFile<AttackAnimKitsEntry> AttackAnimKits { get; private set; }
        //public static DBCFile<AttackAnimTypesEntry> AttackAnimTypes { get; private set; }
        //public static DBCFile<AuctionHouseEntry> AuctionHouse { get; private set; }
        //public static DBCFile<BankBagSlotPricesEntry> BankBagSlotPrices { get; private set; }
        //public static DBCFile<BannedAddOnsEntry> BannedAddOns { get; private set; }
        //public static DBCFile<BarberShopStyleEntry> BarberShopStyle { get; private set; }
        //public static DBCFile<BattlemasterListEntry> BattlemasterList { get; private set; }
        //public static DBCFile<CameraShakesEntry> CameraShakes { get; private set; }
        //public static DBCFile<CfgCategoriesEntry> CfgCategories { get; private set; }
        //public static DBCFile<CfgConfigsEntry> CfgConfigs { get; private set; }
        //public static DBCFile<CharacterFacialHairStylesEntry> CharacterFacialHairStyles { get; private set; }
        //public static DBCFile<CharBaseInfoEntry> CharBaseInfo { get; private set; }
        //public static DBCFile<CharHairGeosetsEntry> CharHairGeosets { get; private set; }
        //public static DBCFile<CharHairTexturesEntry> CharHairTextures { get; private set; }
        //public static DBCFile<CharSectionsEntry> CharSections { get; private set; }
        //public static DBCFile<CharStartOutfitEntry> CharStartOutfit { get; private set; }
        public static DBCFile<CharTitlesEntry> CharTitles { get; private set; }
        //public static DBCFile<CharVariationsEntry> CharVariations { get; private set; }
        //public static DBCFile<ChatChannelsEntry> ChatChannels { get; private set; }
        //public static DBCFile<ChatProfanityEntry> ChatProfanity { get; private set; }
        public static DBCFile<ChrClassesEntry> ChrClasses { get; private set; }
        public static DBCFile<ChrRacesEntry> ChrRaces { get; private set; }
        //public static DBCFile<CinematicCameraEntry> CinematicCamera { get; private set; }
        //public static DBCFile<CinematicSequencesEntry> CinematicSequences { get; private set; }
        //public static DBCFile<CreatureDisplayInfoEntry> CreatureDisplayInfo { get; private set; }
        //public static DBCFile<CreatureDisplayInfoExtraEntry> CreatureDisplayInfoExtra { get; private set; }
        //public static DBCFile<CreatureFamilyEntry> CreatureFamily { get; private set; }
        //public static DBCFile<CreatureModelDataEntry> CreatureModelData { get; private set; }
        //public static DBCFile<CreatureMovementInfoEntry> CreatureMovementInfo { get; private set; }
        //public static DBCFile<CreatureSoundDataEntry> CreatureSoundData { get; private set; }
        //public static DBCFile<CreatureSpellDataEntry> CreatureSpellData { get; private set; }
        //public static DBCFile<CreatureTypeEntry> CreatureType { get; private set; }
        //public static DBCFile<CurrencyCategoryEntry> CurrencyCategory { get; private set; }
        //public static DBCFile<CurrencyTypesEntry> CurrencyTypes { get; private set; }
        //public static DBCFile<DanceMovesEntry> DanceMoves { get; private set; }
        //public static DBCFile<DeathThudLookupsEntry> DeathThudLookups { get; private set; }
        //public static DBCFile<DeclinedWordEntry> DeclinedWord { get; private set; }
        //public static DBCFile<DeclinedWordCasesEntry> DeclinedWordCases { get; private set; }
        //public static DBCFile<DestructibleModelDataEntry> DestructibleModelData { get; private set; }
        //public static DBCFile<DungeonEncounterEntry> DungeonEncounter { get; private set; }
        public static DBCFile<DungeonMapEntry> DungeonMap { get; private set; }
        //public static DBCFile<DungeonMapChunkEntry> DungeonMapChunk { get; private set; }
        //public static DBCFile<DurabilityCostsEntry> DurabilityCosts { get; private set; }
        //public static DBCFile<DurabilityQualityEntry> DurabilityQuality { get; private set; }
        //public static DBCFile<EmotesEntry> Emotes { get; private set; }
        //public static DBCFile<EmotesTextEntry> EmotesText { get; private set; }
        //public static DBCFile<EmotesTextDataEntry> EmotesTextData { get; private set; }
        //public static DBCFile<EmotesTextSoundEntry> EmotesTextSound { get; private set; }
        //public static DBCFile<EnvironmentalDamageEntry> EnvironmentalDamage { get; private set; }
        //public static DBCFile<ExhaustionEntry> Exhaustion { get; private set; }
        public static DBCFile<FactionEntry> Faction { get; private set; }
        public static DBCFile<FactionGroupEntry> FactionGroup { get; private set; }
        public static DBCFile<FactionTemplateEntry> FactionTemplate { get; private set; }
        //public static DBCFile<FileDataEntry> FileData { get; private set; }
        //public static DBCFile<FootprintTexturesEntry> FootprintTextures { get; private set; }
        //public static DBCFile<FootstepTerrainLookupEntry> FootstepTerrainLookup { get; private set; }
        //public static DBCFile<GameObjectArtKitEntry> GameObjectArtKit { get; private set; }
        //public static DBCFile<GameObjectDisplayInfoEntry> GameObjectDisplayInfo { get; private set; }
        //public static DBCFile<GameTablesEntry> GameTables { get; private set; }
        //public static DBCFile<GameTipsEntry> GameTips { get; private set; }
        //public static DBCFile<GemPropertiesEntry> GemProperties { get; private set; }
        //public static DBCFile<GlyphPropertiesEntry> GlyphProperties { get; private set; }
        //public static DBCFile<GlyphSlotEntry> GlyphSlot { get; private set; }
        //public static DBCFile<GMSurveyAnswersEntry> GMSurveyAnswers { get; private set; }
        //public static DBCFile<GMSurveyCurrentSurveyEntry> GMSurveyCurrentSurvey { get; private set; }
        //public static DBCFile<GMSurveyQuestionsEntry> GMSurveyQuestions { get; private set; }
        //public static DBCFile<GMSurveySurveysEntry> GMSurveySurveys { get; private set; }
        //public static DBCFile<GMTicketCategoryEntry> GMTicketCategory { get; private set; }
        //public static DBCFile<GroundEffectDoodadEntry> GroundEffectDoodad { get; private set; }
        //public static DBCFile<GroundEffectTextureEntry> GroundEffectTexture { get; private set; }
        //public static DBCFile<gtBarberShopCostBaseEntry> gtBarberShopCostBase { get; private set; }
        //public static DBCFile<gtChanceToMeleeCritEntry> gtChanceToMeleeCrit { get; private set; }
        //public static DBCFile<gtChanceToMeleeCritBaseEntry> gtChanceToMeleeCritBase { get; private set; }
        //public static DBCFile<gtChanceToSpellCritEntry> gtChanceToSpellCrit { get; private set; }
        //public static DBCFile<gtChanceToSpellCritBaseEntry> gtChanceToSpellCritBase { get; private set; }
        //public static DBCFile<gtCombatRatingsEntry> gtCombatRatings { get; private set; }
        //public static DBCFile<gtNPCManaCostScalerEntry> gtNPCManaCostScaler { get; private set; }
        //public static DBCFile<gtOCTClassCombatRatingScalarEntry> gtOCTClassCombatRatingScalar { get; private set; }
        //public static DBCFile<gtOCTRegenHPEntry> gtOCTRegenHP { get; private set; }
        //public static DBCFile<gtOCTRegenMPEntry> gtOCTRegenMP { get; private set; }
        //public static DBCFile<gtRegenHPPerSptEntry> gtRegenHPPerSpt { get; private set; }
        //public static DBCFile<gtRegenMPPerSptEntry> gtRegenMPPerSpt { get; private set; }
        //public static DBCFile<HelmetGeosetVisDataEntry> HelmetGeosetVisData { get; private set; }
        //public static DBCFile<HolidayDescriptionsEntry> HolidayDescriptions { get; private set; }
        //public static DBCFile<HolidayNamesEntry> HolidayNames { get; private set; }
        //public static DBCFile<HolidaysEntry> Holidays { get; private set; }
        //public static DBCFile<ItemEntry> Item { get; private set; }
        //public static DBCFile<ItemBagFamilyEntry> ItemBagFamily { get; private set; }
        //public static DBCFile<ItemClassEntry> ItemClass { get; private set; }
        //public static DBCFile<ItemCondExtCostsEntry> ItemCondExtCosts { get; private set; }
        //public static DBCFile<ItemDisplayInfoEntry> ItemDisplayInfo { get; private set; }
        //public static DBCFile<ItemExtendedCostEntry> ItemExtendedCost { get; private set; }
        //public static DBCFile<ItemGroupSoundsEntry> ItemGroupSounds { get; private set; }
        //public static DBCFile<ItemLimitCategoryEntry> ItemLimitCategory { get; private set; }
        //public static DBCFile<ItemPetFoodEntry> ItemPetFood { get; private set; }
        //public static DBCFile<ItemPurchaseGroupEntry> ItemPurchaseGroup { get; private set; }
        //public static DBCFile<ItemRandomPropertiesEntry> ItemRandomProperties { get; private set; }
        //public static DBCFile<ItemRandomSuffixEntry> ItemRandomSuffix { get; private set; }
        //public static DBCFile<ItemSetEntry> ItemSet { get; private set; }
        //public static DBCFile<ItemSubClassEntry> ItemSubClass { get; private set; }
        //public static DBCFile<ItemSubClassMaskEntry> ItemSubClassMask { get; private set; }
        //public static DBCFile<ItemVisualEffectsEntry> ItemVisualEffects { get; private set; }
        //public static DBCFile<ItemVisualsEntry> ItemVisuals { get; private set; }
        //public static DBCFile<LanguagesEntry> Languages { get; private set; }
        //public static DBCFile<LanguageWordsEntry> LanguageWords { get; private set; }
        //public static DBCFile<LFGDungeonExpansionEntry> LFGDungeonExpansion { get; private set; }
        //public static DBCFile<LFGDungeonGroupEntry> LFGDungeonGroup { get; private set; }
        //public static DBCFile<LFGDungeonsEntry> LFGDungeons { get; private set; }
        //public static DBCFile<LightEntry> Light { get; private set; }
        //public static DBCFile<LightFloatBandEntry> LightFloatBand { get; private set; }
        //public static DBCFile<LightIntBandEntry> LightIntBand { get; private set; }
        //public static DBCFile<LightParamsEntry> LightParams { get; private set; }
        //public static DBCFile<LightSkyboxEntry> LightSkybox { get; private set; }
        //public static DBCFile<LiquidMaterialEntry> LiquidMaterial { get; private set; }
        //public static DBCFile<LiquidTypeEntry> LiquidType { get; private set; }
        //public static DBCFile<LoadingScreensEntry> LoadingScreens { get; private set; }
        //public static DBCFile<LoadingScreenTaxiSplinesEntry> LoadingScreenTaxiSplines { get; private set; }
        //public static DBCFile<LockEntry> Lock { get; private set; }
        //public static DBCFile<LockTypeEntry> LockType { get; private set; }
        //public static DBCFile<MailTemplateEntry> MailTemplate { get; private set; }
        public static DBCFile<MapEntry> Map { get; private set; }
        //public static DBCFile<MapDifficultyEntry> MapDifficulty { get; private set; }
        //public static DBCFile<MaterialEntry> Material { get; private set; }
        //public static DBCFile<MovieEntry> Movie { get; private set; }
        //public static DBCFile<MovieFileDataEntry> MovieFileData { get; private set; }
        //public static DBCFile<MovieVariationEntry> MovieVariation { get; private set; }
        //public static DBCFile<NameGenEntry> NameGen { get; private set; }
        //public static DBCFile<NamesProfanityEntry> NamesProfanity { get; private set; }
        //public static DBCFile<NamesReservedEntry> NamesReserved { get; private set; }
        //public static DBCFile<NPCSoundsEntry> NPCSounds { get; private set; }
        //public static DBCFile<ObjectEffectEntry> ObjectEffect { get; private set; }
        //public static DBCFile<ObjectEffectGroupEntry> ObjectEffectGroup { get; private set; }
        //public static DBCFile<ObjectEffectModifierEntry> ObjectEffectModifier { get; private set; }
        //public static DBCFile<ObjectEffectPackageEntry> ObjectEffectPackage { get; private set; }
        //public static DBCFile<ObjectEffectPackageElemEntry> ObjectEffectPackageElem { get; private set; }
        //public static DBCFile<OverrideSpellDataEntry> OverrideSpellData { get; private set; }
        //public static DBCFile<PackageEntry> Package { get; private set; }
        //public static DBCFile<PageTextMaterialEntry> PageTextMaterial { get; private set; }
        //public static DBCFile<PaperDollItemFrameEntry> PaperDollItemFrame { get; private set; }
        //public static DBCFile<ParticleColorEntry> ParticleColor { get; private set; }
        //public static DBCFile<PetitionTypeEntry> PetitionType { get; private set; }
        //public static DBCFile<PetPersonalityEntry> PetPersonality { get; private set; }
        //public static DBCFile<PowerDisplayEntry> PowerDisplay { get; private set; }
        //public static DBCFile<PvpDifficultyEntry> PvpDifficulty { get; private set; }
        //public static DBCFile<QuestFactionRewardEntry> QuestFactionReward { get; private set; }
        //public static DBCFile<QuestInfoEntry> QuestInfo { get; private set; }
        //public static DBCFile<QuestSortEntry> QuestSort { get; private set; }
        //public static DBCFile<QuestXPEntry> QuestXP { get; private set; }
        //public static DBCFile<RandPropPointsEntry> RandPropPoints { get; private set; }
        //public static DBCFile<ResistancesEntry> Resistances { get; private set; }
        //public static DBCFile<ScalingStatDistributionEntry> ScalingStatDistribution { get; private set; }
        //public static DBCFile<ScalingStatValuesEntry> ScalingStatValues { get; private set; }
        //public static DBCFile<ScreenEffectEntry> ScreenEffect { get; private set; }
        //public static DBCFile<ServerMessagesEntry> ServerMessages { get; private set; }
        //public static DBCFile<SheatheSoundLookupsEntry> SheatheSoundLookups { get; private set; }
        //public static DBCFile<SkillCostsDataEntry> SkillCostsData { get; private set; }
        public static DBCFile<SkillLineEntry> SkillLine { get; private set; }
        public static DBCFile<SkillLineAbilityEntry> SkillLineAbility { get; private set; }
        //public static DBCFile<SkillLineCategoryEntry> SkillLineCategory { get; private set; }
        public static DBCFile<SkillRaceClassInfoEntry> SkillRaceClassInfo { get; private set; }
        //public static DBCFile<SkillTiersEntry> SkillTiers { get; private set; }
        //public static DBCFile<SoundAmbienceEntry> SoundAmbience { get; private set; }
        //public static DBCFile<SoundEmittersEntry> SoundEmitters { get; private set; }
        //public static DBCFile<SoundEntriesEntry> SoundEntries { get; private set; }
        //public static DBCFile<SoundEntriesAdvancedEntry> SoundEntriesAdvanced { get; private set; }
        //public static DBCFile<SoundFilterEntry> SoundFilter { get; private set; }
        //public static DBCFile<SoundFilterElemEntry> SoundFilterElem { get; private set; }
        //public static DBCFile<SoundProviderPreferencesEntry> SoundProviderPreferences { get; private set; }
        //public static DBCFile<SoundSamplePreferencesEntry> SoundSamplePreferences { get; private set; }
        //public static DBCFile<SoundWaterTypeEntry> SoundWaterType { get; private set; }
        //public static DBCFile<SpamMessagesEntry> SpamMessages { get; private set; }
        public static DBCFile<SpellEntry> Spell { get; private set; }
        //public static DBCFile<SpellCastTimesEntry> SpellCastTimes { get; private set; }
        //public static DBCFile<SpellCategoryEntry> SpellCategory { get; private set; }
        //public static DBCFile<SpellChainEffectsEntry> SpellChainEffects { get; private set; }
        //public static DBCFile<SpellDescriptionVariablesEntry> SpellDescriptionVariables { get; private set; }
        //public static DBCFile<SpellDifficultyEntry> SpellDifficulty { get; private set; }
        //public static DBCFile<SpellDispelTypeEntry> SpellDispelType { get; private set; }
        //public static DBCFile<SpellDurationEntry> SpellDuration { get; private set; }
        //public static DBCFile<SpellEffectCameraShakesEntry> SpellEffectCameraShakes { get; private set; }
        public static DBCFile<SpellFocusObjectEntry> SpellFocusObject { get; private set; }
        public static DBCFile<SpellIconEntry> SpellIcon { get; private set; }
        //public static DBCFile<SpellItemEnchantmentEntry> SpellItemEnchantment { get; private set; }
        //public static DBCFile<SpellItemEnchantmentConditionEntry> SpellItemEnchantmentCondition { get; private set; }
        //public static DBCFile<SpellMechanicEntry> SpellMechanic { get; private set; }
        //public static DBCFile<SpellMissileEntry> SpellMissile { get; private set; }
        //public static DBCFile<SpellMissileMotionEntry> SpellMissileMotion { get; private set; }
        //public static DBCFile<SpellRadiusEntry> SpellRadius { get; private set; }
        //public static DBCFile<SpellRangeEntry> SpellRange { get; private set; }
        //public static DBCFile<SpellRuneCostEntry> SpellRuneCost { get; private set; }
        //public static DBCFile<SpellShapeshiftFormEntry> SpellShapeshiftForm { get; private set; }
        //public static DBCFile<SpellVisualEntry> SpellVisual { get; private set; }
        //public static DBCFile<SpellVisualEffectNameEntry> SpellVisualEffectName { get; private set; }
        //public static DBCFile<SpellVisualKitEntry> SpellVisualKit { get; private set; }
        //public static DBCFile<SpellVisualKitAreaModelEntry> SpellVisualKitAreaModel { get; private set; }
        //public static DBCFile<SpellVisualKitModelAttachEntry> SpellVisualKitModelAttach { get; private set; }
        //public static DBCFile<SpellVisualPrecastTransitionsEntry> SpellVisualPrecastTransitions { get; private set; }
        //public static DBCFile<StableSlotPricesEntry> StableSlotPrices { get; private set; }
        //public static DBCFile<StartupStringsEntry> StartupStrings { get; private set; }
        //public static DBCFile<StationeryEntry> Stationery { get; private set; }
        //public static DBCFile<StringLookupsEntry> StringLookups { get; private set; }
        //public static DBCFile<SummonPropertiesEntry> SummonProperties { get; private set; }
        public static DBCFile<TalentEntry> Talent { get; private set; }
        public static DBCFile<TalentTabEntry> TalentTab { get; private set; }
        //public static DBCFile<TaxiNodesEntry> TaxiNodes { get; private set; }
        //public static DBCFile<TaxiPathEntry> TaxiPath { get; private set; }
        //public static DBCFile<TaxiPathNodeEntry> TaxiPathNode { get; private set; }
        //public static DBCFile<TeamContributionPointsEntry> TeamContributionPoints { get; private set; }
        //public static DBCFile<TerrainTypeEntry> TerrainType { get; private set; }
        //public static DBCFile<TerrainTypeSoundsEntry> TerrainTypeSounds { get; private set; }
        //public static DBCFile<TotemCategoryEntry> TotemCategory { get; private set; }
        //public static DBCFile<TransportAnimationEntry> TransportAnimation { get; private set; }
        //public static DBCFile<TransportPhysicsEntry> TransportPhysics { get; private set; }
        //public static DBCFile<TransportRotationEntry> TransportRotation { get; private set; }
        //public static DBCFile<UISoundLookupsEntry> UISoundLookups { get; private set; }
        //public static DBCFile<UnitBloodEntry> UnitBlood { get; private set; }
        //public static DBCFile<UnitBloodLevelsEntry> UnitBloodLevels { get; private set; }
        //public static DBCFile<VehicleEntry> Vehicle { get; private set; }
        //public static DBCFile<VehicleSeatEntry> VehicleSeat { get; private set; }
        //public static DBCFile<VehicleUIIndicatorEntry> VehicleUIIndicator { get; private set; }
        //public static DBCFile<VehicleUIIndSeatEntry> VehicleUIIndSeat { get; private set; }
        //public static DBCFile<VideoHardwareEntry> VideoHardware { get; private set; }
        //public static DBCFile<VocalUISoundsEntry> VocalUISounds { get; private set; }
        //public static DBCFile<WeaponImpactSoundsEntry> WeaponImpactSounds { get; private set; }
        //public static DBCFile<WeaponSwingSounds2Entry> WeaponSwingSounds2 { get; private set; }
        //public static DBCFile<WeatherEntry> Weather { get; private set; }
        //public static DBCFile<WMOAreaTableEntry> WMOAreaTable { get; private set; }
        //public static DBCFile<WorldChunkSoundsEntry> WorldChunkSounds { get; private set; }
        public static DBCFile<WorldMapAreaEntry> WorldMapArea { get; private set; }
        //public static DBCFile<WorldMapContinentEntry> WorldMapContinent { get; private set; }
        public static DBCFile<WorldMapOverlayEntry> WorldMapOverlay { get; private set; }
        //public static DBCFile<WorldMapTransformsEntry> WorldMapTransforms { get; private set; }
        //public static DBCFile<WorldSafeLocsEntry> WorldSafeLocs { get; private set; }
        //public static DBCFile<WorldStateUIEntry> WorldStateUI { get; private set; }
        //public static DBCFile<WorldStateZoneSoundsEntry> WorldStateZoneSounds { get; private set; }
        //public static DBCFile<WowErrorStringsEntry> WowErrorStrings { get; private set; }
        //public static DBCFile<ZoneIntroMusicTableEntry> ZoneIntroMusicTable { get; private set; }
        //public static DBCFile<ZoneMusicEntry> ZoneMusic { get; private set; }
        #endregion

        public static void InitFiles()
        {
            string DbcFolder = ProjectManager.ProjectDirectory + "\\dbc\\";

            #region Initialisation des DBCs
            Achievement = new DBCFile<AchievementEntry>(DbcFolder + "Achievement.dbc");
            AchievementCategory = new DBCFile<AchievementCategoryEntry>(DbcFolder + "Achievement_Category.dbc");
            AchievementCriteria = new DBCFile<AchievementCriteriaEntry>(DbcFolder + "Achievement_Criteria.dbc");
            //AnimationData = new DBCFile<AnimationDataEntry>(DbcFolder + "AnimationData.dbc");
            //AreaGroup = new DBCFile<AreaGroupEntry>(DbcFolder + "AreaGroup.dbc");
            AreaPOI = new DBCFile<AreaPOIEntry>(DbcFolder + "AreaPOI.dbc");
            AreaTable = new DBCFile<AreaTableEntry>(DbcFolder + "AreaTable.dbc");
            //AreaTrigger = new DBCFile<AreaTriggerEntry>(DbcFolder + "AreaTrigger.dbc");
            //AttackAnimKits = new DBCFile<AttackAnimKitsEntry>(DbcFolder + "AttackAnimKits.dbc");
            //AttackAnimTypes = new DBCFile<AttackAnimTypesEntry>(DbcFolder + "AttackAnimTypes.dbc");
            //AuctionHouse = new DBCFile<AuctionHouseEntry>(DbcFolder + "AuctionHouse.dbc");
            //BankBagSlotPrices = new DBCFile<BankBagSlotPricesEntry>(DbcFolder + "BankBagSlotPrices.dbc");
            //BannedAddOns = new DBCFile<BannedAddOnsEntry>(DbcFolder + "BannedAddOns.dbc");
            //BarberShopStyle = new DBCFile<BarberShopStyleEntry>(DbcFolder + "BarberShopStyle.dbc");
            //BattlemasterList = new DBCFile<BattlemasterListEntry>(DbcFolder + "BattlemasterList.dbc");
            //CameraShakes = new DBCFile<CameraShakesEntry>(DbcFolder + "CameraShakes.dbc");
            //CfgCategories = new DBCFile<CfgCategoriesEntry>(DbcFolder + "Cfg_Categories.dbc");
            //CfgConfigs = new DBCFile<CfgConfigsEntry>(DbcFolder + "Cfg_Configs.dbc");
            //CharacterFacialHairStyles = new DBCFile<CharacterFacialHairStylesEntry>(DbcFolder + "CharacterFacialHairStyles.dbc");
            //CharBaseInfo = new DBCFile<CharBaseInfoEntry>(DbcFolder + "CharBaseInfo.dbc");
            //CharHairGeosets = new DBCFile<CharHairGeosetsEntry>(DbcFolder + "CharHairGeosets.dbc");
            //CharHairTextures = new DBCFile<CharHairTexturesEntry>(DbcFolder + "CharHairTextures.dbc");
            //CharSections = new DBCFile<CharSectionsEntry>(DbcFolder + "CharSections.dbc");
            //CharStartOutfit = new DBCFile<CharStartOutfitEntry>(DbcFolder + "CharStartOutfit.dbc");
            CharTitles = new DBCFile<CharTitlesEntry>(DbcFolder + "CharTitles.dbc");
            //CharVariations = new DBCFile<CharVariationsEntry>(DbcFolder + "CharVariations.dbc");
            //ChatChannels = new DBCFile<ChatChannelsEntry>(DbcFolder + "ChatChannels.dbc");
            //ChatProfanity = new DBCFile<ChatProfanityEntry>(DbcFolder + "ChatProfanity.dbc");
            ChrClasses = new DBCFile<ChrClassesEntry>(DbcFolder + "ChrClasses.dbc");
            ChrRaces = new DBCFile<ChrRacesEntry>(DbcFolder + "ChrRaces.dbc");
            //CinematicCamera = new DBCFile<CinematicCameraEntry>(DbcFolder + "CinematicCamera.dbc");
            //CinematicSequences = new DBCFile<CinematicSequencesEntry>(DbcFolder + "CinematicSequences.dbc");
            //CreatureDisplayInfo = new DBCFile<CreatureDisplayInfoEntry>(DbcFolder + "CreatureDisplayInfo.dbc");
            //CreatureDisplayInfoExtra = new DBCFile<CreatureDisplayInfoExtraEntry>(DbcFolder + "CreatureDisplayInfoExtra.dbc");
            //CreatureFamily = new DBCFile<CreatureFamilyEntry>(DbcFolder + "CreatureFamily.dbc");
            //CreatureModelData = new DBCFile<CreatureModelDataEntry>(DbcFolder + "CreatureModelData.dbc");
            //CreatureMovementInfo = new DBCFile<CreatureMovementInfoEntry>(DbcFolder + "CreatureMovementInfo.dbc");
            //CreatureSoundData = new DBCFile<CreatureSoundDataEntry>(DbcFolder + "CreatureSoundData.dbc");
            //CreatureSpellData = new DBCFile<CreatureSpellDataEntry>(DbcFolder + "CreatureSpellData.dbc");
            //CreatureType = new DBCFile<CreatureTypeEntry>(DbcFolder + "CreatureType.dbc");
            //CurrencyCategory = new DBCFile<CurrencyCategoryEntry>(DbcFolder + "CurrencyCategory.dbc");
            //CurrencyTypes = new DBCFile<CurrencyTypesEntry>(DbcFolder + "CurrencyTypes.dbc");
            //DanceMoves = new DBCFile<DanceMovesEntry>(DbcFolder + "DanceMoves.dbc");
            //DeathThudLookups = new DBCFile<DeathThudLookupsEntry>(DbcFolder + "DeathThudLookups.dbc");
            //DeclinedWord = new DBCFile<DeclinedWordEntry>(DbcFolder + "DeclinedWord.dbc");
            //DeclinedWordCases = new DBCFile<DeclinedWordCasesEntry>(DbcFolder + "DeclinedWordCases.dbc");
            //DestructibleModelData = new DBCFile<DestructibleModelDataEntry>(DbcFolder + "DestructibleModelData.dbc");
            //DungeonEncounter = new DBCFile<DungeonEncounterEntry>(DbcFolder + "DungeonEncounter.dbc");
            DungeonMap = new DBCFile<DungeonMapEntry>(DbcFolder + "DungeonMap.dbc");
            //DungeonMapChunk = new DBCFile<DungeonMapChunkEntry>(DbcFolder + "DungeonMapChunk.dbc");
            //DurabilityCosts = new DBCFile<DurabilityCostsEntry>(DbcFolder + "DurabilityCosts.dbc");
            //DurabilityQuality = new DBCFile<DurabilityQualityEntry>(DbcFolder + "DurabilityQuality.dbc");
            //Emotes = new DBCFile<EmotesEntry>(DbcFolder + "Emotes.dbc");
            //EmotesText = new DBCFile<EmotesTextEntry>(DbcFolder + "EmotesText.dbc");
            //EmotesTextData = new DBCFile<EmotesTextDataEntry>(DbcFolder + "EmotesTextData.dbc");
            //EmotesTextSound = new DBCFile<EmotesTextSoundEntry>(DbcFolder + "EmotesTextSound.dbc");
            //EnvironmentalDamage = new DBCFile<EnvironmentalDamageEntry>(DbcFolder + "EnvironmentalDamage.dbc");
            //Exhaustion = new DBCFile<ExhaustionEntry>(DbcFolder + "Exhaustion.dbc");
            Faction = new DBCFile<FactionEntry>(DbcFolder + "Faction.dbc");
            FactionGroup = new DBCFile<FactionGroupEntry>(DbcFolder + "FactionGroup.dbc");
            FactionTemplate = new DBCFile<FactionTemplateEntry>(DbcFolder + "FactionTemplate.dbc");
            //FileData = new DBCFile<FileDataEntry>(DbcFolder + "FileData.dbc");
            //FootprintTextures = new DBCFile<FootprintTexturesEntry>(DbcFolder + "FootprintTextures.dbc");
            //FootstepTerrainLookup = new DBCFile<FootstepTerrainLookupEntry>(DbcFolder + "FootstepTerrainLookup.dbc");
            //GameObjectArtKit = new DBCFile<GameObjectArtKitEntry>(DbcFolder + "GameObjectArtKit.dbc");
            //GameObjectDisplayInfo = new DBCFile<GameObjectDisplayInfoEntry>(DbcFolder + "GameObjectDisplayInfo.dbc");
            //GameTables = new DBCFile<GameTablesEntry>(DbcFolder + "GameTables.dbc");
            //GameTips = new DBCFile<GameTipsEntry>(DbcFolder + "GameTips.dbc");
            //GemProperties = new DBCFile<GemPropertiesEntry>(DbcFolder + "GemProperties.dbc");
            //GlyphProperties = new DBCFile<GlyphPropertiesEntry>(DbcFolder + "GlyphProperties.dbc");
            //GlyphSlot = new DBCFile<GlyphSlotEntry>(DbcFolder + "GlyphSlot.dbc");
            //GMSurveyAnswers = new DBCFile<GMSurveyAnswersEntry>(DbcFolder + "GMSurveyAnswers.dbc");
            //GMSurveyCurrentSurvey = new DBCFile<GMSurveyCurrentSurveyEntry>(DbcFolder + "GMSurveyCurrentSurvey.dbc");
            //GMSurveyQuestions = new DBCFile<GMSurveyQuestionsEntry>(DbcFolder + "GMSurveyQuestions.dbc");
            //GMSurveySurveys = new DBCFile<GMSurveySurveysEntry>(DbcFolder + "GMSurveySurveys.dbc");
            //GMTicketCategory = new DBCFile<GMTicketCategoryEntry>(DbcFolder + "GMTicketCategory.dbc");
            //GroundEffectDoodad = new DBCFile<GroundEffectDoodadEntry>(DbcFolder + "GroundEffectDoodad.dbc");
            //GroundEffectTexture = new DBCFile<GroundEffectTextureEntry>(DbcFolder + "GroundEffectTexture.dbc");
            //gtBarberShopCostBase = new DBCFile<gtBarberShopCostBaseEntry>(DbcFolder + "gtBarberShopCostBase.dbc");
            //gtChanceToMeleeCrit = new DBCFile<gtChanceToMeleeCritEntry>(DbcFolder + "gtChanceToMeleeCrit.dbc");
            //gtChanceToMeleeCritBase = new DBCFile<gtChanceToMeleeCritBaseEntry>(DbcFolder + "gtChanceToMeleeCritBase.dbc");
            //gtChanceToSpellCrit = new DBCFile<gtChanceToSpellCritEntry>(DbcFolder + "gtChanceToSpellCrit.dbc");
            //gtChanceToSpellCritBase = new DBCFile<gtChanceToSpellCritBaseEntry>(DbcFolder + "gtChanceToSpellCritBase.dbc");
            //gtCombatRatings = new DBCFile<gtCombatRatingsEntry>(DbcFolder + "gtCombatRatings.dbc");
            //gtNPCManaCostScaler = new DBCFile<gtNPCManaCostScalerEntry>(DbcFolder + "gtNPCManaCostScaler.dbc");
            //gtOCTClassCombatRatingScalar = new DBCFile<gtOCTClassCombatRatingScalarEntry>(DbcFolder + "gtOCTClassCombatRatingScalar.dbc");
            //gtOCTRegenHP = new DBCFile<gtOCTRegenHPEntry>(DbcFolder + "gtOCTRegenHP.dbc");
            //gtOCTRegenMP = new DBCFile<gtOCTRegenMPEntry>(DbcFolder + "gtOCTRegenMP.dbc");
            //gtRegenHPPerSpt = new DBCFile<gtRegenHPPerSptEntry>(DbcFolder + "gtRegenHPPerSpt.dbc");
            //gtRegenMPPerSpt = new DBCFile<gtRegenMPPerSptEntry>(DbcFolder + "gtRegenMPPerSpt.dbc");
            //HelmetGeosetVisData = new DBCFile<HelmetGeosetVisDataEntry>(DbcFolder + "HelmetGeosetVisData.dbc");
            //HolidayDescriptions = new DBCFile<HolidayDescriptionsEntry>(DbcFolder + "HolidayDescriptions.dbc");
            //HolidayNames = new DBCFile<HolidayNamesEntry>(DbcFolder + "HolidayNames.dbc");
            //Holidays = new DBCFile<HolidaysEntry>(DbcFolder + "Holidays.dbc");
            //Item = new DBCFile<ItemEntry>(DbcFolder + "Item.dbc");
            //ItemBagFamily = new DBCFile<ItemBagFamilyEntry>(DbcFolder + "ItemBagFamily.dbc");
            //ItemClass = new DBCFile<ItemClassEntry>(DbcFolder + "ItemClass.dbc");
            //ItemCondExtCosts = new DBCFile<ItemCondExtCostsEntry>(DbcFolder + "ItemCondExtCosts.dbc");
            //ItemDisplayInfo = new DBCFile<ItemDisplayInfoEntry>(DbcFolder + "ItemDisplayInfo.dbc");
            //ItemExtendedCost = new DBCFile<ItemExtendedCostEntry>(DbcFolder + "ItemExtendedCost.dbc");
            //ItemGroupSounds = new DBCFile<ItemGroupSoundsEntry>(DbcFolder + "ItemGroupSounds.dbc");
            //ItemLimitCategory = new DBCFile<ItemLimitCategoryEntry>(DbcFolder + "ItemLimitCategory.dbc");
            //ItemPetFood = new DBCFile<ItemPetFoodEntry>(DbcFolder + "ItemPetFood.dbc");
            //ItemPurchaseGroup = new DBCFile<ItemPurchaseGroupEntry>(DbcFolder + "ItemPurchaseGroup.dbc");
            //ItemRandomProperties = new DBCFile<ItemRandomPropertiesEntry>(DbcFolder + "ItemRandomProperties.dbc");
            //ItemRandomSuffix = new DBCFile<ItemRandomSuffixEntry>(DbcFolder + "ItemRandomSuffix.dbc");
            //ItemSet = new DBCFile<ItemSetEntry>(DbcFolder + "ItemSet.dbc");
            //ItemSubClass = new DBCFile<ItemSubClassEntry>(DbcFolder + "ItemSubClass.dbc");
            //ItemSubClassMask = new DBCFile<ItemSubClassMaskEntry>(DbcFolder + "ItemSubClassMask.dbc");
            //ItemVisualEffects = new DBCFile<ItemVisualEffectsEntry>(DbcFolder + "ItemVisualEffects.dbc");
            //ItemVisuals = new DBCFile<ItemVisualsEntry>(DbcFolder + "ItemVisuals.dbc");
            //Languages = new DBCFile<LanguagesEntry>(DbcFolder + "Languages.dbc");
            //LanguageWords = new DBCFile<LanguageWordsEntry>(DbcFolder + "LanguageWords.dbc");
            //LFGDungeonExpansion = new DBCFile<LFGDungeonExpansionEntry>(DbcFolder + "LFGDungeonExpansion.dbc");
            //LFGDungeonGroup = new DBCFile<LFGDungeonGroupEntry>(DbcFolder + "LFGDungeonGroup.dbc");
            //LFGDungeons = new DBCFile<LFGDungeonsEntry>(DbcFolder + "LFGDungeons.dbc");
            //Light = new DBCFile<LightEntry>(DbcFolder + "Light.dbc");
            //LightFloatBand = new DBCFile<LightFloatBandEntry>(DbcFolder + "LightFloatBand.dbc");
            //LightIntBand = new DBCFile<LightIntBandEntry>(DbcFolder + "LightIntBand.dbc");
            //LightParams = new DBCFile<LightParamsEntry>(DbcFolder + "LightParams.dbc");
            //LightSkybox = new DBCFile<LightSkyboxEntry>(DbcFolder + "LightSkybox.dbc");
            //LiquidMaterial = new DBCFile<LiquidMaterialEntry>(DbcFolder + "LiquidMaterial.dbc");
            //LiquidType = new DBCFile<LiquidTypeEntry>(DbcFolder + "LiquidType.dbc");
            //LoadingScreens = new DBCFile<LoadingScreensEntry>(DbcFolder + "LoadingScreens.dbc");
            //LoadingScreenTaxiSplines = new DBCFile<LoadingScreenTaxiSplinesEntry>(DbcFolder + "LoadingScreenTaxiSplines.dbc");
            //Lock = new DBCFile<LockEntry>(DbcFolder + "Lock.dbc");
            //LockType = new DBCFile<LockTypeEntry>(DbcFolder + "LockType.dbc");
            //MailTemplate = new DBCFile<MailTemplateEntry>(DbcFolder + "MailTemplate.dbc");
            Map = new DBCFile<MapEntry>(DbcFolder + "Map.dbc");
            //MapDifficulty = new DBCFile<MapDifficultyEntry>(DbcFolder + "MapDifficulty.dbc");
            //Material = new DBCFile<MaterialEntry>(DbcFolder + "Material.dbc");
            //Movie = new DBCFile<MovieEntry>(DbcFolder + "Movie.dbc");
            //MovieFileData = new DBCFile<MovieFileDataEntry>(DbcFolder + "MovieFileData.dbc");
            //MovieVariation = new DBCFile<MovieVariationEntry>(DbcFolder + "MovieVariation.dbc");
            //NameGen = new DBCFile<NameGenEntry>(DbcFolder + "NameGen.dbc");
            //NamesProfanity = new DBCFile<NamesProfanityEntry>(DbcFolder + "NamesProfanity.dbc");
            //NamesReserved = new DBCFile<NamesReservedEntry>(DbcFolder + "NamesReserved.dbc");
            //NPCSounds = new DBCFile<NPCSoundsEntry>(DbcFolder + "NPCSounds.dbc");
            //ObjectEffect = new DBCFile<ObjectEffectEntry>(DbcFolder + "ObjectEffect.dbc");
            //ObjectEffectGroup = new DBCFile<ObjectEffectGroupEntry>(DbcFolder + "ObjectEffectGroup.dbc");
            //ObjectEffectModifier = new DBCFile<ObjectEffectModifierEntry>(DbcFolder + "ObjectEffectModifier.dbc");
            //ObjectEffectPackage = new DBCFile<ObjectEffectPackageEntry>(DbcFolder + "ObjectEffectPackage.dbc");
            //ObjectEffectPackageElem = new DBCFile<ObjectEffectPackageElemEntry>(DbcFolder + "ObjectEffectPackageElem.dbc");
            //OverrideSpellData = new DBCFile<OverrideSpellDataEntry>(DbcFolder + "OverrideSpellData.dbc");
            //Package = new DBCFile<PackageEntry>(DbcFolder + "Package.dbc");
            //PageTextMaterial = new DBCFile<PageTextMaterialEntry>(DbcFolder + "PageTextMaterial.dbc");
            //PaperDollItemFrame = new DBCFile<PaperDollItemFrameEntry>(DbcFolder + "PaperDollItemFrame.dbc");
            //ParticleColor = new DBCFile<ParticleColorEntry>(DbcFolder + "ParticleColor.dbc");
            //PetitionType = new DBCFile<PetitionTypeEntry>(DbcFolder + "PetitionType.dbc");
            //PetPersonality = new DBCFile<PetPersonalityEntry>(DbcFolder + "PetPersonality.dbc");
            //PowerDisplay = new DBCFile<PowerDisplayEntry>(DbcFolder + "PowerDisplay.dbc");
            //PvpDifficulty = new DBCFile<PvpDifficultyEntry>(DbcFolder + "PvpDifficulty.dbc");
            //QuestFactionReward = new DBCFile<QuestFactionRewardEntry>(DbcFolder + "QuestFactionReward.dbc");
            //QuestInfo = new DBCFile<QuestInfoEntry>(DbcFolder + "QuestInfo.dbc");
            //QuestSort = new DBCFile<QuestSortEntry>(DbcFolder + "QuestSort.dbc");
            //QuestXP = new DBCFile<QuestXPEntry>(DbcFolder + "QuestXP.dbc");
            //RandPropPoints = new DBCFile<RandPropPointsEntry>(DbcFolder + "RandPropPoints.dbc");
            //Resistances = new DBCFile<ResistancesEntry>(DbcFolder + "Resistances.dbc");
            //ScalingStatDistribution = new DBCFile<ScalingStatDistributionEntry>(DbcFolder + "ScalingStatDistribution.dbc");
            //ScalingStatValues = new DBCFile<ScalingStatValuesEntry>(DbcFolder + "ScalingStatValues.dbc");
            //ScreenEffect = new DBCFile<ScreenEffectEntry>(DbcFolder + "ScreenEffect.dbc");
            //ServerMessages = new DBCFile<ServerMessagesEntry>(DbcFolder + "ServerMessages.dbc");
            //SheatheSoundLookups = new DBCFile<SheatheSoundLookupsEntry>(DbcFolder + "SheatheSoundLookups.dbc");
            //SkillCostsData = new DBCFile<SkillCostsDataEntry>(DbcFolder + "SkillCostsData.dbc");
            SkillLine = new DBCFile<SkillLineEntry>(DbcFolder + "SkillLine.dbc");
            SkillLineAbility = new DBCFile<SkillLineAbilityEntry>(DbcFolder + "SkillLineAbility.dbc");
            //SkillLineCategory = new DBCFile<SkillLineCategoryEntry>(DbcFolder + "SkillLineCategory.dbc");
            SkillRaceClassInfo = new DBCFile<SkillRaceClassInfoEntry>(DbcFolder + "SkillRaceClassInfo.dbc");
            //SkillTiers = new DBCFile<SkillTiersEntry>(DbcFolder + "SkillTiers.dbc");
            //SoundAmbience = new DBCFile<SoundAmbienceEntry>(DbcFolder + "SoundAmbience.dbc");
            //SoundEmitters = new DBCFile<SoundEmittersEntry>(DbcFolder + "SoundEmitters.dbc");
            //SoundEntries = new DBCFile<SoundEntriesEntry>(DbcFolder + "SoundEntries.dbc");
            //SoundEntriesAdvanced = new DBCFile<SoundEntriesAdvancedEntry>(DbcFolder + "SoundEntriesAdvanced.dbc");
            //SoundFilter = new DBCFile<SoundFilterEntry>(DbcFolder + "SoundFilter.dbc");
            //SoundFilterElem = new DBCFile<SoundFilterElemEntry>(DbcFolder + "SoundFilterElem.dbc");
            //SoundProviderPreferences = new DBCFile<SoundProviderPreferencesEntry>(DbcFolder + "SoundProviderPreferences.dbc");
            //SoundSamplePreferences = new DBCFile<SoundSamplePreferencesEntry>(DbcFolder + "SoundSamplePreferences.dbc");
            //SoundWaterType = new DBCFile<SoundWaterTypeEntry>(DbcFolder + "SoundWaterType.dbc");
            //SpamMessages = new DBCFile<SpamMessagesEntry>(DbcFolder + "SpamMessages.dbc");
            Spell = new DBCFile<SpellEntry>(DbcFolder + "Spell.dbc");
            //SpellCastTimes = new DBCFile<SpellCastTimesEntry>(DbcFolder + "SpellCastTimes.dbc");
            //SpellCategory = new DBCFile<SpellCategoryEntry>(DbcFolder + "SpellCategory.dbc");
            //SpellChainEffects = new DBCFile<SpellChainEffectsEntry>(DbcFolder + "SpellChainEffects.dbc");
            //SpellDescriptionVariables = new DBCFile<SpellDescriptionVariablesEntry>(DbcFolder + "SpellDescriptionVariables.dbc");
            //SpellDifficulty = new DBCFile<SpellDifficultyEntry>(DbcFolder + "SpellDifficulty.dbc");
            //SpellDispelType = new DBCFile<SpellDispelTypeEntry>(DbcFolder + "SpellDispelType.dbc");
            //SpellDuration = new DBCFile<SpellDurationEntry>(DbcFolder + "SpellDuration.dbc");
            //SpellEffectCameraShakes = new DBCFile<SpellEffectCameraShakesEntry>(DbcFolder + "SpellEffectCameraShakes.dbc");
            SpellFocusObject = new DBCFile<SpellFocusObjectEntry>(DbcFolder + "SpellFocusObject.dbc");
            SpellIcon = new DBCFile<SpellIconEntry>(DbcFolder + "SpellIcon.dbc");
            //SpellItemEnchantment = new DBCFile<SpellItemEnchantmentEntry>(DbcFolder + "SpellItemEnchantment.dbc");
            //SpellItemEnchantmentCondition = new DBCFile<SpellItemEnchantmentConditionEntry>(DbcFolder + "SpellItemEnchantmentCondition.dbc");
            //SpellMechanic = new DBCFile<SpellMechanicEntry>(DbcFolder + "SpellMechanic.dbc");
            //SpellMissile = new DBCFile<SpellMissileEntry>(DbcFolder + "SpellMissile.dbc");
            //SpellMissileMotion = new DBCFile<SpellMissileMotionEntry>(DbcFolder + "SpellMissileMotion.dbc");
            //SpellRadius = new DBCFile<SpellRadiusEntry>(DbcFolder + "SpellRadius.dbc");
            //SpellRange = new DBCFile<SpellRangeEntry>(DbcFolder + "SpellRange.dbc");
            //SpellRuneCost = new DBCFile<SpellRuneCostEntry>(DbcFolder + "SpellRuneCost.dbc");
            //SpellShapeshiftForm = new DBCFile<SpellShapeshiftFormEntry>(DbcFolder + "SpellShapeshiftForm.dbc");
            //SpellVisual = new DBCFile<SpellVisualEntry>(DbcFolder + "SpellVisual.dbc");
            //SpellVisualEffectName = new DBCFile<SpellVisualEffectNameEntry>(DbcFolder + "SpellVisualEffectName.dbc");
            //SpellVisualKit = new DBCFile<SpellVisualKitEntry>(DbcFolder + "SpellVisualKit.dbc");
            //SpellVisualKitAreaModel = new DBCFile<SpellVisualKitAreaModelEntry>(DbcFolder + "SpellVisualKitAreaModel.dbc");
            //SpellVisualKitModelAttach = new DBCFile<SpellVisualKitModelAttachEntry>(DbcFolder + "SpellVisualKitModelAttach.dbc");
            //SpellVisualPrecastTransitions = new DBCFile<SpellVisualPrecastTransitionsEntry>(DbcFolder + "SpellVisualPrecastTransitions.dbc");
            //StableSlotPrices = new DBCFile<StableSlotPricesEntry>(DbcFolder + "StableSlotPrices.dbc");
            //StartupStrings = new DBCFile<StartupStringsEntry>(DbcFolder + "Startup_Strings.dbc");
            //Stationery = new DBCFile<StationeryEntry>(DbcFolder + "Stationery.dbc");
            //StringLookups = new DBCFile<StringLookupsEntry>(DbcFolder + "StringLookups.dbc");
            //SummonProperties = new DBCFile<SummonPropertiesEntry>(DbcFolder + "SummonProperties.dbc");
            Talent = new DBCFile<TalentEntry>(DbcFolder + "Talent.dbc");
            TalentTab = new DBCFile<TalentTabEntry>(DbcFolder + "TalentTab.dbc");
            //TaxiNodes = new DBCFile<TaxiNodesEntry>(DbcFolder + "TaxiNodes.dbc");
            //TaxiPath = new DBCFile<TaxiPathEntry>(DbcFolder + "TaxiPath.dbc");
            //TaxiPathNode = new DBCFile<TaxiPathNodeEntry>(DbcFolder + "TaxiPathNode.dbc");
            //TeamContributionPoints = new DBCFile<TeamContributionPointsEntry>(DbcFolder + "TeamContributionPoints.dbc");
            //TerrainType = new DBCFile<TerrainTypeEntry>(DbcFolder + "TerrainType.dbc");
            //TerrainTypeSounds = new DBCFile<TerrainTypeSoundsEntry>(DbcFolder + "TerrainTypeSounds.dbc");
            //TotemCategory = new DBCFile<TotemCategoryEntry>(DbcFolder + "TotemCategory.dbc");
            //TransportAnimation = new DBCFile<TransportAnimationEntry>(DbcFolder + "TransportAnimation.dbc");
            //TransportPhysics = new DBCFile<TransportPhysicsEntry>(DbcFolder + "TransportPhysics.dbc");
            //TransportRotation = new DBCFile<TransportRotationEntry>(DbcFolder + "TransportRotation.dbc");
            //UISoundLookups = new DBCFile<UISoundLookupsEntry>(DbcFolder + "UISoundLookups.dbc");
            //UnitBlood = new DBCFile<UnitBloodEntry>(DbcFolder + "UnitBlood.dbc");
            //UnitBloodLevels = new DBCFile<UnitBloodLevelsEntry>(DbcFolder + "UnitBloodLevels.dbc");
            //Vehicle = new DBCFile<VehicleEntry>(DbcFolder + "Vehicle.dbc");
            //VehicleSeat = new DBCFile<VehicleSeatEntry>(DbcFolder + "VehicleSeat.dbc");
            //VehicleUIIndicator = new DBCFile<VehicleUIIndicatorEntry>(DbcFolder + "VehicleUIIndicator.dbc");
            //VehicleUIIndSeat = new DBCFile<VehicleUIIndSeatEntry>(DbcFolder + "VehicleUIIndSeat.dbc");
            //VideoHardware = new DBCFile<VideoHardwareEntry>(DbcFolder + "VideoHardware.dbc");
            //VocalUISounds = new DBCFile<VocalUISoundsEntry>(DbcFolder + "VocalUISounds.dbc");
            //WeaponImpactSounds = new DBCFile<WeaponImpactSoundsEntry>(DbcFolder + "WeaponImpactSounds.dbc");
            //WeaponSwingSounds2 = new DBCFile<WeaponSwingSounds2Entry>(DbcFolder + "WeaponSwingSounds2.dbc");
            //Weather = new DBCFile<WeatherEntry>(DbcFolder + "Weather.dbc");
            //WMOAreaTable = new DBCFile<WMOAreaTableEntry>(DbcFolder + "WMOAreaTable.dbc");
            //WorldChunkSounds = new DBCFile<WorldChunkSoundsEntry>(DbcFolder + "WorldChunkSounds.dbc");
            WorldMapArea = new DBCFile<WorldMapAreaEntry>(DbcFolder + "WorldMapArea.dbc");
            //WorldMapContinent = new DBCFile<WorldMapContinentEntry>(DbcFolder + "WorldMapContinent.dbc");
            WorldMapOverlay = new DBCFile<WorldMapOverlayEntry>(DbcFolder + "WorldMapOverlay.dbc");
            //WorldMapTransforms = new DBCFile<WorldMapTransformsEntry>(DbcFolder + "WorldMapTransforms.dbc");
            //WorldSafeLocs = new DBCFile<WorldSafeLocsEntry>(DbcFolder + "WorldSafeLocs.dbc");
            //WorldStateUI = new DBCFile<WorldStateUIEntry>(DbcFolder + "WorldStateUI.dbc");
            //WorldStateZoneSounds = new DBCFile<WorldStateZoneSoundsEntry>(DbcFolder + "WorldStateZoneSounds.dbc");
            //WowErrorStrings = new DBCFile<WowErrorStringsEntry>(DbcFolder + "WowError_Strings.dbc");
            //ZoneIntroMusicTable = new DBCFile<ZoneIntroMusicTableEntry>(DbcFolder + "ZoneIntroMusicTable.dbc");
            //ZoneMusic = new DBCFile<ZoneMusicEntry>(DbcFolder + "ZoneMusic.dbc");
            #endregion
        }
    }
}
