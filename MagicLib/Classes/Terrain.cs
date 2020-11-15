using System.Collections.Generic;

namespace MagicLib
{
    public class Terrain : Card
    {
        public override List<CardColor> CardColors { get; set; }
        public override string Name { get; set; }
        public override List<CardType> Types { get; set; }
        public override CardRarity Rarity { get; set; }
        public override string Image { get; set; }
        public override List<ManaType> Cost { get; set; }
        public override List<Action> Actions { get; set; }
        public override string Description { get; set; }
    }
}
