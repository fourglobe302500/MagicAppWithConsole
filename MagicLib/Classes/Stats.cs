using System.Collections.Generic;

namespace MagicLib
{
    public class Stats
    {
        public Stats(int power, int hp, List<Modifier> modifiers)
        {
            Power = power;
            HP = hp;
            Modifiers = modifiers;
        }

        public int Power { get; set; }
        public int HP { get; set; }
        public List<Modifier> Modifiers { get; set; }
    }
}