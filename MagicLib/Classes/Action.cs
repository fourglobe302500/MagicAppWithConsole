using System.Collections.Generic;

namespace MagicLib
{
    /// <summary>
    /// Represents an Action that will happen
    /// once certin conditions are met
    /// </summary>
    public class Action
    {
        /// <summary>
        /// A List of all the conditions that must be met to the 
        /// Action to occur
        /// </summary>
        public List<ActionType> Conditions { get; set; }

        /// <summary>
        /// A List of all Effects that will happen once the conditions
        /// are met
        /// </summary>
        public List<Modifier> Effects { get; set; }
    }
}