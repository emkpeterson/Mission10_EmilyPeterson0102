using Microsoft.AspNetCore.Mvc;
using Mission10_EmilyPeterson0102.Data;

namespace Mission10_EmilyPeterson0102.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;

        }

        [HttpGet ("bowlers")]
        public IEnumerable<Bowler> GetBowlers()
        {
            var bowlerData = _bowlingRepository.Bowlers.ToArray();

            return bowlerData;
        }

        [HttpGet ("teams")]
        public IEnumerable<Team> GetTeams()
        {
            var teamData = _bowlingRepository.Teams.ToArray();

            return teamData;
        }
    }
}
