using MTGO.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Controller
{
    class GameEngine
    {
        int turnNumber;
        Player activePlayer;
        Player nonActivePlayer;
        List<Permanent> permanents;
        ArrayList stack;

        public GameEngine()
        {
            turnNumber = 0;

        }
        public void beginNewTurn(Player activePlayer)
        {
            this.activePlayer = activePlayer;
        }
        public void givePriority(Player player)
        {
            player.hasPriority = true;
        }
        public void passedPriority(Player player)
        {
            player.hasPriority = false;
            if (player.Equals(activePlayer))
                givePriority(nonActivePlayer);
            else if (stack.Count == 0)
                resolveNextStackItem();
            else 
        }
        public void resolveNextStackItem()
        {
            if (stack[stack.Count] is Card)
            {
                Card card = stack[stack.Count] as Card;
                card.resolve();
                stack.RemoveAt(stack.Count);
            }
        }
        public void addPermanent(Permanent permanent)
        {
            permanents.Add(permanent);
        }
        public void untapStep()
        {
            foreach (Permanent permanent in permanents)
            {
                if (permanent.controller.Equals(this.activePlayer))
                {
                    permanent.untap();
                    permanent.isSummoningSick = false;
                }
            }
            upkeep();
        }
        public void upkeep()
        {
            drawStep();
        }
        public void drawStep()
        {
            activePlayer.draw(1);
            
        }
        public void preCombatMainPhase()
        {
            givePriority(activePlayer);
        }
    }
}
