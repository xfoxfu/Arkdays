/**
 * Possible domains discovered in game.
 * @version 1.5.01
 */
export const ServerDomains = {
  WebServer: "ak.local.arkdays.com",
  AccountServer: "as.local.arkdays.com",
  FileServer: "ak-fs.local.arkdays.com",
  GameServer: "ak-gs-gf.local.arkdays.com",
  ConfServer: "ak-conf.local.arkdays.com",
};

/**
 * Possible routes discovered in game.
 * @version 1.5.01
 */
export const Routes = {
  SDK_LOGIN_BY_PWD: "/user/login",
  SDK_AUTH: "/user/auth",
  SDK_PAY_CREATE_ORDER_APPSTORE: "/pay/createOrderAppstore",
  SDK_LEGACY_PAY_CONFIRM_ORDER_APPSTORE: "/pay/confirmOrderAppstore",
  SDK_PAY_CONFIRM_ORDER_APPSTORE: "/pay/confirmOrderAppstoreNew",
  SDK_SEND_SMS_CODE: "/user/sendSmsCode",
  SDK_USER_REGISTER: "/user/register",
  SDK_USER_IDENTITY_AUTH: "/user/authenticateUserIdentity",
  SDK_USER_CHECK_ID_CARD: "/user/checkIdCard",
  SDK_GUEST_CAPTCHA: "/captcha/v1/register",
  SDK_GUEST_LOGIN: "/user/v1/guestLogin",
  SDK_LOGIN_BY_SMS: "/user/loginBySmsCode",
  SDK_PING: "/online/v1/ping",
  SDK_LOGINOUT: "/online/v1/loginout",
  SDK_UPDATE_AGREEMENT: "/user/updateAgreement",
  SDK_CHANGE_PWD: "/user/changePassword",
  SDK_CHANGE_PHONE_CHECK: "/user/changePhoneCheck",
  SDK_CHANGE_PHONE: "/user/changePhone",
  LOGIN: "/account/login",
  SYNC_DATA: "/account/syncData",
  SYNC_STATUS: "/account/syncStatus",
  CHEAT: "/admin/cheat",
  VERSION: "/admin/getVersion",
  SQUAD_FORMATION: "/quest/squadFormation",
  SQUAD_RENAME: "/quest/changeSquadName",
  SQUAD_GET_ASSIST_LIST: "/quest/getAssistList",
  DEFAULT_BATTLE_START: "/quest/battleStart",
  DEFAULT_BATTLE_FINISH: "/quest/battleFinish",
  SAVE_BATTLE_REPLAY: "/quest/saveBattleReplay",
  LOAD_BATTLE_REPLAY: "/quest/getBattleReplay",
  FINISH_STORY_STAGE: "/quest/finishStoryStage",
  UNLOCK_STAGE_FOG: "/quest/unlockStageFog",
  GET_SPECIAL_STAGE_REWARD: "/quest/getCowLevelReward",
  CAMP_CONFIRM_BREAK_REWARD: "/campaignV2/getBreakReward",
  CAMP_GET_COMMON_MISSION_REWARD: "/campaignV2/getExMissionReward",
  CAMP_BATTLE_START: "/campaignV2/battleStart",
  CAMP_BATTLE_FINISH: "/campaignV2/battleFinish",
  RETRO_UNLOCK: "/retro/unlockRetroBlock",
  RUNE_BATTLE_START: "/rune/battleStart",
  RUNE_BATTLE_FINISH: "/rune/battleFinish",
  SET_DEFAULT_SKILL: "/charBuild/setDefaultSkill",
  UPGRADE_CHAR: "/charBuild/upgradeChar",
  EVOLVE_CHAR: "/charBuild/evolveChar",
  LOCK_CHAR: "/charBuild/lockChar",
  SELL_CHAR: "/charBuild/sellChar",
  BOOST_POTENTIAL: "/charBuild/boostPotential",
  UPGRADE_SKILL: "charBuild/upgradeSkill",
  UPGRADE_SPECIALIZATION: "charBuild/upgradeSpecialization",
  CONFIRM_SPECIALIZATION: "charBuild/completeUpgradeSpecialization",
  CHANGE_SKIN_SELECT: "charBuild/changeCharSkin",
  CHANGE_TEMPLATE_SELECT: "charBuild/changeCharTemplate",
  GET_SP_CHAR_MISSION_REWARD: "charBuild/getSpCharMissionReward",
  EVOLVE_CHAR_USE_ITEM: "/charBuild/evolveCharUseItem",
  FINISH_STORY: "/story/finishStory",
  CANCEL_NORMAL_GACHA: "/gacha/cancelNormalGacha",
  REFRESH_TAG_GACHA: "/gacha/refreshTags",
  SYNC_NORMAL_GACHA: "/gacha/syncNormalGacha",
  BUY_RECRUIT_SLOT: "/gacha/buyRecruitSlot",
  FINISH_NORMAL_GACHA: "/gacha/finishNormalGacha",
  NORMAL_GACHA: "/gacha/normalGacha",
  BOOST_NORMAL_GACHA: "/gacha/boostNormalGacha",
  GET_POOL_DETAIL: "/gacha/getPoolDetail",
  ADVANCED_GACHA: "/gacha/advancedGacha",
  TEN_ADVANCED_GACHA: "/gacha/tenAdvancedGacha",
  LIST_MAIL_BOX: "/mail/listMailBox",
  RECEIVE_MAIL: "/mail/receiveMail",
  MAIL_GET_METAINFO_LIST: "/mail/getMetaInfoList",
  RECEIVE_ALL_MAIL: "mail/receiveAllMail",
  REMOVE_ALL_RECEIVED_MAIL: "mail/removeAllReceivedMail",
  BIND_NICKNAME: "/user/bindNickName",
  BUY_AP: "/user/buyAp",
  DIAMOND_EXCHANGE: "/user/exchangeDiamondShard",
  CHANGE_RESUME: "user/changeResume",
  USE_ITEM: "/user/useItem",
  USE_ITEMS: "/user/useItems",
  USE_RENAME_CARD: "/user/useRenameCard",
  GET_VOUCHER_DETAIL: "/depot/getVoucherDetail",
  VOUCHER_GACHA: "/depot/voucherGacha",
  CHAR_GACHA_VOUCHER_DETAIL: "/depot/getCharGachaVoucherDetail",
  ITEM_GACHA_VOUCHER_DETAIL: "/depot/getMaterialVoucherDetail",
  CHAR_GACHA_VOUCHER: "/depot/useCharGachaVoucher",
  ITEM_GACHA_VOUCHER: "/depot/useMaterialVoucher",
  ACTIVITY_CHAIN: "/activity/getChainLogInReward",
  ACTIVITY_CHECKIN: "/activity/getOpenServerCheckInReward",
  ACTIVITY_CHAINFINAL: "/activity/getChainLogInFinalRewards",
  SOCIAL_FRIEND_DELETE: "/social/deleteFriend",
  SOCIAL_FRIEND_SEND_REQUEST: "/social/sendFriendRequest",
  SOCIAL_FRIEND_DEAL_REQUEST: "/social/processFriendRequest",
  SOCIAL_FRIEND_SEARCH_FRIEND: "/social/searchPlayer",
  SOCIAL_GET_SORT_FRIEND_INFO: "/social/getSortListInfo",
  SOCIAL_FRIEND_GET_FRIEND_LIST: "/social/getFriendList",
  SOCIAL_FRIEND_GET_FRIEND_REQUEST_LIST: "/social/getFriendRequestList",
  SOCIAL_FRIEND_SET_ASSIST_CHAR: "/social/setAssistCharList",
  SOCIAL_FRIEND_SET_FRIEND_ALIAS: "/social/setFriendAlias",
  SOCIAL_RECIEVE_SOCIRAL_POINT: "/social/receiveSocialPoint",
  SET_CARD_SHOW_MEDAL_REQUEST: "/social/setCardShowMedal",
  MEDAL_REWARD_REQUEST: "/medal/rewardMedal",
  MEDAL_SET_CUSTOM_DATA: "/medal/setCustomData",
  CHECKIN_HOME: "/user/checkIn",
  CHANGE_SECRETARY: "/user/changeSecretary",
  RECEIVE_TEAMCOLLECTION_REWARD: "/user/receiveTeamCollectionReward",
  UNLOCK_CHAR_WORD_STORY: "/charBuild/addonStory/unlock",
  BATTLE_START_ADDON: "charBuild/addonStage/battleStart",
  BATTLE_FINISH_ADDON: "charBuild/addonStage/battleFinish",
  MISSION_EXCHANGEMISSIONREWARDS: "/mission/exchangeMissionRewards",
  MISSION_CONFIRMMISSION: "mission/confirmMission",
  MISSION_CONFIRMMISSIONGROUP: "mission/confirmMissionGroup",
  SHOP_GET_FURNITURESHOP_LIST: "shop/getFurniGoodList",
  SHOP_BUY_FURNITURE_ITEM: "shop/buyFurniGood",
  SHOP_SKIN_LIST: "shop/getSkinGoodList",
  SHOP_CASH_LIST: "shop/getCashGoodList",
  SHOP_HIGH_QC_LIST: "shop/getHighGoodList",
  SHOP_LOW_QC_LIST: "shop/getLowGoodList",
  SHOP_EXTRA_QC_LIST: "shop/getExtraGoodList",
  SHOP_LMTGS_LIST: "shop/getLMTGSGoodList",
  SHOP_EPGS_LIST: "shop/getEPGSGoodList",
  SHOP_REP_LIST: "shop/getRepGoodList",
  SHOP_GP_LIST: "shop/getGPGoodList",
  SHOP_SOCIAL_LIST: "shop/getSocialGoodList",
  SHOP_PURCHASE_STATE: "shop/getGoodPurchaseState",
  SHOP_DECOMPOSE_POTENTIAL: "shop/decomposePotentialItem",
  SHOP_BUY_HIGH_GOOD: "shop/buyHighGood",
  SHOP_BUY_EXTRA_GOOD: "shop/buyExtraGood",
  SHOP_BUY_LOW_GOOD: "shop/buyLowGood",
  SHOP_BUY_GP_GOOD: "shop/buyGPGood",
  SHOP_BUY_SKIN_GOOD: "shop/buySkinGood",
  SHOP_FURN_GROUP_GOOD: "/shop/buyFurniGroup",
  SHOP_BUY_CASH_GOOD: "shop/buyCashGood",
  SHOP_BUY_SOCIAL_GOOD: "shop/buySocialGood",
  SHOP_GET_CASH_PURCHASE_RESULT: "shop/getCashGoodPurchaseResult",
  SHOP_BUY_LMTGS_GOOD: "shop/buyLMTGSGood",
  SHOP_BUY_EPGS_GOOD: "shop/buyEPGSGood",
  SHOP_BUY_REP_GOOD: "shop/buyRepGood",
  SHOP_GET_VOUCHER_SKIN_GOOD_LIST: "shop/getVoucherSkinGoodList",
  SHOP_USE_VOUCHER_SKIN: "shop/useVoucherSkin",
  TEMPLATE_SHOP_GET_GOOD_LIST: "templateShop/getGoodList",
  TEMPLATE_SHOP_BUY_GOOD: "templateShop/buyGood",
  CHANGE_AVATAR: "/user/changeAvatar",
  CRISIS_BATTLE_START: "crisis/battleStart",
  CRISIS_BATTLE_FINISH: "crisis/battleFinish",
  CRISIS_GET_INFO: "crisis/getInfo",
  CRISIS_GET_SHOP_INFO: "crisis/getGoodList",
  CRISIS_BUY_GOODS: "crisis/buyGoods",
  CRISIS_CHALLENGE_REWARD_TSK: "crisis/challengeRewardTask",
  CRISIS_CHALLENGE_REWARD_LEVEL: "crisis/challengeRewardPoint",
  CRISIS_CHALLENGE_REWARD_ALL: "crisis/challengeRewardAll",
  CRISIS_UNLOCK_MAP_REWARD_ALL: "crisis/unlockMapRank",
  CRISIS_UNLOCK_RUNE: "crisis/unlockRune",
  CRISIS_GET_ALL_ITEMS: "crisis/getAllItems",
  CHAR_BUILD_INC_INTIMACY: "building/gainIntimacy",
  CHAR_BUILD_INC_ASSIST_INTIMACY: "building/gainAssistIntimacy",
  CHAR_BUILD_ALL_INTIMACY: "building/gainAllIntimacy",
  SOCIAL_VISIT_BUILDING: "building/visitBuilding",
  BUILDING_UPGRADE_ROOM: "building/upgradeRoom",
  BUILDING_UPGRADE_COMPLETE_ROOM: "building/completeUpgradeRoom",
  BUILDING_SETTLE_MANUFACT: "building/settleManufacture",
  BUILDING_SYNC: "building/sync",
  BUILDING_BUILD_ROOM: "building/buildRoom",
  BUILDING_CLEAN_ROOM_SLOT: "building/cleanRoomSlot",
  BUILDING_VISIT_BUILDING: "building/visitBuilding",
  BUILDING_CHANGE_MANUF_FORMULA: "building/changeManufactureSolution",
  BUILDING_CHANGE_SHOP_FORUMULA: "building/changeSaleSolution",
  BUILDING_ASSIGN_CHAR: "building/assignChar",
  BUILDING_SETTLE_SALE: "building/settleSale",
  BUILDING_DEGRADE_ROOM: "building/degradeRoom",
  BUILDING_DEGRADE_DIY_ROOM: "building/upgradeDiyLevel",
  BUILDING_CHANGE_DIY_SOLUTION: "building/changeDiySolution",
  BUILDING_SAVE_DIY_PRESET_SOLUTION: "building/saveDiyPresetSolution",
  BUILDING_RENAME_DIY_PRESET_SOLUTION: "building/changePresetName",
  BUILDING_GET_DIY_PRESET_THUMBNAIL_URL: "building/getThumbnailUrl",
  BUILDING_UPDATE_SKILL: "building/upgradeSpecialization",
  BUILDING_FINISH_UPDATE_SKILL: "building/completeUpgradeSpecialization",
  BUILDING_WORKSHOP_SYNTHESIS: "building/workshopSynthesis",
  BUILDING_WORKSHOP_FURN_DECOMPOSITE: "building/workshopDecomposition",
  BUILDING_DELIVERY_ORDER: "building/deliveryOrder",
  BUILDING_CHANGE_STRATEGY: "building/changeStrategy",
  BUILDING_DELETE_ORDER: "building/deleteOrder",
  BUILDING_ACCELERATE_ORDER: "building/accelerateOrder",
  BUILDING_ACCELERATE_SOLUTION: "building/accelerateSolution",
  BUILDING_BUY_LABOR: "building/buyLabor",
  BUILDING_GET_ASSIST_REPORT: "building/getAssistReport",
  BUILDING_SET_ASSIST: "building/setBuildingAssist",
  BUILDING_DELETE_OWN_CLUE: "building/deleteOwnClue",
  BUILDING_DELETE_RECEIVE_CLUE: "building/deleteReceiveClue",
  BUILDING_PUT_CLUE_TO_THE_BOARD: "building/putClueToTheBoard",
  BUILDING_SEND_CLUE: "building/sendClue",
  BUILDING_GET_MEETING_ROOM_REWARD: "building/getMeetingroomReward",
  BUILDING_GET_CLUE_BOX: "building/getClueBox",
  BUILDING_RECEIVE_CLUE_TO_STOCK: "building/receiveClueToStock",
  BUILDING_START_INFO_SHARE: "building/startInfoShare",
  BUILDING_TAKE_CLUE_FROM_BOARD: "building/takeClueFromBoard",
  BUILDING_GET_INFO_SHARE_VISITOR_NUM: "building/getInfoShareVisitorsNum",
  BUILDING_RECEIVE_INFO_SHARE_REWARD: "building/getInfoShareReward",
  BUILDING_GET_RECENT_VISITOR: "building/getRecentVisitors",
  BUILDING_GET_DAILY_CLUE: "building/getDailyClue",
  BUILDING_BATCH_DELIVERY: "building/deliveryBatchOrder",
  STORY_REVIEW_UNLOCK: "storyreview/unlockStoryByCoin",
  STORY_REVIEW_READ: "storyreview/readStory",
  STORY_REVIEW_GET_REWARDS: "storyreview/rewardGroup",
  MARK_STORY_ACCE_KNOWN: "storyreview/markStoryAcceKnown",
  ROGUELIKE_SELECT_INITIAL_RELIC: "roguelike/chooseInitialRelic",
  ROGUELIKE_SELECT_INITIAL_CHOICE: "roguelike/chooseInitialScene",
  ROGUELIKE_SELECT_INITIAL_RECRUIT: "roguelike/chooseInitialRecruit",
  ROGUELIKE_MOVE_TO: "roguelike/moveTo",
  ROGUELIKE_FINISH_NODE: "roguelike/finishNode",
  ROGUELIKE_BUY_GOODS: "roguelike/buyGood",
  ROGUELIKE_SELECT_REWARD: "roguelike/selectReward",
  ROGUELIKE_SELECT_CHOICE: "roguelike/selectChoice",
  ROGUELIKE_ACTIVATE_TICKET: "roguelike/activeTicket",
  ROGUELIKE_RECRUIT_CHAR: "roguelike/recruitChar",
  ROGUELIKE_UPGRADE_CHAR: "roguelike/upgradeChar",
  ROGUELIKE_BATTLE_START: "roguelike/battleStart",
  ROGUELIKE_BATTLE_FINISH: "roguelike/battleEnd",
  PAY_CREATE_ORDER: "/pay/createOrder",
  PAY_CONFIRM_ORDER: "/pay/confirmOrder",
  PAY_GET_UNCONFIRMED_ORDER_LIST: "/pay/getUnconfirmedOrderIdList",
};
