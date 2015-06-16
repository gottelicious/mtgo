using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Model.Cards.Test
{
    class GrizzlyBear : Permanent, Creature
    {
        public int power { get; set; }
        public int toughness { get; set; }
        public GrizzlyBear()
        {
            List<Mana> manaCost = new List<Mana>();
            manaCost.Add(new Green());
            manaCost.Add(new Mana());
            power = 2;
            toughness = 2;
        }

        public override void resolve()
        {
            return;
        }
    }
}
