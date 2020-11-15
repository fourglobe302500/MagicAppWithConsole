using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// REpresents an Terrain Card
    /// </summary>
    public class Terrain : ICard
    {
        /// <summary>
        /// Represents the terrain's Colors
        /// </summary>
        public List<CardColor> CardColors => throw new System.NotImplementedException();

        /// <summary>
        /// Represents the terrain's Name
        /// </summary>
        public string Name => throw new System.NotImplementedException();
        
        /// <summary>
        /// Represents the terrain's Types
        /// </summary>
        public List<CardType> Types => throw new System.NotImplementedException();

        /// <summary>
        /// Represents the terrain's Rarity
        /// </summary>
        public CardRarity Rarity => throw new System.NotImplementedException();

        /// <summary>
        /// Represents the terrain's Image location
        /// </summary>
        public string Image => throw new System.NotImplementedException();

        /// <summary>
        /// Represents the Mana this terrain will give wenn tapped
        /// </summary>
        public List<Mana> GivenMana { get; set; }
    }
}
