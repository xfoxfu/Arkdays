using System.Collections.Generic;

namespace Torappu
{
    public class PlayerDataModel
    {
        public PlayerEvents events;

        public PlayerPushFlags pushFlags;

        public PlayerStatus status;

        public Dictionary<string, PlayerMonthlySubPer> monthlySub;

        public PlayerTroop troop;

        public PlayerDungeon dungeon;

        public PlayerCheckIn checkIn;

        public PlayerOpenServer openServer;

        public PlayerActivity activity;

        public PlayerDexNav dexNav;

        public PlayerSkins skin;

        public PlayerCollection collectionReward;

        public Dictionary<string, int> inventory;

        public Dictionary<string, Dictionary<int, PlayerConsumableItem>> consumable;

        public Dictionary<string, PlayerTicketItem> ticket;

        public PlayerShop shop;

        public Dictionary<string, PlayerTemplateShop> tshop;

        public PlayerRecruit recruit;

        public PlayerGacha gacha;

        public PlayerSocial social;

        public MissionPlayerData mission;

        public PlayerBuilding building;

        public PlayerCrisis crisis;
    }
}
