using System.Collections.Generic;

namespace MagicLib
{
    public class Action
    {
        public List<ActionType> Conditions { get; set; }
        public List<Modifier> Effects { get; set; }
    }
}