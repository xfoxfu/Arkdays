/**
 * Possible domains discovered in game.
 * @version 1.5.01
 */
namespace ServerDomains {
  export const WebServer = "ak.local.arkdays.com";
  export const AccountServer = "as.local.arkdays.com";
  export const FileServer = "ak-fs.local.arkdays.com";
  export const GameServer = "ak-gs-gf.local.arkdays.com";
  export const ConfServer = "ak-conf.local.arkdays.com";
}

/**
 * Possible routes discovered in game.
 * @version 1.5.01
 */
namespace Routes {
  export const SDK_LOGIN_BY_PWD = "/user/login";
  export const SDK_AUTH = "/user/auth";
  export const SDK_PAY_CREATE_ORDER_APPSTORE = "/pay/createOrderAppstore";
  export const SDK_LEGACY_PAY_CONFIRM_ORDER_APPSTORE =
    "/pay/confirmOrderAppstore";
  export const SDK_PAY_CONFIRM_ORDER_APPSTORE = "/pay/confirmOrderAppstoreNew";
  export const SDK_SEND_SMS_CODE = "/user/sendSmsCode";
  export const SDK_USER_REGISTER = "/user/register";
  export const SDK_USER_IDENTITY_AUTH = "/user/authenticateUserIdentity";
  export const SDK_USER_CHECK_ID_CARD = "/user/checkIdCard";
  export const SDK_GUEST_CAPTCHA = "/captcha/v1/register";
  export const SDK_GUEST_LOGIN = "/user/v1/guestLogin";
  export const SDK_LOGIN_BY_SMS = "/user/loginBySmsCode";
  export const SDK_PING = "/online/v1/ping";
  export const SDK_LOGINOUT = "/online/v1/loginout";
  export const SDK_UPDATE_AGREEMENT = "/user/updateAgreement";
  export const SDK_CHANGE_PWD = "/user/changePassword";
  export const SDK_CHANGE_PHONE_CHECK = "/user/changePhoneCheck";
  export const SDK_CHANGE_PHONE = "/user/changePhone";
  export const LOGIN = "/account/login";
  export const SYNC_DATA = "/account/syncData";
  export const SYNC_STATUS = "/account/syncStatus";
  export const CHEAT = "/admin/cheat";
  export const VERSION = "/admin/getVersion";
  export const SQUAD_FORMATION = "/quest/squadFormation";
  export const SQUAD_RENAME = "/quest/changeSquadName";
  export const SQUAD_GET_ASSIST_LIST = "/quest/getAssistList";
  export const DEFAULT_BATTLE_START = "/quest/battleStart";
  export const DEFAULT_BATTLE_FINISH = "/quest/battleFinish";
  export const SAVE_BATTLE_REPLAY = "/quest/saveBattleReplay";
  export const LOAD_BATTLE_REPLAY = "/quest/getBattleReplay";
  export const FINISH_STORY_STAGE = "/quest/finishStoryStage";
  export const UNLOCK_STAGE_FOG = "/quest/unlockStageFog";
  export const GET_SPECIAL_STAGE_REWARD = "/quest/getCowLevelReward";
  export const CAMP_CONFIRM_BREAK_REWARD = "/campaignV2/getBreakReward";
  export const CAMP_GET_COMMON_MISSION_REWARD =
    "/campaignV2/getExMissionReward";
  export const CAMP_BATTLE_START = "/campaignV2/battleStart";
  export const CAMP_BATTLE_FINISH = "/campaignV2/battleFinish";
  export const RETRO_UNLOCK = "/retro/unlockRetroBlock";
  export const RUNE_BATTLE_START = "/rune/battleStart";
  export const RUNE_BATTLE_FINISH = "/rune/battleFinish";
  export const SET_DEFAULT_SKILL = "/charBuild/setDefaultSkill";
  export const UPGRADE_CHAR = "/charBuild/upgradeChar";
  export const EVOLVE_CHAR = "/charBuild/evolveChar";
  export const LOCK_CHAR = "/charBuild/lockChar";
  export const SELL_CHAR = "/charBuild/sellChar";
  export const BOOST_POTENTIAL = "/charBuild/boostPotential";
  export const UPGRADE_SKILL = "charBuild/upgradeSkill";
  export const UPGRADE_SPECIALIZATION = "charBuild/upgradeSpecialization";
  export const CONFIRM_SPECIALIZATION =
    "charBuild/completeUpgradeSpecialization";
  export const CHANGE_SKIN_SELECT = "charBuild/changeCharSkin";
  export const CHANGE_TEMPLATE_SELECT = "charBuild/changeCharTemplate";
  export const GET_SP_CHAR_MISSION_REWARD = "charBuild/getSpCharMissionReward";
  export const EVOLVE_CHAR_USE_ITEM = "/charBuild/evolveCharUseItem";
  export const FINISH_STORY = "/story/finishStory";
  export const CANCEL_NORMAL_GACHA = "/gacha/cancelNormalGacha";
  export const REFRESH_TAG_GACHA = "/gacha/refreshTags";
  export const SYNC_NORMAL_GACHA = "/gacha/syncNormalGacha";
  export const BUY_RECRUIT_SLOT = "/gacha/buyRecruitSlot";
  export const FINISH_NORMAL_GACHA = "/gacha/finishNormalGacha";
  export const NORMAL_GACHA = "/gacha/normalGacha";
  export const BOOST_NORMAL_GACHA = "/gacha/boostNormalGacha";
  export const GET_POOL_DETAIL = "/gacha/getPoolDetail";
  export const ADVANCED_GACHA = "/gacha/advancedGacha";
  export const TEN_ADVANCED_GACHA = "/gacha/tenAdvancedGacha";
  export const LIST_MAIL_BOX = "/mail/listMailBox";
  export const RECEIVE_MAIL = "/mail/receiveMail";
  export const MAIL_GET_METAINFO_LIST = "/mail/getMetaInfoList";
  export const RECEIVE_ALL_MAIL = "mail/receiveAllMail";
  export const REMOVE_ALL_RECEIVED_MAIL = "mail/removeAllReceivedMail";
  export const BIND_NICKNAME = "/user/bindNickName";
  export const BUY_AP = "/user/buyAp";
  export const DIAMOND_EXCHANGE = "/user/exchangeDiamondShard";
  export const CHANGE_RESUME = "user/changeResume";
  export const USE_ITEM = "/user/useItem";
  export const USE_ITEMS = "/user/useItems";
  export const USE_RENAME_CARD = "/user/useRenameCard";
  export const GET_VOUCHER_DETAIL = "/depot/getVoucherDetail";
  export const VOUCHER_GACHA = "/depot/voucherGacha";
  export const CHAR_GACHA_VOUCHER_DETAIL = "/depot/getCharGachaVoucherDetail";
  export const ITEM_GACHA_VOUCHER_DETAIL = "/depot/getMaterialVoucherDetail";
  export const CHAR_GACHA_VOUCHER = "/depot/useCharGachaVoucher";
  export const ITEM_GACHA_VOUCHER = "/depot/useMaterialVoucher";
  export const ACTIVITY_CHAIN = "/activity/getChainLogInReward";
  export const ACTIVITY_CHECKIN = "/activity/getOpenServerCheckInReward";
  export const ACTIVITY_CHAINFINAL = "/activity/getChainLogInFinalRewards";
  export const SOCIAL_FRIEND_DELETE = "/social/deleteFriend";
  export const SOCIAL_FRIEND_SEND_REQUEST = "/social/sendFriendRequest";
  export const SOCIAL_FRIEND_DEAL_REQUEST = "/social/processFriendRequest";
  export const SOCIAL_FRIEND_SEARCH_FRIEND = "/social/searchPlayer";
  export const SOCIAL_GET_SORT_FRIEND_INFO = "/social/getSortListInfo";
  export const SOCIAL_FRIEND_GET_FRIEND_LIST = "/social/getFriendList";
  export const SOCIAL_FRIEND_GET_FRIEND_REQUEST_LIST =
    "/social/getFriendRequestList";
  export const SOCIAL_FRIEND_SET_ASSIST_CHAR = "/social/setAssistCharList";
  export const SOCIAL_FRIEND_SET_FRIEND_ALIAS = "/social/setFriendAlias";
  export const SOCIAL_RECIEVE_SOCIRAL_POINT = "/social/receiveSocialPoint";
  export const SET_CARD_SHOW_MEDAL_REQUEST = "/social/setCardShowMedal";
  export const MEDAL_REWARD_REQUEST = "/medal/rewardMedal";
  export const MEDAL_SET_CUSTOM_DATA = "/medal/setCustomData";
  export const CHECKIN_HOME = "/user/checkIn";
  export const CHANGE_SECRETARY = "/user/changeSecretary";
  export const RECEIVE_TEAMCOLLECTION_REWARD =
    "/user/receiveTeamCollectionReward";
  export const UNLOCK_CHAR_WORD_STORY = "/charBuild/addonStory/unlock";
  export const BATTLE_START_ADDON = "charBuild/addonStage/battleStart";
  export const BATTLE_FINISH_ADDON = "charBuild/addonStage/battleFinish";
  export const MISSION_EXCHANGEMISSIONREWARDS =
    "/mission/exchangeMissionRewards";
  export const MISSION_CONFIRMMISSION = "mission/confirmMission";
  export const MISSION_CONFIRMMISSIONGROUP = "mission/confirmMissionGroup";
  export const SHOP_GET_FURNITURESHOP_LIST = "shop/getFurniGoodList";
  export const SHOP_BUY_FURNITURE_ITEM = "shop/buyFurniGood";
  export const SHOP_SKIN_LIST = "shop/getSkinGoodList";
  export const SHOP_CASH_LIST = "shop/getCashGoodList";
  export const SHOP_HIGH_QC_LIST = "shop/getHighGoodList";
  export const SHOP_LOW_QC_LIST = "shop/getLowGoodList";
  export const SHOP_EXTRA_QC_LIST = "shop/getExtraGoodList";
  export const SHOP_LMTGS_LIST = "shop/getLMTGSGoodList";
  export const SHOP_EPGS_LIST = "shop/getEPGSGoodList";
  export const SHOP_REP_LIST = "shop/getRepGoodList";
  export const SHOP_GP_LIST = "shop/getGPGoodList";
  export const SHOP_SOCIAL_LIST = "shop/getSocialGoodList";
  export const SHOP_PURCHASE_STATE = "shop/getGoodPurchaseState";
  export const SHOP_DECOMPOSE_POTENTIAL = "shop/decomposePotentialItem";
  export const SHOP_BUY_HIGH_GOOD = "shop/buyHighGood";
  export const SHOP_BUY_EXTRA_GOOD = "shop/buyExtraGood";
  export const SHOP_BUY_LOW_GOOD = "shop/buyLowGood";
  export const SHOP_BUY_GP_GOOD = "shop/buyGPGood";
  export const SHOP_BUY_SKIN_GOOD = "shop/buySkinGood";
  export const SHOP_FURN_GROUP_GOOD = "/shop/buyFurniGroup";
  export const SHOP_BUY_CASH_GOOD = "shop/buyCashGood";
  export const SHOP_BUY_SOCIAL_GOOD = "shop/buySocialGood";
  export const SHOP_GET_CASH_PURCHASE_RESULT = "shop/getCashGoodPurchaseResult";
  export const SHOP_BUY_LMTGS_GOOD = "shop/buyLMTGSGood";
  export const SHOP_BUY_EPGS_GOOD = "shop/buyEPGSGood";
  export const SHOP_BUY_REP_GOOD = "shop/buyRepGood";
  export const SHOP_GET_VOUCHER_SKIN_GOOD_LIST = "shop/getVoucherSkinGoodList";
  export const SHOP_USE_VOUCHER_SKIN = "shop/useVoucherSkin";
  export const TEMPLATE_SHOP_GET_GOOD_LIST = "templateShop/getGoodList";
  export const TEMPLATE_SHOP_BUY_GOOD = "templateShop/buyGood";
  export const CHANGE_AVATAR = "/user/changeAvatar";
  export const CRISIS_BATTLE_START = "crisis/battleStart";
  export const CRISIS_BATTLE_FINISH = "crisis/battleFinish";
  export const CRISIS_GET_INFO = "crisis/getInfo";
  export const CRISIS_GET_SHOP_INFO = "crisis/getGoodList";
  export const CRISIS_BUY_GOODS = "crisis/buyGoods";
  export const CRISIS_CHALLENGE_REWARD_TSK = "crisis/challengeRewardTask";
  export const CRISIS_CHALLENGE_REWARD_LEVEL = "crisis/challengeRewardPoint";
  export const CRISIS_CHALLENGE_REWARD_ALL = "crisis/challengeRewardAll";
  export const CRISIS_UNLOCK_MAP_REWARD_ALL = "crisis/unlockMapRank";
  export const CRISIS_UNLOCK_RUNE = "crisis/unlockRune";
  export const CRISIS_GET_ALL_ITEMS = "crisis/getAllItems";
  export const CHAR_BUILD_INC_INTIMACY = "building/gainIntimacy";
  export const CHAR_BUILD_INC_ASSIST_INTIMACY = "building/gainAssistIntimacy";
  export const CHAR_BUILD_ALL_INTIMACY = "building/gainAllIntimacy";
  export const SOCIAL_VISIT_BUILDING = "building/visitBuilding";
  export const BUILDING_UPGRADE_ROOM = "building/upgradeRoom";
  export const BUILDING_UPGRADE_COMPLETE_ROOM = "building/completeUpgradeRoom";
  export const BUILDING_SETTLE_MANUFACT = "building/settleManufacture";
  export const BUILDING_SYNC = "building/sync";
  export const BUILDING_BUILD_ROOM = "building/buildRoom";
  export const BUILDING_CLEAN_ROOM_SLOT = "building/cleanRoomSlot";
  export const BUILDING_VISIT_BUILDING = "building/visitBuilding";
  export const BUILDING_CHANGE_MANUF_FORMULA =
    "building/changeManufactureSolution";
  export const BUILDING_CHANGE_SHOP_FORUMULA = "building/changeSaleSolution";
  export const BUILDING_ASSIGN_CHAR = "building/assignChar";
  export const BUILDING_SETTLE_SALE = "building/settleSale";
  export const BUILDING_DEGRADE_ROOM = "building/degradeRoom";
  export const BUILDING_DEGRADE_DIY_ROOM = "building/upgradeDiyLevel";
  export const BUILDING_CHANGE_DIY_SOLUTION = "building/changeDiySolution";
  export const BUILDING_SAVE_DIY_PRESET_SOLUTION =
    "building/saveDiyPresetSolution";
  export const BUILDING_RENAME_DIY_PRESET_SOLUTION =
    "building/changePresetName";
  export const BUILDING_GET_DIY_PRESET_THUMBNAIL_URL =
    "building/getThumbnailUrl";
  export const BUILDING_UPDATE_SKILL = "building/upgradeSpecialization";
  export const BUILDING_FINISH_UPDATE_SKILL =
    "building/completeUpgradeSpecialization";
  export const BUILDING_WORKSHOP_SYNTHESIS = "building/workshopSynthesis";
  export const BUILDING_WORKSHOP_FURN_DECOMPOSITE =
    "building/workshopDecomposition";
  export const BUILDING_DELIVERY_ORDER = "building/deliveryOrder";
  export const BUILDING_CHANGE_STRATEGY = "building/changeStrategy";
  export const BUILDING_DELETE_ORDER = "building/deleteOrder";
  export const BUILDING_ACCELERATE_ORDER = "building/accelerateOrder";
  export const BUILDING_ACCELERATE_SOLUTION = "building/accelerateSolution";
  export const BUILDING_BUY_LABOR = "building/buyLabor";
  export const BUILDING_GET_ASSIST_REPORT = "building/getAssistReport";
  export const BUILDING_SET_ASSIST = "building/setBuildingAssist";
  export const BUILDING_DELETE_OWN_CLUE = "building/deleteOwnClue";
  export const BUILDING_DELETE_RECEIVE_CLUE = "building/deleteReceiveClue";
  export const BUILDING_PUT_CLUE_TO_THE_BOARD = "building/putClueToTheBoard";
  export const BUILDING_SEND_CLUE = "building/sendClue";
  export const BUILDING_GET_MEETING_ROOM_REWARD =
    "building/getMeetingroomReward";
  export const BUILDING_GET_CLUE_BOX = "building/getClueBox";
  export const BUILDING_RECEIVE_CLUE_TO_STOCK = "building/receiveClueToStock";
  export const BUILDING_START_INFO_SHARE = "building/startInfoShare";
  export const BUILDING_TAKE_CLUE_FROM_BOARD = "building/takeClueFromBoard";
  export const BUILDING_GET_INFO_SHARE_VISITOR_NUM =
    "building/getInfoShareVisitorsNum";
  export const BUILDING_RECEIVE_INFO_SHARE_REWARD =
    "building/getInfoShareReward";
  export const BUILDING_GET_RECENT_VISITOR = "building/getRecentVisitors";
  export const BUILDING_GET_DAILY_CLUE = "building/getDailyClue";
  export const BUILDING_BATCH_DELIVERY = "building/deliveryBatchOrder";
  export const STORY_REVIEW_UNLOCK = "storyreview/unlockStoryByCoin";
  export const STORY_REVIEW_READ = "storyreview/readStory";
  export const STORY_REVIEW_GET_REWARDS = "storyreview/rewardGroup";
  export const MARK_STORY_ACCE_KNOWN = "storyreview/markStoryAcceKnown";
  export const ROGUELIKE_SELECT_INITIAL_RELIC = "roguelike/chooseInitialRelic";
  export const ROGUELIKE_SELECT_INITIAL_CHOICE = "roguelike/chooseInitialScene";
  export const ROGUELIKE_SELECT_INITIAL_RECRUIT =
    "roguelike/chooseInitialRecruit";
  export const ROGUELIKE_MOVE_TO = "roguelike/moveTo";
  export const ROGUELIKE_FINISH_NODE = "roguelike/finishNode";
  export const ROGUELIKE_BUY_GOODS = "roguelike/buyGood";
  export const ROGUELIKE_SELECT_REWARD = "roguelike/selectReward";
  export const ROGUELIKE_SELECT_CHOICE = "roguelike/selectChoice";
  export const ROGUELIKE_ACTIVATE_TICKET = "roguelike/activeTicket";
  export const ROGUELIKE_RECRUIT_CHAR = "roguelike/recruitChar";
  export const ROGUELIKE_UPGRADE_CHAR = "roguelike/upgradeChar";
  export const ROGUELIKE_BATTLE_START = "roguelike/battleStart";
  export const ROGUELIKE_BATTLE_FINISH = "roguelike/battleEnd";
  export const PAY_CREATE_ORDER = "/pay/createOrder";
  export const PAY_CONFIRM_ORDER = "/pay/confirmOrder";
  export const PAY_GET_UNCONFIRMED_ORDER_LIST =
    "/pay/getUnconfirmedOrderIdList";
}
