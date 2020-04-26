using System;
using System.Collections.Generic;
namespace Torappu
{
    public class BuildingData
    {
        public enum RoomCategory
        {
            NONE = 0,
            FUNCTION = 1,
            OUTPUT = 2,
            CUSTOM = 4,
            ELEVATOR = 8,
            CORRIDOR = 0x10,
            SPECIAL = 0x20,
            ALL = 0x3F
        }
        public static class RoomTypeString
        {
            public const string CONTROL = "CONTROL";
            public const string POWER = "POWER";
            public const string MANUFACTURE = "MANUFACTURE";
            public const string SHOP = "SHOP";
            public const string DORMITORY = "DORMITORY";
            public const string MEETING = "MEETING";
            public const string HIRE = "HIRE";
            public const string ELEVATOR = "ELEVATOR";
            public const string CORRIDOR = "CORRIDOR";
            public const string TRADING = "TRADING";
            public const string WORKSHOP = "WORKSHOP";
            public const string TRAINING = "TRAINING";
        }
        public enum RoomType
        {
            NONE = 0,
            CONTROL = 1,
            POWER = 2,
            MANUFACTURE = 4,
            SHOP = 8,
            DORMITORY = 0x10,
            MEETING = 0x20,
            HIRE = 0x40,
            ELEVATOR = 0x80,
            CORRIDOR = 0x100,
            TRADING = 0x200,
            WORKSHOP = 0x400,
            TRAINING = 0x800,
            FUNCTIONAL = 3710,
            ALL = 0xFFF
        }
        public enum OrderType
        {
            O_COMPOUND,
            O_GOLD,
            O_DIAMOND
        }
        public enum FurnitureCategory
        {
            FURNITURE,
            WALL,
            FLOOR
        }
        public enum FurnitureType
        {
            FLOOR,
            CARPET,
            SEATING,
            BEDDING,
            TABLE,
            CABINET,
            DECORATION,
            WALLPAPER,
            WALLDECO,
            WALLLAMP,
            CEILING,
            CEILINGLAMP
        }
        public interface IRoomBean
        {
        }
        public enum FurnitureLocation
        {
            NONE,
            WALL,
            FLOOR,
            CARPET,
            CEILING,
            POSTER,
            CEILINGDECAL
        }
        public struct ObstaclePoint
        {
            public GridPosition offset { get; set; }
            public byte edgeWalkableMask { get; set; }
        }
        public struct ObstacleRect
        {
            public GridPosition pos { get; set; }
            public GridPosition size { get; set; }
            public byte edgeWalkableMask { get; set; }
        }
        public class ObstacleData
        {
            public List<ObstaclePoint> floorObstacles { get; set; }
            public List<ObstaclePoint> backwallObstacles { get; set; }
        }
        public enum FormulaItemType
        {
            NONE,
            F_EVOLVE,
            F_BUILDING,
            F_GOLD,
            F_DIAMOND,
            F_FURNITURE,
            F_EXP,
            F_ASC,
            F_SKILL
        }
        public class PrefabInfo
        {
            public string id { get; set; }
            public string blueprintRoomOverrideId { get; set; }
            public GridPosition size { get; set; }
            public GridPosition floorGridSize { get; set; }
            public GridPosition backWallGridSize { get; set; }
            public string obstacleId { get; set; }
        }
        public class RoomUnlockCond
        {
            public class CondItem
            {
                public RoomType type { get; set; }
                public int level { get; set; }
                public int count { get; set; }
            }
            public string id { get; set; }
            public Dictionary<int, CondItem> number { get; set; }
        }
        public class RoomData
        {
            public class BuildCost
            {
                public ItemBundle[] items { get; set; }
                public long time { get; set; }
                public int labor { get; set; }
            }
            public class PhaseData
            {
                public string overrideName { get; set; }
                public string overridePrefabId { get; set; }
                public string unlockCondId { get; set; }
                public BuildCost buildCost { get; set; }
                public int electricity { get; set; }
                public int maxStationedNum { get; set; }
                public long manpowerCost { get; set; }
            }
            public RoomType id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string defaultPrefabId { get; set; }
            public bool canLevelDown { get; set; }
            public int maxCount { get; set; }
            public RoomCategory category { get; set; }
            public GridPosition size { get; set; }
            public PhaseData[] phases { get; set; }
        }
        public class LayoutData
        {
            public class RoomSlot
            {
                public string id { get; set; }
                public string cleanCostId { get; set; }
                public int costLabor { get; set; }
                public int provideLabor { get; set; }
                public GridPosition size { get; set; }
                public GridPosition offset { get; set; }
                public RoomCategory category { get; set; }
                public string storeyId { get; set; }
            }
            public class SlotCleanCost
            {
                public class CountCost
                {
                    public ItemBundle[] items { get; set; }
                }
                public string id { get; set; }
                public Dictionary<int, CountCost> number { get; set; }
            }
            public class StoreyData
            {
                public enum Type
                {
                    UPGROUND,
                    DOWNGROUND
                }
                public string id { get; set; }
                public int yOffset { get; set; }
                public int unlockControlLevel { get; set; }
                public Type type { get; set; }
            }
            public const string DEFAULT_LAYOUT_ID = "v0";
            public string id { get; set; }
            public Dictionary<string, RoomSlot> slots { get; set; }
            public Dictionary<string, SlotCleanCost> cleanCosts { get; set; }
            public Dictionary<string, StoreyData> storeys { get; set; }
        }
        public enum BuffCategory
        {
            NONE,
            FUNCTION,
            OUTPUT,
            RECOVERY
        }
        public class BuildingCharacter
        {
            public string charId { get; set; }
            public long maxManpower { get; set; }
            public List<BuildingBuffCharSlot> buffChar { get; set; }
        }
        public class BuildingBuffCharSlot
        {
            public class SlotItem
            {
                public string buffId { get; set; }
                public CharacterData.UnlockCondition cond { get; set; }
            }
            public List<SlotItem> buffData { get; set; }
        }
        public class BuildingBuff
        {
            public string buffId { get; set; }
            public string buffName { get; set; }
            public string buffIcon { get; set; }
            public string skillIcon { get; set; }
            public int sortId { get; set; }
            public string buffColor { get; set; }
            public string textColor { get; set; }
            public BuffCategory buffCategory { get; set; }
            public RoomType roomType { get; set; }
            public string description { get; set; }
        }
        public abstract class RoomBeanParam
        {
        }
        public class RoomBean<TParam> : IRoomBean where TParam : RoomBeanParam
        {
            public List<TParam> phases { get; set; }
        }
        public class ControlRoomBean : RoomBean<ControlRoomPhase>
        {
            public int basicCostBuff { get; set; }
        }
        public class ControlRoomPhase : RoomBeanParam
        {
        }
        public class ManufactRoomBean : RoomBean<ManufactPhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class ManufactPhase : RoomBeanParam
        {
            public float speed { get; set; }
            public int outputCapacity { get; set; }
        }
        public class ShopPhase : RoomBeanParam
        {
            public int counterNum { get; set; }
            public float speed { get; set; }
            public int moneyCapacity { get; set; }
        }
        public class HireRoomBean : RoomBean<HirePhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class HirePhase : RoomBeanParam
        {
            public float economizeRate { get; set; }
            public int resSpeed { get; set; }
            public int refreshTimes { get; set; }
        }
        public class DormPhase : RoomBeanParam
        {
            public int manpowerRecover { get; set; }
            public int decorationLimit { get; set; }
        }
        public class MeetingRoomBean : RoomBean<MeetingPhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class MeetingPhase : RoomBeanParam
        {
            public int friendSlotInc { get; set; }
            public int maxVisitorNum { get; set; }
            public int gatheringSpeed { get; set; }
        }
        public class TradingRoomBean : RoomBean<TradingPhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class TradingPhase : RoomBeanParam
        {
            public float orderSpeed { get; set; }
            public int orderLimit { get; set; }
            public int orderRarity { get; set; }
        }
        public class WorkshopPhase : RoomBeanParam
        {
            public float manpowerFactor { get; set; }
        }
        public class TrainingBean : RoomBean<TrainingPhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class TrainingPhase : RoomBeanParam
        {
            public int specSkillLvlLimit { get; set; }
        }
        public class PowerRoomBean : RoomBean<PowerPhase>
        {
            public float basicSpeedBuff { get; set; }
        }
        public class PowerPhase : RoomBeanParam
        {
        }
        public class CustomData
        {
            public class FurnitureData
            {
                public string id { get; set; }
                public string name { get; set; }
                public string iconId { get; set; }
                public FurnitureType type { get; set; }
                public FurnitureLocation location { get; set; }
                public FurnitureCategory category { get; set; }
                public int rarity { get; set; }
                public string themeId { get; set; }
                public int width { get; set; }
                public int depth { get; set; }
                public int height { get; set; }
                public int comfort { get; set; }
                public string usage { get; set; }
                public string description { get; set; }
                public string obtainApproach { get; set; }
                public string processedProductId { get; set; }
                public int processedProductCount { get; set; }
                public int processedByProductPercentage { get; set; }
                public List<WorkshopExtraWeightItem> processedByProductGroup { get; set; }
                public bool canBeDestroy { get; set; }
            }
            public class ThemeData
            {
                public string id { get; set; }
                public string name { get; set; }
                public string desc { get; set; }
                public List<ThemeQuickSetupItem> quickSetup { get; set; }
            }
            public class GroupData
            {
                public string id { get; set; }
                public string name { get; set; }
                public string themeId { get; set; }
                public int comfort { get; set; }
                public int count { get; set; }
                public List<string> furniture { get; set; }
            }
            public class ThemeQuickSetupItem
            {
                public string furnitureId { get; set; }
                public int pos0 { get; set; }
                public int pos1 { get; set; }
            }
            public class FurnitureTypeData
            {
                public FurnitureType type { get; set; }
                public string name { get; set; }
            }
            public class DormitoryDefaultFurnitureItem
            {
                public string furnitureId { get; set; }
                public int xOffset { get; set; }
                public int yOffset { get; set; }
                public string defaultPrefabId { get; set; }
            }
            public Dictionary<string, FurnitureData> furnitures { get; set; }
            public Dictionary<string, ThemeData> themes { get; set; }
            public Dictionary<string, GroupData> groups { get; set; }
            public Dictionary<string, FurnitureTypeData> types { get; set; }
            public Dictionary<string, List<DormitoryDefaultFurnitureItem>> defaultFurnitures { get; set; }
        }
        public class ManufactFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId { get; set; }
                public int roomLevel { get; set; }
                public int roomCount { get; set; }
            }
            public class UnlockStage
            {
                public string stageId { get; set; }
                public int rank { get; set; }
            }
            public string formulaId { get; set; }
            public string itemId { get; set; }
            public int count { get; set; }
            public int weight { get; set; }
            public long costPoint { get; set; }
            public FormulaItemType formulaType { get; set; }
            public string buffType { get; set; }
            public List<ItemBundle> costs { get; set; }
            public List<UnlockRoom> requireRooms { get; set; }
            public List<UnlockStage> requireStages { get; set; }
        }
        public class WorkshopExtraWeightItem
        {
            public int weight { get; set; }
            public string itemId { get; set; }
            public int itemCount { get; set; }
        }
        public class WorkshopFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId { get; set; }
                public int roomLevel { get; set; }
                public int roomCount { get; set; }
            }
            public class UnlockStage
            {
                public string stageId { get; set; }
                public int rank { get; set; }
            }
            public int sortId { get; set; }
            public string formulaId { get; set; }
            public int rarity { get; set; }
            public string itemId { get; set; }
            public int count { get; set; }
            public long goldCost { get; set; }
            public long apCost { get; set; }
            public FormulaItemType formulaType { get; set; }
            public string buffType { get; set; }
            public float extraOutcomeRate { get; set; }
            public List<WorkshopExtraWeightItem> extraOutcomeGroup { get; set; }
            public List<ItemBundle> costs { get; set; }
            public List<UnlockRoom> requireRooms { get; set; }
            public List<UnlockStage> requireStages { get; set; }
        }
        public class ShopFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId { get; set; }
                public int roomLevel { get; set; }
            }
            public string formulaId { get; set; }
            public string itemId { get; set; }
            public FormulaItemType formulaType { get; set; }
            public long costPoint { get; set; }
            public ItemBundle gainItem { get; set; }
            public List<UnlockRoom> requireRooms { get; set; }
        }
        public class CreditFormula
        {
            public class ValueModel
            {
                public int basic { get; set; }
                public int addition { get; set; }
            }
            public Dictionary<int, ValueModel> initiative { get; set; }
            public Dictionary<int, ValueModel> passive { get; set; }
        }
        public const string CONTROL_STOREY_ID = "1F";
        public string controlSlotId { get; set; }
        public string meetingSlotId { get; set; }
        public int initMaxLabor { get; set; }
        public int laborRecoverTime { get; set; }
        public int manufactInputCapacity { get; set; }
        public int shopCounterCapacity { get; set; }
        public int comfortLimit { get; set; }
        public int creditInitiativeLimit { get; set; }
        public int creditPassiveLimit { get; set; }
        public int creditComfortFactor { get; set; }
        public int creditGuaranteed { get; set; }
        public int creditCeiling { get; set; }
        public string manufactUnlockTips { get; set; }
        public string shopUnlockTips { get; set; }
        public float manufactStationBuff { get; set; }
        public int comfortManpowerRecoverFactor { get; set; }
        public int manpowerDisplayFactor { get; set; }
        public Dictionary<string, int> shopOutputRatio { get; set; }
        public Dictionary<string, int> shopStackRatio { get; set; }
        public int basicFavorPerDay { get; set; }
        public int humanResourceLimit { get; set; }
        public long tiredApThreshold { get; set; }
        public int processedCountRatio { get; set; }
        public int tradingStrategyUnlockLevel { get; set; }
        public int tradingReduceTimeUnit { get; set; }
        public int tradingLaborCostUnit { get; set; }
        public int manufactReduceTimeUnit { get; set; }
        public int manufactLaborCostUnit { get; set; }
        public int laborAssistUnlockLevel { get; set; }
        public int apToLaborUnlockLevel { get; set; }
        public int apToLaborRatio { get; set; }
        public int socialResourceLimit { get; set; }
        public int socialSlotNum { get; set; }
        public int furniDuplicationLimit { get; set; }
        public int[] manufactManpowerCostByNum { get; set; }
        public int[] tradingManpowerCostByNum { get; set; }
        public Dictionary<string, RoomUnlockCond> roomUnlockConds { get; set; }
        public Dictionary<string, RoomData> rooms { get; set; }
        public Dictionary<string, LayoutData> layouts { get; set; }
        public Dictionary<string, PrefabInfo> prefabs { get; set; }
        public ControlRoomBean controlData { get; set; }
        public ManufactRoomBean manufactData { get; set; }
        public RoomBean<ShopPhase> shopData { get; set; }
        public HireRoomBean hireData { get; set; }
        public RoomBean<DormPhase> dormData { get; set; }
        public MeetingRoomBean meetingData { get; set; }
        public TradingRoomBean tradingData { get; set; }
        public RoomBean<WorkshopPhase> workshopData { get; set; }
        public TrainingBean trainingData { get; set; }
        public PowerRoomBean powerData { get; set; }
        public Dictionary<string, BuildingCharacter> chars { get; set; }
        public Dictionary<string, BuildingBuff> buffs { get; set; }
        public CustomData customData { get; set; }
        public Dictionary<string, ManufactFormula> manufactFormulas { get; set; }
        public Dictionary<string, ShopFormula> shopFormulas { get; set; }
        public Dictionary<string, WorkshopFormula> workshopFormulas { get; set; }
        public CreditFormula creditFormula { get; set; }
        public Dictionary<string, int> goldItems { get; set; }
        public List<int> assistantUnlock { get; set; }
    }
}
