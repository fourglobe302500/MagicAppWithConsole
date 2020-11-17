namespace MagicLib
{
    public enum CardColor
    {
        Blue,
        Red,
        White,
        Green,
        Black,
        ColorLess
    }

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

    public enum CardRarity
    {
        Common,
        Uncommon,
        Rare,
        SuperRare,
        Lengendary
    }

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

    public enum TerrainType
    {
        Basic
    }

    public enum ManaType
    {
        Blue,
        Red,
        White,
        Green,
        Black,
        ColorLess
    }

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
