using System;
using System.Collections.Generic;

namespace phase10Scorer.Models
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public int Id { get; set; }

        public int Round { get; set; }
    }
}