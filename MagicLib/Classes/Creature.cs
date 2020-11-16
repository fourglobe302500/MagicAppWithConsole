using System.Collections.Generic;

namespace MagicLib
{
    public class Creature : Card
    {
        public Creature(
            int iD,
            string name,
            List<CardColor> cardColors,
            List<CardType> types,
            CardRarity rarity,
            string description,
            List<ManaType> cost,
            List<Action> actions,
            Stats status,
            List<CreatureSpecies> species)
        {
            ID = iD;
            Name = name;
            CardColors = cardColors;
            Types = types;
            Rarity = rarity;
            Description = description;
            Cost = cost;
            Actions = actions;
            Status = status;
            Species = species;
        }
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override List<CardColor> CardColors { get; set; }
        public override List<CardType> Types { get; set; }
        public override CardRarity Rarity { get; set; }
        public override string Description { get; set; }
        public override List<ManaType> Cost { get; set; }
        public override List<Action> Actions { get; set; }
        public Stats Status { get; set; }
        public List<CreatureSpecies> Species { get; set; }
    }
}
