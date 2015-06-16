using MTGO.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Model
{
    abstract class GamePhase
    {
        public GameEngine gameEngine;
        abstract void goToNextStep();
        abstract void beginStep();
    }
    class untapStep : GamePhase
    {
        public untapStep(GameEngine gameEngine)
        {
            this.gameEngine = gameEngine;
        }
        override void beginStep()
        {
            gameEngine.untapStep();
        }
    }
}
