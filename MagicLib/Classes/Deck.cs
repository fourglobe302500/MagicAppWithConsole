using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents an Deck
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Represents the cards in the Deck
        /// </summary>
        public List<ICard> Cards { get; set; }

        /// <summary>
        /// Represents the deck's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the deck's Image location
        /// </summary>
        public string Image { get; set; }
    }
}