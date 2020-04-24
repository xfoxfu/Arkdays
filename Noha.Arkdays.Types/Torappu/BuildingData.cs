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
            object GetPhaseParam(int phase);
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
            public GridPosition offset;

            public byte edgeWalkableMask;
        }

        public struct ObstacleRect
        {
            public GridPosition pos;

            public GridPosition size;

            public byte edgeWalkableMask;
        }

        public class ObstacleData
        {
            public List<ObstaclePoint> floorObstacles;

            public List<ObstaclePoint> backwallObstacles;

            public ObstacleData()
            {
            }
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
            public string id;

            public string blueprintRoomOverrideId;

            public GridPosition size;

            public GridPosition floorGridSize;

            public GridPosition backWallGridSize;

            public string obstacleId;

            public PrefabInfo()
            {
            }
        }

        public class RoomUnlockCond
        {
            public class CondItem
            {
                public RoomType type;

                public int level;

                public int count;

                public CondItem()
                {
                }
            }

            public string id;

            public Dictionary<int, CondItem> number;

            public RoomUnlockCond()
            {
            }
        }

        public class RoomData
        {
            public class BuildCost
            {
                public ItemBundle[] items;

                public long time;

                public int labor;

                public BuildCost()
                {
                }
            }

            public class PhaseData
            {
                public string overrideName;

                public string overridePrefabId;

                public string unlockCondId;

                public BuildCost buildCost;

                public int electricity;

                public int maxStationedNum;

                public long manpowerCost;

                public PhaseData()
                {
                }
            }

            public RoomType id;

            public string name;

            public string description;

            public string defaultPrefabId;

            public bool canLevelDown;

            public int maxCount;

            public RoomCategory category;

            public GridPosition size;

            public PhaseData[] phases;

            public RoomData()
            {
            }
        }

        public class LayoutData
        {
            public class RoomSlot
            {
                public string id;

                public string cleanCostId;

                public int costLabor;

                public int provideLabor;

                public GridPosition size;

                public GridPosition offset;

                public RoomCategory category;

                public string storeyId;

                public RoomSlot()
                {
                }
            }

            public class SlotCleanCost
            {
                public class CountCost
                {
                    public ItemBundle[] items;

                    public CountCost()
                    {
                    }
                }

                public string id;

                public Dictionary<int, CountCost> number;

                public SlotCleanCost()
                {
                }
            }

            public class StoreyData
            {
                public enum Type
                {
                    UPGROUND,
                    DOWNGROUND
                }

                public string id;

                public int yOffset;

                public int unlockControlLevel;

                public Type type;

                public StoreyData()
                {
                }
            }

            public const string DEFAULT_LAYOUT_ID = "v0";

            public string id;

            public Dictionary<string, RoomSlot> slots;

            public Dictionary<string, SlotCleanCost> cleanCosts;

            public Dictionary<string, StoreyData> storeys;

            public LayoutData()
            {
            }
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
            public string charId;

            public long maxManpower;

            public List<BuildingBuffCharSlot> buffChar;

            public BuildingCharacter()
            {
            }
        }

        public class BuildingBuffCharSlot
        {
            public class SlotItem
            {
                public string buffId;

                public CharacterData.UnlockCondition cond;

                public SlotItem()
                {
                }
            }

            public List<SlotItem> buffData;

            public BuildingBuffCharSlot()
            {
            }
        }

        public class BuildingBuff
        {
            public string buffId;

            public string buffName;

            public string buffIcon;

            public string skillIcon;

            public int sortId;

            public string buffColor;

            public string textColor;

            public BuffCategory buffCategory;

            public RoomType roomType;

            public string description;

            public BuildingBuff()
            {
            }
        }

        public abstract class RoomBeanParam
        {
            protected RoomBeanParam()
            {
            }
        }

        public class RoomBean<TParam> : IRoomBean where TParam : RoomBeanParam
        {
            public List<TParam> phases;

            public RoomBean()
            {
            }

            public object GetPhaseParam(int level)
            {
                return null;
            }
        }

        public class ControlRoomBean : RoomBean<ControlRoomPhase>
        {
            public int basicCostBuff;

            public ControlRoomBean()
            {
            }
        }

        public class ControlRoomPhase : RoomBeanParam
        {
            public ControlRoomPhase()
            {
            }
        }

        public class ManufactRoomBean : RoomBean<ManufactPhase>
        {
            public float basicSpeedBuff;

            public ManufactRoomBean()
            {
            }
        }

        public class ManufactPhase : RoomBeanParam
        {
            public float speed;

            public int outputCapacity;

            public ManufactPhase()
            {
            }
        }

        public class ShopPhase : RoomBeanParam
        {
            public int counterNum;

            public float speed;

            public int moneyCapacity;

            public ShopPhase()
            {
            }
        }

        public class HireRoomBean : RoomBean<HirePhase>
        {
            public float basicSpeedBuff;

            public HireRoomBean()
            {
            }
        }

        public class HirePhase : RoomBeanParam
        {
            public float economizeRate;

            public int resSpeed;

            public int refreshTimes;

            public HirePhase()
            {
            }
        }

        public class DormPhase : RoomBeanParam
        {
            public int manpowerRecover;

            public int decorationLimit;

            public DormPhase()
            {
            }
        }

        public class MeetingRoomBean : RoomBean<MeetingPhase>
        {
            public float basicSpeedBuff;

            public MeetingRoomBean()
            {
            }
        }

        public class MeetingPhase : RoomBeanParam
        {
            public int friendSlotInc;

            public int maxVisitorNum;

            public int gatheringSpeed;

            public MeetingPhase()
            {
            }
        }

        public class TradingRoomBean : RoomBean<TradingPhase>
        {
            public float basicSpeedBuff;

            public TradingRoomBean()
            {
            }
        }

        public class TradingPhase : RoomBeanParam
        {
            public float orderSpeed;

            public int orderLimit;

            public int orderRarity;

            public TradingPhase()
            {
            }
        }

        public class WorkshopPhase : RoomBeanParam
        {
            public float manpowerFactor;

            public WorkshopPhase()
            {
            }
        }

        public class TrainingBean : RoomBean<TrainingPhase>
        {
            public float basicSpeedBuff;

            public TrainingBean()
            {
            }
        }

        public class TrainingPhase : RoomBeanParam
        {
            public int specSkillLvlLimit;

            public TrainingPhase()
            {
            }
        }

        public class PowerRoomBean : RoomBean<PowerPhase>
        {
            public float basicSpeedBuff;

            public PowerRoomBean()
            {
            }
        }

        public class PowerPhase : RoomBeanParam
        {
            public PowerPhase()
            {
            }
        }

        public class CustomData
        {
            public class FurnitureData
            {
                public string id;

                public string name;

                public string iconId;

                public FurnitureType type;

                public FurnitureLocation location;

                public FurnitureCategory category;

                public int rarity;

                public string themeId;

                public int width;

                public int depth;

                public int height;

                public int comfort;

                public string usage;

                public string description;

                public string obtainApproach;

                public string processedProductId;

                public int processedProductCount;

                public int processedByProductPercentage;

                public List<WorkshopExtraWeightItem> processedByProductGroup;

                public bool canBeDestroy;

                public FurnitureData()
                {
                }
            }

            public class ThemeData
            {
                public string id;

                public string name;

                public string desc;

                public List<ThemeQuickSetupItem> quickSetup;

                public ThemeData()
                {
                }
            }

            public class GroupData
            {
                public string id;

                public string name;

                public string themeId;

                public int comfort;

                public int count;

                public List<string> furniture;

                public GroupData()
                {
                }
            }

            public class ThemeQuickSetupItem
            {
                public string furnitureId;

                public int pos0;

                public int pos1;

                public ThemeQuickSetupItem()
                {
                }
            }

            public class FurnitureTypeData
            {
                public FurnitureType type;

                public string name;

                public FurnitureTypeData()
                {
                }
            }

            public class DormitoryDefaultFurnitureItem
            {
                public string furnitureId;

                public int xOffset;

                public int yOffset;

                public string defaultPrefabId;

                public DormitoryDefaultFurnitureItem()
                {
                }
            }

            public Dictionary<string, FurnitureData> furnitures;

            public Dictionary<string, ThemeData> themes;

            public Dictionary<string, GroupData> groups;

            public Dictionary<string, FurnitureTypeData> types;

            public Dictionary<string, List<DormitoryDefaultFurnitureItem>> defaultFurnitures;

            public CustomData()
            {
            }
        }

        public class ManufactFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId;

                public int roomLevel;

                public int roomCount;

                public UnlockRoom()
                {
                }
            }

            public class UnlockStage
            {
                public string stageId;

                public int rank;

                public UnlockStage()
                {
                }
            }

            public string formulaId;

            public string itemId;

            public int count;

            public int weight;

            public long costPoint;

            public FormulaItemType formulaType;

            public string buffType;

            public List<ItemBundle> costs;

            public List<UnlockRoom> requireRooms;

            public List<UnlockStage> requireStages;

            public ManufactFormula()
            {
            }
        }

        public class WorkshopExtraWeightItem
        {
            public int weight;

            public string itemId;

            public int itemCount;

            public WorkshopExtraWeightItem()
            {
            }
        }

        public class WorkshopFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId;

                public int roomLevel;

                public int roomCount;

                public UnlockRoom()
                {
                }
            }

            public class UnlockStage
            {
                public string stageId;

                public int rank;

                public UnlockStage()
                {
                }
            }

            public int sortId;

            public string formulaId;

            public int rarity;

            public string itemId;

            public int count;

            public long goldCost;

            public long apCost;

            public FormulaItemType formulaType;

            public string buffType;

            public float extraOutcomeRate;

            public List<WorkshopExtraWeightItem> extraOutcomeGroup;

            public List<ItemBundle> costs;

            public List<UnlockRoom> requireRooms;

            public List<UnlockStage> requireStages;

            public WorkshopFormula()
            {
            }
        }

        public class ShopFormula
        {
            public class UnlockRoom
            {
                public RoomType roomId;

                public int roomLevel;

                public UnlockRoom()
                {
                }
            }

            public string formulaId;

            public string itemId;

            public FormulaItemType formulaType;

            public long costPoint;

            public ItemBundle gainItem;

            public List<UnlockRoom> requireRooms;

            public ShopFormula()
            {
            }
        }

        public class CreditFormula
        {
            public class ValueModel
            {
                public int basic;

                public int addition;

                public ValueModel()
                {
                }
            }

            public Dictionary<int, ValueModel> initiative;

            public Dictionary<int, ValueModel> passive;

            public CreditFormula()
            {
            }
        }

        public const string CONTROL_STOREY_ID = "1F";

        public string controlSlotId;

        public string meetingSlotId;

        public int initMaxLabor;

        public int laborRecoverTime;

        public int manufactInputCapacity;

        public int shopCounterCapacity;

        public int comfortLimit;

        public int creditInitiativeLimit;

        public int creditPassiveLimit;

        public int creditComfortFactor;

        public int creditGuaranteed;

        public int creditCeiling;

        public string manufactUnlockTips;

        public string shopUnlockTips;

        public float manufactStationBuff;

        public int comfortManpowerRecoverFactor;

        public int manpowerDisplayFactor;

        public Dictionary<string, int> shopOutputRatio;

        public Dictionary<string, int> shopStackRatio;

        public int basicFavorPerDay;

        public int humanResourceLimit;

        public long tiredApThreshold;

        public int processedCountRatio;

        public int tradingStrategyUnlockLevel;

        public int tradingReduceTimeUnit;

        public int tradingLaborCostUnit;

        public int manufactReduceTimeUnit;

        public int manufactLaborCostUnit;

        public int laborAssistUnlockLevel;

        public int apToLaborUnlockLevel;

        public int apToLaborRatio;

        public int socialResourceLimit;

        public int socialSlotNum;

        public int furniDuplicationLimit;

        public int[] manufactManpowerCostByNum;

        public int[] tradingManpowerCostByNum;

        public Dictionary<string, RoomUnlockCond> roomUnlockConds;

        public Dictionary<string, RoomData> rooms;

        public Dictionary<string, LayoutData> layouts;

        public Dictionary<string, PrefabInfo> prefabs;

        public ControlRoomBean controlData;

        public ManufactRoomBean manufactData;

        public RoomBean<ShopPhase> shopData;

        public HireRoomBean hireData;

        public RoomBean<DormPhase> dormData;

        public MeetingRoomBean meetingData;

        public TradingRoomBean tradingData;

        public RoomBean<WorkshopPhase> workshopData;

        public TrainingBean trainingData;

        public PowerRoomBean powerData;

        public Dictionary<string, BuildingCharacter> chars;

        public Dictionary<string, BuildingBuff> buffs;

        public CustomData customData;

        public Dictionary<string, ManufactFormula> manufactFormulas;

        public Dictionary<string, ShopFormula> shopFormulas;

        public Dictionary<string, WorkshopFormula> workshopFormulas;

        public CreditFormula creditFormula;

        public Dictionary<string, int> goldItems;

        public List<int> assistantUnlock;

        public BuildingData()
        {
        }
    }
}
