namespace MagicLib
{
    /// <summary>
    /// Contains the Cards Colors for MagicLib.ICard
    /// </summary>
    public enum CardColor
    {
        Blue,
        Red,
        White,
        Green,
        Black,
        ColorLess
    }

    /// <summary>
    /// Contains the Cards Type for MagicLib.ICard
    /// </summary>
    public enum CardType
    {
        InstantMagic,
        Magic,
        Creature,
        Enchantment,
        Equipament,
        Artefact,
        LendaryCreature,
        Terrain
    }

    /// <summary>
    /// Contains the Cards Rarity for MagicLib.ICard
    /// </summary>
    public enum CardRarity
    {
        Common,
        Uncommon,
        Rare,
        SuperRare,
        Lengendary
    }

    /// <summary>
    /// Contains the Cards Species for MagicLib.Creatures
    /// </summary>
    public enum CreatureSpecies
    {
        Ape,
        Human,
        Zombie,
        Druid,
        Spider,
        Scout,
        Boar,
        Elefant,
        Brushwagg,
        Chimera,
        Hydra,
        Giant,
        Noble,
        Elf,
        Dinosaur,
        Nightmare,
        Pangolin,
        Imp,
        Escorpion,
        Spirit,
        Cavalier,
        Demon,
        Vampire,
        Skeleton,
        Archer,
        Soldier,
        Cleric
    }

    /// <summary>
    /// Contains the Terrains Types for MagicLib.Terrain
    /// </summary>
    public enum TerrainType
    {
        Basic
    }

    /// <summary>
    /// Contains the Mana Types for general use
    /// </summary>
    public enum ManaType
    {
        Blue,
        Red,
        White,
        Green,
        Black,
        ColorLess
    }

    /// <summary>
    /// Contains the Special Effects for MagicLib.Modifier
    /// </summary>
    public enum SpecialEffects
    {
        Fly,
        Menace,
        Reach,
        PlayerDamage,
        PlayerHeal,
        Scry,
        Trample,
        CustomCost,
        Deathtouch,
        Lifelink,
        Exile,
        BringBack,
        Give,
        Sacrifice,
        PutBack,
        ForceFight,
        Indestructible,
        GivesMana,
        Tap,
        Untap,
        Draw,
        Destroy
    }

    /// <summary>
    /// Contains the Acions Types for MagicLib.Actions
    /// </summary>
    public enum ActionType
    {
        LastBreath,
        WarCry,
        Hability,
        Battle,
        Attack,
        Defend,
        EnemyLosesLife,
        MeLosesLife,
        Tap,
        ReceiveDamage,
        EntersCreature,
    }
}
