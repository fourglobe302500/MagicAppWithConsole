using System;
using System.Collections.Generic;
using System.Text;

namespace MagicLib
{
    /// <summary>
    /// Represents an Magic Card
    /// </summary>
    class Magic : ICard
    {
        /// <summary>
        /// Represents the magic's Colors
        /// </summary>
        public List<CardColor> CardColors => throw new NotImplementedException();

        /// <summary>
        /// Represents the magic's Name
        /// </summary>
        public string Name => throw new NotImplementedException();

        /// <summary>
        /// Represents the magic's Types
        /// </summary>
        public List<CardType> Types => throw new NotImplementedException();

        /// <summary>
        /// Represents the magic's Rarity
        /// </summary>
        public CardRarity Rarity => throw new NotImplementedException();

        /// <summary>
        /// Represents the magic's Image location
        /// </summary>
        public string Image => throw new NotImplementedException();

        /// <summary>
        /// Represents the magic's Actions
        /// </summary>
        public List<Action> Actions { get; set; }
    }
}
