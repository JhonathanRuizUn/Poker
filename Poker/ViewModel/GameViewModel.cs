using GalaSoft.MvvmLight;
using Poker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Poker.ViewModel
{
    public class GameViewModel : ViewModelBase
    {
        private ObservableCollection<Player> players;
        private Deck deck = new Deck();
        public ObservableCollection<Player> Players
        {
            get { return players; }
            set { players = value; RaisePropertyChanged(); }
        }
        public GameViewModel()
        {

            Players = new ObservableCollection<Player>
            {
                new Player(1, "Player 1", GiveCardsPlayer(), GiveChips()),
                new Player(1, "Player 2", GiveCardsPlayer(), GiveChips()),

            };
            
        }

        public List<Chips> GiveChips()
        {

            List<Chips> chipsCollection = new List<Chips>();

            List<Chip> standard  = Chip.chipCollection;

            foreach (Chip chip in standard)
            {
                Chips chips = new Chips
                {
                    Chip = chip,
                    Quantity = 10
                };
                chipsCollection.Add(chips);
            }

            return chipsCollection;


        }

        public List<Card> GiveCardsPlayer()
        {
            List<Card> hand = new List<Card>();
            for (int i = 0; i < 2; i++)
            {
                hand.Add(deck.DrawCard());
            }
            return hand;
            
        }
    }
}
