using System.Collections.Generic;

namespace MagicLib
{
    public class Modifier
    {
        public Modifier(int powerChanger, int hPChanger, List<SpecialEffects> specialEffects = null)
        {
            PowerChanger = powerChanger;
            HPChanger = hPChanger;
            SpecialEffects = specialEffects;
        }

        public int PowerChanger { get; set; }
        public int HPChanger { get; set; }
        public List<SpecialEffects> SpecialEffects { get; set; }
    }
}