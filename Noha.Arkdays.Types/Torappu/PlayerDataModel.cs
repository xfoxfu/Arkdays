using System.Collections.Generic;

namespace Torappu
{
    public class PlayerDataModel
    {
        public PlayerEvents events { get; set; }

        public PlayerPushFlags pushFlags { get; set; }

        public PlayerStatus status { get; set; }

        public Dictionary<string, PlayerMonthlySubPer> monthlySub { get; set; }

        public PlayerTroop troop { get; set; }

        public PlayerDungeon dungeon { get; set; }

        public PlayerCheckIn checkIn { get; set; }

        public PlayerOpenServer openServer { get; set; }

        public PlayerActivity activity { get; set; }

        public PlayerDexNav dexNav { get; set; }

        public PlayerSkins skin { get; set; }

        public PlayerCollection collectionReward { get; set; }

        public Dictionary<string, int> inventory { get; set; }

        public Dictionary<string, Dictionary<int, PlayerConsumableItem>> consumable { get; set; }

        public Dictionary<string, PlayerTicketItem> ticket { get; set; }

        public PlayerShop shop { get; set; }

        public Dictionary<string, PlayerTemplateShop> tshop { get; set; }

        public PlayerRecruit recruit { get; set; }

        public PlayerGacha gacha { get; set; }

        public PlayerSocial social { get; set; }

        public MissionPlayerData mission { get; set; }

        public PlayerBuilding building { get; set; }

        public PlayerCrisis crisis { get; set; }
    }
}
