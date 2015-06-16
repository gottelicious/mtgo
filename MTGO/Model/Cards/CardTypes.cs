using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO.Model
{
    abstract class Card
    {
        Mana[] cost;
        int convertedManaCost { public get; set; }
    }

    abstract class Permanent : Card
    {
        Boolean internalIsSummoningSick;
        public Boolean isSummoningSick { get { return internalIsSummoningSick; } set { internalIsSummoningSick = value; } }
        Boolean internalIsTapped;
        public Boolean isTapped { get { return internalIsTapped; } set { internalIsTapped = value; } }
        public Player controller;

        public void untap()
        {
            isTapped = false;
        }
        public void tap()
        {
            isTapped = true;
        }
    }
    interface Artifact
    {
    }
    interface Creature
    {
        int power { get; set; }
        int currentPower { get; set; }
        int toughness { get; set; }
        int currentToughness { get; set; }
    }
    interface Enchantment
    {
    }
    interface Instant
    {
    }
    interface Land
    {
    }
    interface Planeswalker
    {
        int loyalty { get; set; }
        int loyaltyCounters { get; set; }
    }
    interface Sorcery
    {
    }
    interface Tribal
    {
    }
}
