using System.Collections.Generic;

namespace MagicLib
{
    public class Action
    {
        public Action(List<ActionType> conditions, List<Modifier> effects)
        {
            Conditions = conditions;
            Effects = effects;
        }

        public List<ActionType> Conditions { get; set; }
        public List<Modifier> Effects { get; set; }
    }
}