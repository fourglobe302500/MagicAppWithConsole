using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents the modificator of status and
    /// atributes of an card
    /// </summary>
    public class Modifier
    {
        /// <summary>
        /// Represents in how much the target's Power will change
        /// </summary>
        public int PowerChanger { get; set; }

        /// <summary>
        /// Represents in how much the target's HP will change
        /// </summary>
        public int HPChanger { get; set; }

        /// <summary>
        /// Is a List of all Special Effects the creature will gain
        /// </summary>
        public List<SpecialEffects> SpecialEffects { get; set; }
    }
}