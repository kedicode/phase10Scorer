using phase10Scorer.Enums;

namespace phase10Scorer.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int GameId { get; set; }

        public Phase CurrentPhase { get; set; }
    }
}