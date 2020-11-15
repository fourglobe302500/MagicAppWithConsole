using System.Collections.Generic;

namespace MagicLib
{
    public class Modifier
    {
        public int PowerChanger { get; set; }
        public int HPChanger { get; set; }
        public List<SpecialEffects> SpecialEffects { get; set; }
    }
}