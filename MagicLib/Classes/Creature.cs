using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents an Creature Card
    /// </summary>
    public class Creature : ICard
    {
        /// <summary>
        /// Represents the creature's Colors
        /// </summary>
        public List<CardColor> CardColors => throw new System.NotImplementedException();
        
        /// <summary>
        /// Represents the creature's Name
        /// </summary>
        public string Name => throw new System.NotImplementedException();
        
        /// <summary>
        /// Represents the creature's Types
        /// </summary>
        public List<CardType> Types => throw new System.NotImplementedException();
        
        /// <summary>
        /// Represents the creature's Rarity
        /// </summary>
        public CardRarity Rarity => throw new System.NotImplementedException();

        /// <summary>
        /// Represents the creature's Image location
        /// </summary>
        public string Image => throw new System.NotImplementedException();
        
        /// <summary>
        /// A List that represents the creature's total Cost
        /// </summary>
        public List<Mana> Cost { get; }
        
        /// <summary>
        /// Represents the creature's Status
        /// </summary>
        public Stats Status { get; set; }
        
        /// <summary>
        /// Represents the creature's Decription
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// A List that represents the creature's Species
        /// </summary>
        public List<CreatureSpecies> Species { get; set; }
        
        /// <summary>
        /// A List that represents the creature's Actions
        /// </summary>
        public List<Action> Actions { get; set; }
    }
}
