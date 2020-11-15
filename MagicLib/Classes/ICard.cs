using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents an Card Interface
    /// </summary>
    public interface ICard
    {
        List<CardColor> CardColors { get; }
        string Name { get; }
        List<CardType> Types { get; }
        CardRarity Rarity { get; }
        string Image { get; }
    }
}
