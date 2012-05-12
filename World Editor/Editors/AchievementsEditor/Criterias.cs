using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Editor.Editors.AchievementsEditor
{
    public static class Criterias
    {
        public static Dictionary<uint, Criteria> criterias = new Dictionary<uint, Criteria>();
        private static bool loaded = false;

        public static void Init()
        {
            if (loaded)
                return;

            criterias.Add(0, new Criteria
            {
                TypeId = 0,
                TypeName = "KILL_CREATURE",
                ReqType0 = "creatureID",
                ReqValue0 = "creatureCount",
            });

            criterias.Add(1, new Criteria
            {
                TypeId = 1,
                TypeName = "WIN_BG",
                ReqType0 = "bgMapID",
                ReqValue0 = "winCount",
            });

            criterias.Add(5, new Criteria
            {
                TypeId = 5,
                TypeName = "REACH_LEVEL",
                ReqValue0 = "level",
            });

            criterias.Add(7, new Criteria
            {
                TypeId = 7,
                TypeName = "REACH_SKILL_LEVEL",
                ReqType0 = "skillID",
                ReqValue0 = "skillLevel",
            });

            criterias.Add(8, new Criteria
            {
                TypeId = 8,
                TypeName = "COMPLETE_ACHIEVEMENT",
                ReqType0 = "linkedAchievement",
            });

            criterias.Add(9, new Criteria
            {
                TypeId = 9,
                TypeName = "COMPLETE_QUEST_COUNT",
                ReqValue0 = "totalQuestCount",
            });

            criterias.Add(10, new Criteria
            {
                TypeId = 10,
                TypeName = "COMPLETE_DAILY_QUEST_DAILY",
                ReqValue0 = "numberOfDays",
            });

            criterias.Add(11, new Criteria
            {
                TypeId = 11,
                TypeName = "COMPLETE_QUESTS_IN_ZONE",
                ReqType0 = "zoneID",
                ReqValue0 = "questCount",
            });

            criterias.Add(13, new Criteria
            {
                TypeId = 13,
                TypeName = "DAMAGE_DONE",
                ReqValue0 = "count",
            });

            criterias.Add(14, new Criteria
            {
                TypeId = 14,
                TypeName = "COMPLETE_DAILY_QUEST",
                ReqValue0 = "questCount",
            });

            criterias.Add(15, new Criteria
            {
                TypeId = 15,
                TypeName = "COMPLETE_BATTLEGROUND",
                ReqType0 = "mapID",
            });

            criterias.Add(16, new Criteria
            {
                TypeId = 16,
                TypeName = "DEATH_AT_MAP",
                ReqType0 = "mapID",
            });

            criterias.Add(18, new Criteria
            {
                TypeId = 18,
                TypeName = "DEATH_IN_DUNGEON",
                ReqType0 = "manLimit",
            });

            criterias.Add(19, new Criteria
            {
                TypeId = 19,
                TypeName = "COMPLETE_RAID",
                ReqType0 = "groupSize",
            });

            criterias.Add(20, new Criteria
            {
                TypeId = 20,
                TypeName = "KILLED_BY_CREATURE",
                ReqType0 = "creatureEntry",
            });

            criterias.Add(24, new Criteria
            {
                TypeId = 24,
                TypeName = "FALL_WITHOUT_DYING",
                ReqValue0 = "fallHeight",
            });

            criterias.Add(26, new Criteria
            {
                TypeId = 26,
                TypeName = "DEATHS_FROM",
                ReqType0 = "type",
            });

            criterias.Add(27, new Criteria
            {
                TypeId = 27,
                TypeName = "COMPLETE_QUEST",
                ReqType0 = "questID",
                ReqValue0 = "questCount",
            });

            criterias.Add(28, new Criteria
            {
                TypeId = 28,
                TypeName = "BE_SPELL_TARGET",
                ReqType0 = "spellID",
                ReqValue0 = "spellCount",
            });

            criterias.Add(29, new Criteria
            {
                TypeId = 29,
                TypeName = "CAST_SPELL",
                ReqType0 = "spellID",
                ReqValue0 = "castCount",
            });

            criterias.Add(30, new Criteria
            {
                TypeId = 30,
                TypeName = "BG_OBJECTIVE_CAPTURE",
                ReqType0 = "objectiveId",
                ReqValue0 = "completeCount",
            });

            criterias.Add(31, new Criteria
            {
                TypeId = 31,
                TypeName = "HONORABLE_KILL_AT_AREA",
                ReqType0 = "areaID",
                ReqValue0 = "killCount",
            });

            criterias.Add(32, new Criteria
            {
                TypeId = 32,
                TypeName = "WIN_ARENA",
                ReqType0 = "mapID",
            });

            criterias.Add(33, new Criteria
            {
                TypeId = 33,
                TypeName = "PLAY_ARENA",
                ReqType0 = "mapID",
            });

            criterias.Add(34, new Criteria
            {
                TypeId = 34,
                TypeName = "LEARN_SPELL",
                ReqType0 = "spellID",
            });

            criterias.Add(36, new Criteria
            {
                TypeId = 36,
                TypeName = "OWN_ITEM",
                ReqType0 = "itemID",
                ReqValue0 = "itemCount",
            });

            criterias.Add(37, new Criteria
            {
                TypeId = 37,
                TypeName = "WIN_RATED_ARENA",
                ReqValue0 = "count",
                ReqType1 = "flag",
            });

            criterias.Add(38, new Criteria
            {
                TypeId = 38,
                TypeName = "HIGHEST_TEAM_RATING",
                ReqType0 = "teamtype",
            });

            criterias.Add(39, new Criteria
            {
                TypeId = 39,
                TypeName = "REACH_TEAM_RATING",
                ReqType0 = "teamtype",
                ReqValue0 = "PersonalRating",
            });

            criterias.Add(40, new Criteria
            {
                TypeId = 40,
                TypeName = "LEARN_SKILL_LEVEL",
                ReqType0 = "skillID",
                ReqValue0 = "skillLevel",
            });

            criterias.Add(41, new Criteria
            {
                TypeId = 41,
                TypeName = "USE_ITEM",
                ReqType0 = "itemID",
                ReqValue0 = "itemCount",
            });

            criterias.Add(42, new Criteria
            {
                TypeId = 42,
                TypeName = "LOOT_ITEM",
                ReqType0 = "itemID",
                ReqValue0 = "itemCount",
            });

            criterias.Add(43, new Criteria
            {
                TypeId = 43,
                TypeName = "EXPLORE_AREA",
                ReqType0 = "areaReference",
            });

            criterias.Add(44, new Criteria
            {
                TypeId = 44,
                TypeName = "OWN_RANK",
                ReqType0 = "rank",
            });

            criterias.Add(45, new Criteria
            {
                TypeId = 45,
                TypeName = "BUY_BANK_SLOT",
                ReqValue0 = "numberOfSlots",
            });

            criterias.Add(46, new Criteria
            {
                TypeId = 46,
                TypeName = "GAIN_REPUTATION",
                ReqType0 = "factionID",
                ReqValue0 = "reputationAmount",
            });

            criterias.Add(47, new Criteria
            {
                TypeId = 47,
                TypeName = "GAIN_EXALTED_REPUTATION",
                ReqValue0 = "numberOfExaltedFactions",
            });

            criterias.Add(48, new Criteria
            {
                TypeId = 48,
                TypeName = "VISIT_BARBER_SHOP",
                ReqValue0 = "numberOfVisits",
            });

            criterias.Add(49, new Criteria
            {
                TypeId = 49,
                TypeName = "EQUIP_EPIC_ITEM",
                ReqType0 = "itemSlot",
                ReqValue0 = "count",
            });

            criterias.Add(50, new Criteria
            {
                TypeId = 50,
                TypeName = "ROLL_NEED_ON_LOOT",
                ReqType0 = "rollValue",
                ReqValue0 = "count",
            });

            criterias.Add(51, new Criteria
            {
                TypeId = 51,
                TypeName = "ROLL_GREED_ON_LOOT",
                ReqType0 = "rollValue",
                ReqValue0 = "count",
            });

            criterias.Add(52, new Criteria
            {
                TypeId = 52,
                TypeName = "HK_CLASS",
                ReqType0 = "classID",
                ReqValue0 = "count",
            });

            criterias.Add(53, new Criteria
            {
                TypeId = 53,
                TypeName = "HK_RACE",
                ReqType0 = "raceID",
                ReqValue0 = "count",
            });

            criterias.Add(54, new Criteria
            {
                TypeId = 54,
                TypeName = "DO_EMOTE",
                ReqType0 = "emoteID",
                ReqValue0 = "count",
            });

            criterias.Add(55, new Criteria
            {
                TypeId = 55,
                TypeName = "HEALING_DONE",
                ReqValue0 = "count",
            });

            criterias.Add(56, new Criteria
            {
                TypeId = 56,
                TypeName = "GET_KILLING_BLOWS",
                ReqValue0 = "killCount",
                ReqType1 = "flag",
                ReqValue1 = "Map",
            });

            criterias.Add(57, new Criteria
            {
                TypeId = 57,
                TypeName = "EQUIP_ITEM",
                ReqType0 = "itemID",
                ReqValue0 = "count",
            });

            criterias.Add(59, new Criteria
            {
                TypeId = 59,
                TypeName = "UNK",
            });

            criterias.Add(62, new Criteria
            {
                TypeId = 62,
                TypeName = "MONEY_FROM_QUEST_REWARD",
                ReqValue0 = "goldInCopper",
            });

            criterias.Add(67, new Criteria
            {
                TypeId = 67,
                TypeName = "LOOT_MONEY",
                ReqValue0 = "goldInCopper",
            });

            criterias.Add(68, new Criteria
            {
                TypeId = 68,
                TypeName = "USE_GAMEOBJECT",
                ReqType0 = "goEntry",
                ReqValue0 = "useCount",
            });

            criterias.Add(69, new Criteria
            {
                TypeId = 69,
                TypeName = "BE_SPELL_TARGET2",
                ReqType0 = "spellID",
                ReqValue0 = "spellCount",
            });

            criterias.Add(70, new Criteria
            {
                TypeId = 70,
                TypeName = "SPECIAL_PVP_KILL",
                ReqValue0 = "killCount",
            });

            criterias.Add(72, new Criteria
            {
                TypeId = 72,
                TypeName = "FISH_IN_GAMEOBJECT",
                ReqType0 = "goEntry",
                ReqValue0 = "lootCount",
            });

            criterias.Add(74, new Criteria
            {
                TypeId = 74,
                TypeName = "UNK",
            });

            criterias.Add(75, new Criteria
            {
                TypeId = 75,
                TypeName = "LEARN_SKILLLINE_SPELLS",
                ReqType0 = "skillLine",
                ReqValue0 = "spellCount",
            });

            criterias.Add(76, new Criteria
            {
                TypeId = 76,
                TypeName = "WIN_DUEL",
                ReqValue0 = "duelCount",
            });

            criterias.Add(96, new Criteria
            {
                TypeId = 96,
                TypeName = "HIGHEST_POWER",
                ReqType0 = "powerType",
            });

            criterias.Add(97, new Criteria
            {
                TypeId = 97,
                TypeName = "HIGHEST_STAT",
                ReqType0 = "statType",
            });

            criterias.Add(98, new Criteria
            {
                TypeId = 98,
                TypeName = "HIGHEST_SPELLPOWER",
                ReqType0 = "spellSchool",
            });

            criterias.Add(100, new Criteria
            {
                TypeId = 100,
                TypeName = "HIGHEST_RATING",
                ReqType0 = "ratingType",
            });

            criterias.Add(109, new Criteria
            {
                TypeId = 109,
                TypeName = "LOOT_TYPE",
                ReqType0 = "lootType",
                ReqValue0 = "lootTypeCount",
            });

            criterias.Add(110, new Criteria
            {
                TypeId = 110,
                TypeName = "CAST_SPELL2",
                ReqType0 = "spellID",
                ReqValue0 = "castCount",
            });

            criterias.Add(112, new Criteria
            {
                TypeId = 112,
                TypeName = "LEARN_SKILL_LINE",
                ReqType0 = "skillLine",
                ReqValue0 = "spellCount",
            });

            criterias.Add(113, new Criteria
            {
                TypeId = 113,
                TypeName = "EARN_HONORABLE_KILL",
                ReqValue0 = "killCount",
            });

            criterias.Add(114, new Criteria
            {
                TypeId = 114,
                TypeName = "ACCEPTED_SUMMONS",
            });

            criterias.Add(115, new Criteria
            {
                TypeId = 115,
                TypeName = "ACHIVEMENTPOINTS_REACHED",
            });

            criterias.Add(119, new Criteria
            {
                TypeId = 119,
                TypeName = "RANDOM_DUNGEON_PLAYERCOUNT",
                ReqValue0 = "PlayerCount",
            });

            loaded = true;
        }
    }

    public class Criteria
    {
        public uint TypeId { get; set; }
        public string TypeName { get; set; }
        public string ReqType0 { get; set; }
        public string ReqValue0 { get; set; }
        public string ReqType1 { get; set; }
        public string ReqValue1 { get; set; }
        public string ReqType2 { get; set; }
        public string ReqValue2 { get; set; }

        public override string ToString()
        {
            return TypeName;
        }
    }
}
