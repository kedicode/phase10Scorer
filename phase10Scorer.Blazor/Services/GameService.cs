using System.Collections.Generic;
using phase10Scorer.Models;

namespace phase10Scorer.Services
{
    public class GameService
    {
        private List<Game> _games = new List<Game>();
        public GameService()
        {
        
        }

        public List<Game> GetGames()
        {
            return _games;
        }
    }
}


