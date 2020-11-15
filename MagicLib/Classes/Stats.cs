using System.Collections.Generic;

namespace MagicLib
{
    public class Stats
    {
        public int Power { get; set; }
        public int HP { get; set; }
        public List<Modifier> Modifiers { get; set; }
    }
}