using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Items
{
    public class GameScore
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime StartedAt { get; set; }
        public int EllapsedTime { get; set; }

        public GameScore(string name)
        {
            Name = name;
            StartedAt = DateTime.Now;
            Id = "12345"; // generated random
            Score = 0;
            EllapsedTime = 0;
        }
    }
}
