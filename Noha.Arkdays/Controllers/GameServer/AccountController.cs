using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;
using Noha.Arkdays.Services;
using System.Linq;
using System;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("account")]
    public class AccountController : ControllerBase
    {
        private readonly ITableHolder<SyncDataResponse> _syncDataHolder;
        private readonly ITableHolder<CharacterDB> _charDbHolder;
        private readonly ITableHolder<StoryDB> _storyDbHolder;
        private readonly ITableHolder<SkinTable> _skinTableHolder;
        private readonly ITableHolder<StageTable> _stageTableHolder;
        private readonly ITableHolder<ZoneTable> _zoneTableHolder;

        public AccountController(
            ITableHolder<SyncDataResponse> syncDataHolder,
            ITableHolder<CharacterDB> charDbHolder,
            ITableHolder<StoryDB> storyDbHolder,
            ITableHolder<SkinTable> skinTableHolder,
            ITableHolder<ZoneTable> zoneTableHolder,
            ITableHolder<StageTable> stageTableHolder)
        {
            _syncDataHolder = syncDataHolder;
            _charDbHolder = charDbHolder;
            _storyDbHolder = storyDbHolder;
            _skinTableHolder = skinTableHolder;
            _zoneTableHolder = zoneTableHolder;
            _stageTableHolder = stageTableHolder;
        }

        [HttpPost("login")]
        public LoginResponse Login([FromBody] LoginRequestV002 req)
        {
            return new LoginResponse
            {
                result = 0,
                uid = "112165182",
                secret = "In7aw+5mJsaYTYBvgeszDABHS2U8nfK7",
                serviceLicenseVersion = 0,
                playerDataDelta = new PlayerDataDelta(),
            };
        }

        [HttpPost("syncData")]
        public SyncDataResponse SyncData([FromBody] SyncDataRequest req)
        {
            _syncDataHolder.Value.user.status.flags = _storyDbHolder.Value
                .Select(kv => (kv.Key, 1))
                .ToDictionary(kv => kv.Key, kv => kv.Item2);
            _syncDataHolder.Value.user.dungeon.stages = _stageTableHolder.Value.stages
                .Select(s => new PlayerStage
                {
                    stageId = s.Value.stageId,
                    completeTimes = 1,
                    state = PlayerStageState.COMPLETE,
                    hasBattleReplay = false,
                    noCostCnt = 1,
                })
                .ToDictionary(kv => kv.stageId);
            _syncDataHolder.Value.user.dungeon.zones = _zoneTableHolder.Value.zones
                .Select(s => (s.Key, new PlayerZone
                {
                    completeTimes = 1
                }))
                .ToDictionary(kv => kv.Key, kv => kv.Item2);
            _syncDataHolder.Value.user.dungeon.campaigns = new PlayerCampaign
            {
                campaignCurrentFee = 1800,
                campaignTotalFee = 1800,
                activeGroupId = _stageTableHolder.Value.campaignGroups.LastOrDefault().Value.groupId,
                instances = _stageTableHolder.Value.campaigns
                    .ToDictionary(v => v.Key, v => new PlayerCampaign.Instance
                    {
                        maxKills = 400,
                        rewardStatus = new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                    })
            };
            int instId = 1;
            int value = 1;
            _syncDataHolder.Value.user.skin.characterSkins = _skinTableHolder.Value.charSkins
                .Where(s => s.Value.isBuyAble == true)
                .ToDictionary(kv => kv.Value.skinId, kv => 1);
            _syncDataHolder.Value.user.troop = new PlayerTroop
            {
                troopCapacity = _charDbHolder.Value.Count,
                curSquadCount = 4,
                squads = _syncDataHolder.Value.user.troop.squads,
                chars = _charDbHolder.Value
                    .Where(chr => chr.Value.profession != ProfessionCategory.NONE
                                && chr.Value.profession != ProfessionCategory.TOKEN
                                && chr.Value.profession != ProfessionCategory.TRAP)
                    .Select(chr =>
                    new PlayerCharacter
                    {
                        instId = instId++,
                        charId = chr.Key,
                        favorPoint = 25570,
                        potentialRank = chr.Value.maxPotentialLevel,
                        mainSkillLvl = 7,
                        skin = _skinTableHolder.Value.charSkins.Where(s => s.Value.charId == chr.Key).LastOrDefault().Value.skinId,
                        level = chr.Value.phases.LastOrDefault()?.maxLevel ?? 0,
                        exp = 0,
                        evolvePhase = (EvolvePhase)(chr.Value.phases.Length - 1),
                        defaultSkillIndex = chr.Value.skills.Length - 1,
                        gainTime = 1587109206,
                        skills = chr.Value.skills.Select(s =>
                            new PlayerCharSkill
                            {
                                skillId = s.skillId,
                                unlock = true,
                                // state = false,
                                specializeLevel = s.specializeLevelUpData.Length,
                                // completeUpgradeTime = 0,
                            }).ToArray()
                    })
                    .ToDictionary(_chr =>
                    {
                        return Convert.ToString(value++);
                    }),
            };
            _syncDataHolder.Value.ts = Utils.Time.GetTimeStamp();
            _syncDataHolder.Value.user.events.building = DateTime.UtcNow;
            _syncDataHolder.Value.user.events.status = Utils.Time.GetTimeStamp();
            return _syncDataHolder.Value;
        }

        [HttpPost("syncStatus")]
        public string SyncStatus()
        {
            return $"{{\"ts\":{Utils.Time.GetTimeStamp()},\"result\":{{\"4\":{{\"announcementVersion\":\"270\",\"announcementPopUpVersion\":\"525\"}},\"16\":{{\"goodPurchaseState\":{{\"result\":{{\"safetyZone_2019\":-1,\"spirit_2019\":-1,\"chen_2019_R1\":-1,\"wooden_2019\":-1,\"penguin_2019\":-1,\"elite_2019\":-1,\"restaurant_2020\":-1,\"artdeco_2020\":-1,\"beerhouse_2020\":-1,\"dormW_2020\":-1,\"GP_NpOne_1_NpOne_1_v1\":1,\"GP_Once_5\":1,\"GP_Once_6\":1,\"GP_Once_7\":1,\"GP_Once_8\":1,\"GP_Once_9\":1,\"GP_Once_10\":1,\"GP_Once_1\":1}}}}}}}},\"playerDataDelta\":{{\"modified\":{{\"status\":{{\"lastOnlineTs\":1588429466,\"resume\":\"相关功能优化中，签名暂无法保存，请等待后续开放。（修改任务不受影响）\"}},\"activity\":{{\"TYPE_ACT9D0\":{{\"act9d0\":{{\"coin\":0,\"favorList\":[\"char_113_cqbw\",\"char_400_weedy\",\"char_401_elysm\",\"char_250_phatom\",\"char_254_vodfox\",\"char_333_sidero\",\"char_301_cutter\"]}}}}}},\"pushFlags\":{{\"hasGifts\":0,\"hasFriendRequest\":0,\"hasClues\":0}}}},\"deleted\":{{}}}}}}";
        }
    }
}