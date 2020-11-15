using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents the satatus of an Card
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Represents the base attack power the Creature
        /// will have
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Represents the base health points the creature 
        /// will have
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Is a List of Modifiers for the stats
        /// </summary>
        public List<Modifier> Modifiers { get; set; }
    }
}