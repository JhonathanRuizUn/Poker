using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Model
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Deck Deck { get; set; }
        public List<Chip> Pot { get; set; }
        public List<Card> CommunityCards { get; set; }
        public int SmallBlind { get; set; }
        public int BigBlind { get; set; }

        public Game() { 
            StartGame();
        }

        private void StartGame()
        {
            Deck = new Deck();
            
        }
    }
}
