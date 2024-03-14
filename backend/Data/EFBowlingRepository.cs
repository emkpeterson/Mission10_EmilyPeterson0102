
namespace Mission10_EmilyPeterson0102.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingContext _bowlingContext;

        public EFBowlingRepository(BowlingContext temp)
        {
            _bowlingContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlingContext.Teams;
    }
}
