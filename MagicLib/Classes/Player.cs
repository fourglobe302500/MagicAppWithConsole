using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents an Player
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Represents the Decks this player has registered
        /// </summary>
        public List<Deck> Decks { get; set; } = new List<Deck>();

        /// <summary>
        /// Represents the deck in use currently
        /// </summary>
        public Deck CurrentDeck { get; set; } = null;

        /// <summary>
        /// Represents the card's in the Player's Grimoire 
        /// during an battle
        /// </summary>
        public List<ICard> Grimoire { get; set; } = new List<ICard>();

        /// <summary>
        /// Represents the card's in the Player's Graveyard 
        /// during an battle
        /// </summary>
        public List<ICard> Graveyard { get; set; } = new List<ICard>();

        /// <summary>
        /// Represents the card's in the Player's Hand during an battle
        /// </summary>
        public List<ICard> Hand { get; set; } = new List<ICard>();

        /// <summary>
        /// Represents the card's in the Player's Camp during an battle
        /// </summary>
        public List<ICard> Camp { get; set; } = new List<ICard>();

        /// <summary>
        /// Represents the Territories the Player has already 
        /// deployed in an battle
        /// </summary>
        public List<Terrain> Territories { get; set; } = new List<Terrain>();

        /// <summary>
        /// Represents wheter or not the player has placed an 
        /// terrain in this turn
        /// </summary>
        public bool HasPlayedTerrain { get; set; } = false;

        /// <summary>
        /// Represents the Player's Name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Represents the Player's NickName
        /// </summary>
        public string NickName { get; set; } = "Guest";
        private string PassWord { get; }

        /// <summary>
        /// Represents the Player's Id
        /// </summary>
        public int Id { get; } = 0;

        /// <summary>
        /// Represents the Player's Hp
        /// </summary>
        public int HP { get; set; } = 0;

        /// <summary>
        /// Represents the Player's Mana to use in this round
        /// </summary>
        public List<Mana> ManaToUse { get; set; } = new List<Mana>();
        
        /// <summary>
        /// Creates an player from an name, nickname an id
        /// </summary>
        /// <param name="name">Your real Name</param>
        /// <param name="nickName">Your Name that appears in the battles</param>
        /// <param name="id">An Id(HEX)</param>
        public Player(string name, string nickName, int id)
        {
            Name = name;
            NickName = nickName;
            Id = id;
        }
    }
}