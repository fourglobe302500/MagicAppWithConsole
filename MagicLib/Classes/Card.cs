using System.Collections.Generic;

namespace MagicLib
{
    public abstract class Card
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract List<CardColor> CardColors { get; set; }
        public abstract List<CardType> Types { get; set; }
        public abstract CardRarity Rarity { get; set; }
        public abstract string Description { get; set; }
        public abstract List<ManaType> Cost { get; set; }
        public abstract List<Action> Actions { get; set; }
    }
}
