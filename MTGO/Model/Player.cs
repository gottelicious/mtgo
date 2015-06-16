using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Model
{
    class Player
    {
        Boolean activePlayer { public get; set; }
        public Boolean publicActivePlayer { get { return activePlayer; } set { activePlayer = value; } }
        int lifeTotal;
        int poisonCounters;
        int damageTaken;
        int lifeGained;
        public List<Card> hand;
        public List<Card> library;
        public Boolean hasPriority;

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
