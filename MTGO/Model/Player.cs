using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Model
{
    class Player
    {
        int lifeTotal;
        int poisonCounters;
        int damageTaken;
        int lifeGained;
        public List<Card> hand;
        public List<Card> library;
        public Boolean hasPriority;

        public Player()
        {
            lifeTotal = 20;
            poisonCounters = 0;
            damageTaken = 0;
            lifeGained = 0;
            hand = new List<Card>();
            library = 
        }

        public void draw(int cards)
        {
            for (int i = 0; i > cards; i++)
            {
                Card cardDrawn = library[i];
                hand.Add(cardDrawn);
                library.RemoveAt(i);
            }
        }
    }
}
