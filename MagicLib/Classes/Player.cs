using System.Collections.Generic;

namespace MagicLib
{
    public class Player
    {
        public List<Deck> Decks { get; set; } = new List<Deck>();
        public Deck CurrentDeck { get; set; } = null;
        public List<Card> Grimoire { get; set; } = new List<Card>();
        public List<Card> Graveyard { get; set; } = new List<Card>();
        public List<Card> Hand { get; set; } = new List<Card>();
        public List<Card> Camp { get; set; } = new List<Card>();
        public List<Terrain> Territories { get; set; } = new List<Terrain>();
        public bool HasPlayedTerrain { get; set; } = false;
        public string Name { get; set; } = "";
        public string NickName { get; set; } = "Guest";
        private string PassWord { get; }
        public int Id { get; } = 0;
        public int HP { get; set; } = 0;
        public List<ManaType> ManaToUse { get; set; } = new List<ManaType>();
    }
}