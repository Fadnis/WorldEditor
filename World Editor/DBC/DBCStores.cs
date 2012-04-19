using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.DBC
{
    public static class DBCStores
    {
        //public static DBCFile<AchievementEntry> Achievement { get; private set; }
        //public static DBCFile<AchievementCategoryEntry> AchievementCategory { get; private set; }
        //public static DBCFile<AchievementCriteriaEntry> AchievementCriteria { get; private set; }
        //public static DBCFile<AnimationDataEntry> AnimationData { get; private set; }
        //public static DBCFile<AreaGroupEntry> AreaGroup { get; private set; }
        //public static DBCFile<AreaPOIEntry> AreaPOI { get; private set; }
        //public static DBCFile<AreaTableEntry> AreaTable { get; private set; }
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
        //public static DBCFile<DungeonMapEntry> DungeonMap { get; private set; }
        //public static DBCFile<DungeonMapChunkEntry> DungeonMapChunk { get; private set; }
        //public static DBCFile<DurabilityCostsEntry> DurabilityCosts { get; private set; }
        //public static DBCFile<DurabilityQualityEntry> DurabilityQuality { get; private set; }
        //public static DBCFile<EmotesEntry> Emotes { get; private set; }
        //public static DBCFile<EmotesTextEntry> EmotesText { get; private set; }
        //public static DBCFile<EmotesTextDataEntry> EmotesTextData { get; private set; }
        //public static DBCFile<EmotesTextSoundEntry> EmotesTextSound { get; private set; }
        //public static DBCFile<EnvironmentalDamageEntry> EnvironmentalDamage { get; private set; }
        //public static DBCFile<ExhaustionEntry> Exhaustion { get; private set; }
        //public static DBCFile<FactionEntry> Faction { get; private set; }
        //public static DBCFile<FactionGroupEntry> FactionGroup { get; private set; }
        //public static DBCFile<FactionTemplateEntry> FactionTemplate { get; private set; }
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
        //public static DBCFile<MapEntry> Map { get; private set; }
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
        //public static DBCFile<SkillLineEntry> SkillLine { get; private set; }
        //public static DBCFile<SkillLineAbilityEntry> SkillLineAbility { get; private set; }
        //public static DBCFile<SkillLineCategoryEntry> SkillLineCategory { get; private set; }
        //public static DBCFile<SkillRaceClassInfoEntry> SkillRaceClassInfo { get; private set; }
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
        //public static DBCFile<SpellEntry> Spell { get; private set; }
        //public static DBCFile<SpellCastTimesEntry> SpellCastTimes { get; private set; }
        //public static DBCFile<SpellCategoryEntry> SpellCategory { get; private set; }
        //public static DBCFile<SpellChainEffectsEntry> SpellChainEffects { get; private set; }
        //public static DBCFile<SpellDescriptionVariablesEntry> SpellDescriptionVariables { get; private set; }
        //public static DBCFile<SpellDifficultyEntry> SpellDifficulty { get; private set; }
        //public static DBCFile<SpellDispelTypeEntry> SpellDispelType { get; private set; }
        //public static DBCFile<SpellDurationEntry> SpellDuration { get; private set; }
        //public static DBCFile<SpellEffectCameraShakesEntry> SpellEffectCameraShakes { get; private set; }
        //public static DBCFile<SpellFocusObjectEntry> SpellFocusObject { get; private set; }
        //public static DBCFile<SpellIconEntry> SpellIcon { get; private set; }
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
        //public static DBCFile<TalentEntry> Talent { get; private set; }
        //public static DBCFile<TalentTabEntry> TalentTab { get; private set; }
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
        //public static DBCFile<WorldMapAreaEntry> WorldMapArea { get; private set; }
        //public static DBCFile<WorldMapContinentEntry> WorldMapContinent { get; private set; }
        //public static DBCFile<WorldMapOverlayEntry> WorldMapOverlay { get; private set; }
        //public static DBCFile<WorldMapTransformsEntry> WorldMapTransforms { get; private set; }
        //public static DBCFile<WorldSafeLocsEntry> WorldSafeLocs { get; private set; }
        //public static DBCFile<WorldStateUIEntry> WorldStateUI { get; private set; }
        //public static DBCFile<WorldStateZoneSoundsEntry> WorldStateZoneSounds { get; private set; }
        //public static DBCFile<WowErrorStringsEntry> WowErrorStrings { get; private set; }
        //public static DBCFile<ZoneIntroMusicTableEntry> ZoneIntroMusicTable { get; private set; }
        //public static DBCFile<ZoneMusicEntry> ZoneMusic { get; private set; }

        public static string folder = "dbc\\";

        public static void LoadFiles()
        {
            //Achievement = new DBCFile<AchievementEntry>(folder + "Achievement.dbc");
            //AchievementCategory = new DBCFile<AchievementCategoryEntry>(folder + "Achievement_Category.dbc");
            //AchievementCriteria = new DBCFile<AchievementCriteriaEntry>(folder + "Achievement_Criteria.dbc");
            //AnimationData = new DBCFile<AnimationDataEntry>(folder + "AnimationData.dbc");
            //AreaGroup = new DBCFile<AreaGroupEntry>(folder + "AreaGroup.dbc");
            //AreaPOI = new DBCFile<AreaPOIEntry>(folder + "AreaPOI.dbc");
            //AreaTable = new DBCFile<AreaTableEntry>(folder + "AreaTable.dbc");
            //AreaTrigger = new DBCFile<AreaTriggerEntry>(folder + "AreaTrigger.dbc");
            //AttackAnimKits = new DBCFile<AttackAnimKitsEntry>(folder + "AttackAnimKits.dbc");
            //AttackAnimTypes = new DBCFile<AttackAnimTypesEntry>(folder + "AttackAnimTypes.dbc");
            //AuctionHouse = new DBCFile<AuctionHouseEntry>(folder + "AuctionHouse.dbc");
            //BankBagSlotPrices = new DBCFile<BankBagSlotPricesEntry>(folder + "BankBagSlotPrices.dbc");
            //BannedAddOns = new DBCFile<BannedAddOnsEntry>(folder + "BannedAddOns.dbc");
            //BarberShopStyle = new DBCFile<BarberShopStyleEntry>(folder + "BarberShopStyle.dbc");
            //BattlemasterList = new DBCFile<BattlemasterListEntry>(folder + "BattlemasterList.dbc");
            //CameraShakes = new DBCFile<CameraShakesEntry>(folder + "CameraShakes.dbc");
            //CfgCategories = new DBCFile<CfgCategoriesEntry>(folder + "Cfg_Categories.dbc");
            //CfgConfigs = new DBCFile<CfgConfigsEntry>(folder + "Cfg_Configs.dbc");
            //CharacterFacialHairStyles = new DBCFile<CharacterFacialHairStylesEntry>(folder + "CharacterFacialHairStyles.dbc");
            //CharBaseInfo = new DBCFile<CharBaseInfoEntry>(folder + "CharBaseInfo.dbc");
            //CharHairGeosets = new DBCFile<CharHairGeosetsEntry>(folder + "CharHairGeosets.dbc");
            //CharHairTextures = new DBCFile<CharHairTexturesEntry>(folder + "CharHairTextures.dbc");
            //CharSections = new DBCFile<CharSectionsEntry>(folder + "CharSections.dbc");
            //CharStartOutfit = new DBCFile<CharStartOutfitEntry>(folder + "CharStartOutfit.dbc");
            //CharTitles = new DBCFile<CharTitlesEntry>(folder + "CharTitles.dbc");
            //CharVariations = new DBCFile<CharVariationsEntry>(folder + "CharVariations.dbc");
            //ChatChannels = new DBCFile<ChatChannelsEntry>(folder + "ChatChannels.dbc");
            //ChatProfanity = new DBCFile<ChatProfanityEntry>(folder + "ChatProfanity.dbc");
            //ChrClasses = new DBCFile<ChrClassesEntry>(folder + "ChrClasses.dbc");
            //ChrRaces = new DBCFile<ChrRacesEntry>(folder + "ChrRaces.dbc");
            //CinematicCamera = new DBCFile<CinematicCameraEntry>(folder + "CinematicCamera.dbc");
            //CinematicSequences = new DBCFile<CinematicSequencesEntry>(folder + "CinematicSequences.dbc");
            //CreatureDisplayInfo = new DBCFile<CreatureDisplayInfoEntry>(folder + "CreatureDisplayInfo.dbc");
            //CreatureDisplayInfoExtra = new DBCFile<CreatureDisplayInfoExtraEntry>(folder + "CreatureDisplayInfoExtra.dbc");
            //CreatureFamily = new DBCFile<CreatureFamilyEntry>(folder + "CreatureFamily.dbc");
            //CreatureModelData = new DBCFile<CreatureModelDataEntry>(folder + "CreatureModelData.dbc");
            //CreatureMovementInfo = new DBCFile<CreatureMovementInfoEntry>(folder + "CreatureMovementInfo.dbc");
            //CreatureSoundData = new DBCFile<CreatureSoundDataEntry>(folder + "CreatureSoundData.dbc");
            //CreatureSpellData = new DBCFile<CreatureSpellDataEntry>(folder + "CreatureSpellData.dbc");
            //CreatureType = new DBCFile<CreatureTypeEntry>(folder + "CreatureType.dbc");
            //CurrencyCategory = new DBCFile<CurrencyCategoryEntry>(folder + "CurrencyCategory.dbc");
            //CurrencyTypes = new DBCFile<CurrencyTypesEntry>(folder + "CurrencyTypes.dbc");
            //DanceMoves = new DBCFile<DanceMovesEntry>(folder + "DanceMoves.dbc");
            //DeathThudLookups = new DBCFile<DeathThudLookupsEntry>(folder + "DeathThudLookups.dbc");
            //DeclinedWord = new DBCFile<DeclinedWordEntry>(folder + "DeclinedWord.dbc");
            //DeclinedWordCases = new DBCFile<DeclinedWordCasesEntry>(folder + "DeclinedWordCases.dbc");
            //DestructibleModelData = new DBCFile<DestructibleModelDataEntry>(folder + "DestructibleModelData.dbc");
            //DungeonEncounter = new DBCFile<DungeonEncounterEntry>(folder + "DungeonEncounter.dbc");
            //DungeonMap = new DBCFile<DungeonMapEntry>(folder + "DungeonMap.dbc");
            //DungeonMapChunk = new DBCFile<DungeonMapChunkEntry>(folder + "DungeonMapChunk.dbc");
            //DurabilityCosts = new DBCFile<DurabilityCostsEntry>(folder + "DurabilityCosts.dbc");
            //DurabilityQuality = new DBCFile<DurabilityQualityEntry>(folder + "DurabilityQuality.dbc");
            //Emotes = new DBCFile<EmotesEntry>(folder + "Emotes.dbc");
            //EmotesText = new DBCFile<EmotesTextEntry>(folder + "EmotesText.dbc");
            //EmotesTextData = new DBCFile<EmotesTextDataEntry>(folder + "EmotesTextData.dbc");
            //EmotesTextSound = new DBCFile<EmotesTextSoundEntry>(folder + "EmotesTextSound.dbc");
            //EnvironmentalDamage = new DBCFile<EnvironmentalDamageEntry>(folder + "EnvironmentalDamage.dbc");
            //Exhaustion = new DBCFile<ExhaustionEntry>(folder + "Exhaustion.dbc");
            //Faction = new DBCFile<FactionEntry>(folder + "Faction.dbc");
            //FactionGroup = new DBCFile<FactionGroupEntry>(folder + "FactionGroup.dbc");
            //FactionTemplate = new DBCFile<FactionTemplateEntry>(folder + "FactionTemplate.dbc");
            //FileData = new DBCFile<FileDataEntry>(folder + "FileData.dbc");
            //FootprintTextures = new DBCFile<FootprintTexturesEntry>(folder + "FootprintTextures.dbc");
            //FootstepTerrainLookup = new DBCFile<FootstepTerrainLookupEntry>(folder + "FootstepTerrainLookup.dbc");
            //GameObjectArtKit = new DBCFile<GameObjectArtKitEntry>(folder + "GameObjectArtKit.dbc");
            //GameObjectDisplayInfo = new DBCFile<GameObjectDisplayInfoEntry>(folder + "GameObjectDisplayInfo.dbc");
            //GameTables = new DBCFile<GameTablesEntry>(folder + "GameTables.dbc");
            //GameTips = new DBCFile<GameTipsEntry>(folder + "GameTips.dbc");
            //GemProperties = new DBCFile<GemPropertiesEntry>(folder + "GemProperties.dbc");
            //GlyphProperties = new DBCFile<GlyphPropertiesEntry>(folder + "GlyphProperties.dbc");
            //GlyphSlot = new DBCFile<GlyphSlotEntry>(folder + "GlyphSlot.dbc");
            //GMSurveyAnswers = new DBCFile<GMSurveyAnswersEntry>(folder + "GMSurveyAnswers.dbc");
            //GMSurveyCurrentSurvey = new DBCFile<GMSurveyCurrentSurveyEntry>(folder + "GMSurveyCurrentSurvey.dbc");
            //GMSurveyQuestions = new DBCFile<GMSurveyQuestionsEntry>(folder + "GMSurveyQuestions.dbc");
            //GMSurveySurveys = new DBCFile<GMSurveySurveysEntry>(folder + "GMSurveySurveys.dbc");
            //GMTicketCategory = new DBCFile<GMTicketCategoryEntry>(folder + "GMTicketCategory.dbc");
            //GroundEffectDoodad = new DBCFile<GroundEffectDoodadEntry>(folder + "GroundEffectDoodad.dbc");
            //GroundEffectTexture = new DBCFile<GroundEffectTextureEntry>(folder + "GroundEffectTexture.dbc");
            //gtBarberShopCostBase = new DBCFile<gtBarberShopCostBaseEntry>(folder + "gtBarberShopCostBase.dbc");
            //gtChanceToMeleeCrit = new DBCFile<gtChanceToMeleeCritEntry>(folder + "gtChanceToMeleeCrit.dbc");
            //gtChanceToMeleeCritBase = new DBCFile<gtChanceToMeleeCritBaseEntry>(folder + "gtChanceToMeleeCritBase.dbc");
            //gtChanceToSpellCrit = new DBCFile<gtChanceToSpellCritEntry>(folder + "gtChanceToSpellCrit.dbc");
            //gtChanceToSpellCritBase = new DBCFile<gtChanceToSpellCritBaseEntry>(folder + "gtChanceToSpellCritBase.dbc");
            //gtCombatRatings = new DBCFile<gtCombatRatingsEntry>(folder + "gtCombatRatings.dbc");
            //gtNPCManaCostScaler = new DBCFile<gtNPCManaCostScalerEntry>(folder + "gtNPCManaCostScaler.dbc");
            //gtOCTClassCombatRatingScalar = new DBCFile<gtOCTClassCombatRatingScalarEntry>(folder + "gtOCTClassCombatRatingScalar.dbc");
            //gtOCTRegenHP = new DBCFile<gtOCTRegenHPEntry>(folder + "gtOCTRegenHP.dbc");
            //gtOCTRegenMP = new DBCFile<gtOCTRegenMPEntry>(folder + "gtOCTRegenMP.dbc");
            //gtRegenHPPerSpt = new DBCFile<gtRegenHPPerSptEntry>(folder + "gtRegenHPPerSpt.dbc");
            //gtRegenMPPerSpt = new DBCFile<gtRegenMPPerSptEntry>(folder + "gtRegenMPPerSpt.dbc");
            //HelmetGeosetVisData = new DBCFile<HelmetGeosetVisDataEntry>(folder + "HelmetGeosetVisData.dbc");
            //HolidayDescriptions = new DBCFile<HolidayDescriptionsEntry>(folder + "HolidayDescriptions.dbc");
            //HolidayNames = new DBCFile<HolidayNamesEntry>(folder + "HolidayNames.dbc");
            //Holidays = new DBCFile<HolidaysEntry>(folder + "Holidays.dbc");
            //Item = new DBCFile<ItemEntry>(folder + "Item.dbc");
            //ItemBagFamily = new DBCFile<ItemBagFamilyEntry>(folder + "ItemBagFamily.dbc");
            //ItemClass = new DBCFile<ItemClassEntry>(folder + "ItemClass.dbc");
            //ItemCondExtCosts = new DBCFile<ItemCondExtCostsEntry>(folder + "ItemCondExtCosts.dbc");
            //ItemDisplayInfo = new DBCFile<ItemDisplayInfoEntry>(folder + "ItemDisplayInfo.dbc");
            //ItemExtendedCost = new DBCFile<ItemExtendedCostEntry>(folder + "ItemExtendedCost.dbc");
            //ItemGroupSounds = new DBCFile<ItemGroupSoundsEntry>(folder + "ItemGroupSounds.dbc");
            //ItemLimitCategory = new DBCFile<ItemLimitCategoryEntry>(folder + "ItemLimitCategory.dbc");
            //ItemPetFood = new DBCFile<ItemPetFoodEntry>(folder + "ItemPetFood.dbc");
            //ItemPurchaseGroup = new DBCFile<ItemPurchaseGroupEntry>(folder + "ItemPurchaseGroup.dbc");
            //ItemRandomProperties = new DBCFile<ItemRandomPropertiesEntry>(folder + "ItemRandomProperties.dbc");
            //ItemRandomSuffix = new DBCFile<ItemRandomSuffixEntry>(folder + "ItemRandomSuffix.dbc");
            //ItemSet = new DBCFile<ItemSetEntry>(folder + "ItemSet.dbc");
            //ItemSubClass = new DBCFile<ItemSubClassEntry>(folder + "ItemSubClass.dbc");
            //ItemSubClassMask = new DBCFile<ItemSubClassMaskEntry>(folder + "ItemSubClassMask.dbc");
            //ItemVisualEffects = new DBCFile<ItemVisualEffectsEntry>(folder + "ItemVisualEffects.dbc");
            //ItemVisuals = new DBCFile<ItemVisualsEntry>(folder + "ItemVisuals.dbc");
            //Languages = new DBCFile<LanguagesEntry>(folder + "Languages.dbc");
            //LanguageWords = new DBCFile<LanguageWordsEntry>(folder + "LanguageWords.dbc");
            //LFGDungeonExpansion = new DBCFile<LFGDungeonExpansionEntry>(folder + "LFGDungeonExpansion.dbc");
            //LFGDungeonGroup = new DBCFile<LFGDungeonGroupEntry>(folder + "LFGDungeonGroup.dbc");
            //LFGDungeons = new DBCFile<LFGDungeonsEntry>(folder + "LFGDungeons.dbc");
            //Light = new DBCFile<LightEntry>(folder + "Light.dbc");
            //LightFloatBand = new DBCFile<LightFloatBandEntry>(folder + "LightFloatBand.dbc");
            //LightIntBand = new DBCFile<LightIntBandEntry>(folder + "LightIntBand.dbc");
            //LightParams = new DBCFile<LightParamsEntry>(folder + "LightParams.dbc");
            //LightSkybox = new DBCFile<LightSkyboxEntry>(folder + "LightSkybox.dbc");
            //LiquidMaterial = new DBCFile<LiquidMaterialEntry>(folder + "LiquidMaterial.dbc");
            //LiquidType = new DBCFile<LiquidTypeEntry>(folder + "LiquidType.dbc");
            //LoadingScreens = new DBCFile<LoadingScreensEntry>(folder + "LoadingScreens.dbc");
            //LoadingScreenTaxiSplines = new DBCFile<LoadingScreenTaxiSplinesEntry>(folder + "LoadingScreenTaxiSplines.dbc");
            //Lock = new DBCFile<LockEntry>(folder + "Lock.dbc");
            //LockType = new DBCFile<LockTypeEntry>(folder + "LockType.dbc");
            //MailTemplate = new DBCFile<MailTemplateEntry>(folder + "MailTemplate.dbc");
            //Map = new DBCFile<MapEntry>(folder + "Map.dbc");
            //MapDifficulty = new DBCFile<MapDifficultyEntry>(folder + "MapDifficulty.dbc");
            //Material = new DBCFile<MaterialEntry>(folder + "Material.dbc");
            //Movie = new DBCFile<MovieEntry>(folder + "Movie.dbc");
            //MovieFileData = new DBCFile<MovieFileDataEntry>(folder + "MovieFileData.dbc");
            //MovieVariation = new DBCFile<MovieVariationEntry>(folder + "MovieVariation.dbc");
            //NameGen = new DBCFile<NameGenEntry>(folder + "NameGen.dbc");
            //NamesProfanity = new DBCFile<NamesProfanityEntry>(folder + "NamesProfanity.dbc");
            //NamesReserved = new DBCFile<NamesReservedEntry>(folder + "NamesReserved.dbc");
            //NPCSounds = new DBCFile<NPCSoundsEntry>(folder + "NPCSounds.dbc");
            //ObjectEffect = new DBCFile<ObjectEffectEntry>(folder + "ObjectEffect.dbc");
            //ObjectEffectGroup = new DBCFile<ObjectEffectGroupEntry>(folder + "ObjectEffectGroup.dbc");
            //ObjectEffectModifier = new DBCFile<ObjectEffectModifierEntry>(folder + "ObjectEffectModifier.dbc");
            //ObjectEffectPackage = new DBCFile<ObjectEffectPackageEntry>(folder + "ObjectEffectPackage.dbc");
            //ObjectEffectPackageElem = new DBCFile<ObjectEffectPackageElemEntry>(folder + "ObjectEffectPackageElem.dbc");
            //OverrideSpellData = new DBCFile<OverrideSpellDataEntry>(folder + "OverrideSpellData.dbc");
            //Package = new DBCFile<PackageEntry>(folder + "Package.dbc");
            //PageTextMaterial = new DBCFile<PageTextMaterialEntry>(folder + "PageTextMaterial.dbc");
            //PaperDollItemFrame = new DBCFile<PaperDollItemFrameEntry>(folder + "PaperDollItemFrame.dbc");
            //ParticleColor = new DBCFile<ParticleColorEntry>(folder + "ParticleColor.dbc");
            //PetitionType = new DBCFile<PetitionTypeEntry>(folder + "PetitionType.dbc");
            //PetPersonality = new DBCFile<PetPersonalityEntry>(folder + "PetPersonality.dbc");
            //PowerDisplay = new DBCFile<PowerDisplayEntry>(folder + "PowerDisplay.dbc");
            //PvpDifficulty = new DBCFile<PvpDifficultyEntry>(folder + "PvpDifficulty.dbc");
            //QuestFactionReward = new DBCFile<QuestFactionRewardEntry>(folder + "QuestFactionReward.dbc");
            //QuestInfo = new DBCFile<QuestInfoEntry>(folder + "QuestInfo.dbc");
            //QuestSort = new DBCFile<QuestSortEntry>(folder + "QuestSort.dbc");
            //QuestXP = new DBCFile<QuestXPEntry>(folder + "QuestXP.dbc");
            //RandPropPoints = new DBCFile<RandPropPointsEntry>(folder + "RandPropPoints.dbc");
            //Resistances = new DBCFile<ResistancesEntry>(folder + "Resistances.dbc");
            //ScalingStatDistribution = new DBCFile<ScalingStatDistributionEntry>(folder + "ScalingStatDistribution.dbc");
            //ScalingStatValues = new DBCFile<ScalingStatValuesEntry>(folder + "ScalingStatValues.dbc");
            //ScreenEffect = new DBCFile<ScreenEffectEntry>(folder + "ScreenEffect.dbc");
            //ServerMessages = new DBCFile<ServerMessagesEntry>(folder + "ServerMessages.dbc");
            //SheatheSoundLookups = new DBCFile<SheatheSoundLookupsEntry>(folder + "SheatheSoundLookups.dbc");
            //SkillCostsData = new DBCFile<SkillCostsDataEntry>(folder + "SkillCostsData.dbc");
            //SkillLine = new DBCFile<SkillLineEntry>(folder + "SkillLine.dbc");
            //SkillLineAbility = new DBCFile<SkillLineAbilityEntry>(folder + "SkillLineAbility.dbc");
            //SkillLineCategory = new DBCFile<SkillLineCategoryEntry>(folder + "SkillLineCategory.dbc");
            //SkillRaceClassInfo = new DBCFile<SkillRaceClassInfoEntry>(folder + "SkillRaceClassInfo.dbc");
            //SkillTiers = new DBCFile<SkillTiersEntry>(folder + "SkillTiers.dbc");
            //SoundAmbience = new DBCFile<SoundAmbienceEntry>(folder + "SoundAmbience.dbc");
            //SoundEmitters = new DBCFile<SoundEmittersEntry>(folder + "SoundEmitters.dbc");
            //SoundEntries = new DBCFile<SoundEntriesEntry>(folder + "SoundEntries.dbc");
            //SoundEntriesAdvanced = new DBCFile<SoundEntriesAdvancedEntry>(folder + "SoundEntriesAdvanced.dbc");
            //SoundFilter = new DBCFile<SoundFilterEntry>(folder + "SoundFilter.dbc");
            //SoundFilterElem = new DBCFile<SoundFilterElemEntry>(folder + "SoundFilterElem.dbc");
            //SoundProviderPreferences = new DBCFile<SoundProviderPreferencesEntry>(folder + "SoundProviderPreferences.dbc");
            //SoundSamplePreferences = new DBCFile<SoundSamplePreferencesEntry>(folder + "SoundSamplePreferences.dbc");
            //SoundWaterType = new DBCFile<SoundWaterTypeEntry>(folder + "SoundWaterType.dbc");
            //SpamMessages = new DBCFile<SpamMessagesEntry>(folder + "SpamMessages.dbc");
            //Spell = new DBCFile<SpellEntry>(folder + "Spell.dbc");
            //SpellCastTimes = new DBCFile<SpellCastTimesEntry>(folder + "SpellCastTimes.dbc");
            //SpellCategory = new DBCFile<SpellCategoryEntry>(folder + "SpellCategory.dbc");
            //SpellChainEffects = new DBCFile<SpellChainEffectsEntry>(folder + "SpellChainEffects.dbc");
            //SpellDescriptionVariables = new DBCFile<SpellDescriptionVariablesEntry>(folder + "SpellDescriptionVariables.dbc");
            //SpellDifficulty = new DBCFile<SpellDifficultyEntry>(folder + "SpellDifficulty.dbc");
            //SpellDispelType = new DBCFile<SpellDispelTypeEntry>(folder + "SpellDispelType.dbc");
            //SpellDuration = new DBCFile<SpellDurationEntry>(folder + "SpellDuration.dbc");
            //SpellEffectCameraShakes = new DBCFile<SpellEffectCameraShakesEntry>(folder + "SpellEffectCameraShakes.dbc");
            //SpellFocusObject = new DBCFile<SpellFocusObjectEntry>(folder + "SpellFocusObject.dbc");
            //SpellIcon = new DBCFile<SpellIconEntry>(folder + "SpellIcon.dbc");
            //SpellItemEnchantment = new DBCFile<SpellItemEnchantmentEntry>(folder + "SpellItemEnchantment.dbc");
            //SpellItemEnchantmentCondition = new DBCFile<SpellItemEnchantmentConditionEntry>(folder + "SpellItemEnchantmentCondition.dbc");
            //SpellMechanic = new DBCFile<SpellMechanicEntry>(folder + "SpellMechanic.dbc");
            //SpellMissile = new DBCFile<SpellMissileEntry>(folder + "SpellMissile.dbc");
            //SpellMissileMotion = new DBCFile<SpellMissileMotionEntry>(folder + "SpellMissileMotion.dbc");
            //SpellRadius = new DBCFile<SpellRadiusEntry>(folder + "SpellRadius.dbc");
            //SpellRange = new DBCFile<SpellRangeEntry>(folder + "SpellRange.dbc");
            //SpellRuneCost = new DBCFile<SpellRuneCostEntry>(folder + "SpellRuneCost.dbc");
            //SpellShapeshiftForm = new DBCFile<SpellShapeshiftFormEntry>(folder + "SpellShapeshiftForm.dbc");
            //SpellVisual = new DBCFile<SpellVisualEntry>(folder + "SpellVisual.dbc");
            //SpellVisualEffectName = new DBCFile<SpellVisualEffectNameEntry>(folder + "SpellVisualEffectName.dbc");
            //SpellVisualKit = new DBCFile<SpellVisualKitEntry>(folder + "SpellVisualKit.dbc");
            //SpellVisualKitAreaModel = new DBCFile<SpellVisualKitAreaModelEntry>(folder + "SpellVisualKitAreaModel.dbc");
            //SpellVisualKitModelAttach = new DBCFile<SpellVisualKitModelAttachEntry>(folder + "SpellVisualKitModelAttach.dbc");
            //SpellVisualPrecastTransitions = new DBCFile<SpellVisualPrecastTransitionsEntry>(folder + "SpellVisualPrecastTransitions.dbc");
            //StableSlotPrices = new DBCFile<StableSlotPricesEntry>(folder + "StableSlotPrices.dbc");
            //StartupStrings = new DBCFile<StartupStringsEntry>(folder + "Startup_Strings.dbc");
            //Stationery = new DBCFile<StationeryEntry>(folder + "Stationery.dbc");
            //StringLookups = new DBCFile<StringLookupsEntry>(folder + "StringLookups.dbc");
            //SummonProperties = new DBCFile<SummonPropertiesEntry>(folder + "SummonProperties.dbc");
            //Talent = new DBCFile<TalentEntry>(folder + "Talent.dbc");
            //TalentTab = new DBCFile<TalentTabEntry>(folder + "TalentTab.dbc");
            //TaxiNodes = new DBCFile<TaxiNodesEntry>(folder + "TaxiNodes.dbc");
            //TaxiPath = new DBCFile<TaxiPathEntry>(folder + "TaxiPath.dbc");
            //TaxiPathNode = new DBCFile<TaxiPathNodeEntry>(folder + "TaxiPathNode.dbc");
            //TeamContributionPoints = new DBCFile<TeamContributionPointsEntry>(folder + "TeamContributionPoints.dbc");
            //TerrainType = new DBCFile<TerrainTypeEntry>(folder + "TerrainType.dbc");
            //TerrainTypeSounds = new DBCFile<TerrainTypeSoundsEntry>(folder + "TerrainTypeSounds.dbc");
            //TotemCategory = new DBCFile<TotemCategoryEntry>(folder + "TotemCategory.dbc");
            //TransportAnimation = new DBCFile<TransportAnimationEntry>(folder + "TransportAnimation.dbc");
            //TransportPhysics = new DBCFile<TransportPhysicsEntry>(folder + "TransportPhysics.dbc");
            //TransportRotation = new DBCFile<TransportRotationEntry>(folder + "TransportRotation.dbc");
            //UISoundLookups = new DBCFile<UISoundLookupsEntry>(folder + "UISoundLookups.dbc");
            //UnitBlood = new DBCFile<UnitBloodEntry>(folder + "UnitBlood.dbc");
            //UnitBloodLevels = new DBCFile<UnitBloodLevelsEntry>(folder + "UnitBloodLevels.dbc");
            //Vehicle = new DBCFile<VehicleEntry>(folder + "Vehicle.dbc");
            //VehicleSeat = new DBCFile<VehicleSeatEntry>(folder + "VehicleSeat.dbc");
            //VehicleUIIndicator = new DBCFile<VehicleUIIndicatorEntry>(folder + "VehicleUIIndicator.dbc");
            //VehicleUIIndSeat = new DBCFile<VehicleUIIndSeatEntry>(folder + "VehicleUIIndSeat.dbc");
            //VideoHardware = new DBCFile<VideoHardwareEntry>(folder + "VideoHardware.dbc");
            //VocalUISounds = new DBCFile<VocalUISoundsEntry>(folder + "VocalUISounds.dbc");
            //WeaponImpactSounds = new DBCFile<WeaponImpactSoundsEntry>(folder + "WeaponImpactSounds.dbc");
            //WeaponSwingSounds2 = new DBCFile<WeaponSwingSounds2Entry>(folder + "WeaponSwingSounds2.dbc");
            //Weather = new DBCFile<WeatherEntry>(folder + "Weather.dbc");
            //WMOAreaTable = new DBCFile<WMOAreaTableEntry>(folder + "WMOAreaTable.dbc");
            //WorldChunkSounds = new DBCFile<WorldChunkSoundsEntry>(folder + "WorldChunkSounds.dbc");
            //WorldMapArea = new DBCFile<WorldMapAreaEntry>(folder + "WorldMapArea.dbc");
            //WorldMapContinent = new DBCFile<WorldMapContinentEntry>(folder + "WorldMapContinent.dbc");
            //WorldMapOverlay = new DBCFile<WorldMapOverlayEntry>(folder + "WorldMapOverlay.dbc");
            //WorldMapTransforms = new DBCFile<WorldMapTransformsEntry>(folder + "WorldMapTransforms.dbc");
            //WorldSafeLocs = new DBCFile<WorldSafeLocsEntry>(folder + "WorldSafeLocs.dbc");
            //WorldStateUI = new DBCFile<WorldStateUIEntry>(folder + "WorldStateUI.dbc");
            //WorldStateZoneSounds = new DBCFile<WorldStateZoneSoundsEntry>(folder + "WorldStateZoneSounds.dbc");
            //WowErrorStrings = new DBCFile<WowErrorStringsEntry>(folder + "WowError_Strings.dbc");
            //ZoneIntroMusicTable = new DBCFile<ZoneIntroMusicTableEntry>(folder + "ZoneIntroMusicTable.dbc");
            //ZoneMusic = new DBCFile<ZoneMusicEntry>(folder + "ZoneMusic.dbc");


            //Achievement.LoadData();
            //Achievement_Category.LoadData();
            //Achievement_Criteria.LoadData();
            //AnimationData.LoadData();
            //AreaGroup.LoadData();
            //AreaPOI.LoadData();
            //AreaTable.LoadData();
            //AreaTrigger.LoadData();
            //AttackAnimKits.LoadData();
            //AttackAnimTypes.LoadData();
            //AuctionHouse.LoadData();
            //BankBagSlotPrices.LoadData();
            //BannedAddOns.LoadData();
            //BarberShopStyle.LoadData();
            //BattlemasterList.LoadData();
            //CameraShakes.LoadData();
            //Cfg_Categories.LoadData();
            //Cfg_Configs.LoadData();
            //CharacterFacialHairStyles.LoadData();
            //CharBaseInfo.LoadData();
            //CharHairGeosets.LoadData();
            //CharHairTextures.LoadData();
            //CharSections.LoadData();
            //CharStartOutfit.LoadData();
            //CharTitles.LoadData();
            //CharVariations.LoadData();
            //ChatChannels.LoadData();
            //ChatProfanity.LoadData();
            //ChrClasses.LoadData();
            //ChrRaces.LoadData();
            //CinematicCamera.LoadData();
            //CinematicSequences.LoadData();
            //CreatureDisplayInfo.LoadData();
            //CreatureDisplayInfoExtra.LoadData();
            //CreatureFamily.LoadData();
            //CreatureModelData.LoadData();
            //CreatureMovementInfo.LoadData();
            //CreatureSoundData.LoadData();
            //CreatureSpellData.LoadData();
            //CreatureType.LoadData();
            //CurrencyCategory.LoadData();
            //CurrencyTypes.LoadData();
            //DanceMoves.LoadData();
            //DeathThudLookups.LoadData();
            //DeclinedWord.LoadData();
            //DeclinedWordCases.LoadData();
            //DestructibleModelData.LoadData();
            //DungeonEncounter.LoadData();
            //DungeonMap.LoadData();
            //DungeonMapChunk.LoadData();
            //DurabilityCosts.LoadData();
            //DurabilityQuality.LoadData();
            //Emotes.LoadData();
            //EmotesText.LoadData();
            //EmotesTextData.LoadData();
            //EmotesTextSound.LoadData();
            //EnvironmentalDamage.LoadData();
            //Exhaustion.LoadData();
            //Faction.LoadData();
            //FactionGroup.LoadData();
            //FactionTemplate.LoadData();
            //FileData.LoadData();
            //FootprintTextures.LoadData();
            //FootstepTerrainLookup.LoadData();
            //GameObjectArtKit.LoadData();
            //GameObjectDisplayInfo.LoadData();
            //GameTables.LoadData();
            //GameTips.LoadData();
            //GemProperties.LoadData();
            //GlyphProperties.LoadData();
            //GlyphSlot.LoadData();
            //GMSurveyAnswers.LoadData();
            //GMSurveyCurrentSurvey.LoadData();
            //GMSurveyQuestions.LoadData();
            //GMSurveySurveys.LoadData();
            //GMTicketCategory.LoadData();
            //GroundEffectDoodad.LoadData();
            //GroundEffectTexture.LoadData();
            //gtBarberShopCostBase.LoadData();
            //gtChanceToMeleeCrit.LoadData();
            //gtChanceToMeleeCritBase.LoadData();
            //gtChanceToSpellCrit.LoadData();
            //gtChanceToSpellCritBase.LoadData();
            //gtCombatRatings.LoadData();
            //gtNPCManaCostScaler.LoadData();
            //gtOCTClassCombatRatingScalar.LoadData();
            //gtOCTRegenHP.LoadData();
            //gtOCTRegenMP.LoadData();
            //gtRegenHPPerSpt.LoadData();
            //gtRegenMPPerSpt.LoadData();
            //HelmetGeosetVisData.LoadData();
            //HolidayDescriptions.LoadData();
            //HolidayNames.LoadData();
            //Holidays.LoadData();
            //Item.LoadData();
            //ItemBagFamily.LoadData();
            //ItemClass.LoadData();
            //ItemCondExtCosts.LoadData();
            //ItemDisplayInfo.LoadData();
            //ItemExtendedCost.LoadData();
            //ItemGroupSounds.LoadData();
            //ItemLimitCategory.LoadData();
            //ItemPetFood.LoadData();
            //ItemPurchaseGroup.LoadData();
            //ItemRandomProperties.LoadData();
            //ItemRandomSuffix.LoadData();
            //ItemSet.LoadData();
            //ItemSubClass.LoadData();
            //ItemSubClassMask.LoadData();
            //ItemVisualEffects.LoadData();
            //ItemVisuals.LoadData();
            //Languages.LoadData();
            //LanguageWords.LoadData();
            //LFGDungeonExpansion.LoadData();
            //LFGDungeonGroup.LoadData();
            //LFGDungeons.LoadData();
            //Light.LoadData();
            //LightFloatBand.LoadData();
            //LightIntBand.LoadData();
            //LightParams.LoadData();
            //LightSkybox.LoadData();
            //LiquidMaterial.LoadData();
            //LiquidType.LoadData();
            //LoadingScreens.LoadData();
            //LoadingScreenTaxiSplines.LoadData();
            //Lock.LoadData();
            //LockType.LoadData();
            //MailTemplate.LoadData();
            //Map.LoadData();
            //MapDifficulty.LoadData();
            //Material.LoadData();
            //Movie.LoadData();
            //MovieFileData.LoadData();
            //MovieVariation.LoadData();
            //NameGen.LoadData();
            //NamesProfanity.LoadData();
            //NamesReserved.LoadData();
            //NPCSounds.LoadData();
            //ObjectEffect.LoadData();
            //ObjectEffectGroup.LoadData();
            //ObjectEffectModifier.LoadData();
            //ObjectEffectPackage.LoadData();
            //ObjectEffectPackageElem.LoadData();
            //OverrideSpellData.LoadData();
            //Package.LoadData();
            //PageTextMaterial.LoadData();
            //PaperDollItemFrame.LoadData();
            //ParticleColor.LoadData();
            //PetitionType.LoadData();
            //PetPersonality.LoadData();
            //PowerDisplay.LoadData();
            //PvpDifficulty.LoadData();
            //QuestFactionReward.LoadData();
            //QuestInfo.LoadData();
            //QuestSort.LoadData();
            //QuestXP.LoadData();
            //RandPropPoints.LoadData();
            //Resistances.LoadData();
            //ScalingStatDistribution.LoadData();
            //ScalingStatValues.LoadData();
            //ScreenEffect.LoadData();
            //ServerMessages.LoadData();
            //SheatheSoundLookups.LoadData();
            //SkillCostsData.LoadData();
            //SkillLine.LoadData();
            //SkillLineAbility.LoadData();
            //SkillLineCategory.LoadData();
            //SkillRaceClassInfo.LoadData();
            //SkillTiers.LoadData();
            //SoundAmbience.LoadData();
            //SoundEmitters.LoadData();
            //SoundEntries.LoadData();
            //SoundEntriesAdvanced.LoadData();
            //SoundFilter.LoadData();
            //SoundFilterElem.LoadData();
            //SoundProviderPreferences.LoadData();
            //SoundSamplePreferences.LoadData();
            //SoundWaterType.LoadData();
            //SpamMessages.LoadData();
            //Spell.LoadData();
            //SpellCastTimes.LoadData();
            //SpellCategory.LoadData();
            //SpellChainEffects.LoadData();
            //SpellDescriptionVariables.LoadData();
            //SpellDifficulty.LoadData();
            //SpellDispelType.LoadData();
            //SpellDuration.LoadData();
            //SpellEffectCameraShakes.LoadData();
            //SpellFocusObject.LoadData();
            //SpellIcon.LoadData();
            //SpellItemEnchantment.LoadData();
            //SpellItemEnchantmentCondition.LoadData();
            //SpellMechanic.LoadData();
            //SpellMissile.LoadData();
            //SpellMissileMotion.LoadData();
            //SpellRadius.LoadData();
            //SpellRange.LoadData();
            //SpellRuneCost.LoadData();
            //SpellShapeshiftForm.LoadData();
            //SpellVisual.LoadData();
            //SpellVisualEffectName.LoadData();
            //SpellVisualKit.LoadData();
            //SpellVisualKitAreaModel.LoadData();
            //SpellVisualKitModelAttach.LoadData();
            //SpellVisualPrecastTransitions.LoadData();
            //StableSlotPrices.LoadData();
            //Startup_Strings.LoadData();
            //Stationery.LoadData();
            //StringLookups.LoadData();
            //SummonProperties.LoadData();
            //Talent.LoadData();
            //TalentTab.LoadData();
            //TaxiNodes.LoadData();
            //TaxiPath.LoadData();
            //TaxiPathNode.LoadData();
            //TeamContributionPoints.LoadData();
            //TerrainType.LoadData();
            //TerrainTypeSounds.LoadData();
            //TotemCategory.LoadData();
            //TransportAnimation.LoadData();
            //TransportPhysics.LoadData();
            //TransportRotation.LoadData();
            //UISoundLookups.LoadData();
            //UnitBlood.LoadData();
            //UnitBloodLevels.LoadData();
            //Vehicle.LoadData();
            //VehicleSeat.LoadData();
            //VehicleUIIndicator.LoadData();
            //VehicleUIIndSeat.LoadData();
            //VideoHardware.LoadData();
            //VocalUISounds.LoadData();
            //WeaponImpactSounds.LoadData();
            //WeaponSwingSounds2.LoadData();
            //Weather.LoadData();
            //WMOAreaTable.LoadData();
            //WorldChunkSounds.LoadData();
            //WorldMapArea.LoadData();
            //WorldMapContinent.LoadData();
            //WorldMapOverlay.LoadData();
            //WorldMapTransforms.LoadData();
            //WorldSafeLocs.LoadData();
            //WorldStateUI.LoadData();
            //WorldStateZoneSounds.LoadData();
            //WowError_Strings.LoadData();
            //ZoneIntroMusicTable.LoadData();
            //ZoneMusic.LoadData();
        }

        public static void LoadTitlesEditorFiles()
        {
            CharTitles = new DBCFile<CharTitlesEntry>(folder + "CharTitles.dbc");

            CharTitles.LoadData();
        }
    }
}
