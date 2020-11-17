using System;
using System.Collections.Generic;
using MagicLib;

namespace UI.Printing
{
    public static class PrintingUtils
    {
        //TODO: 
        // public static void Print(this Creature c)
        // {
        //     Console.WriteLine( "Card: ");
        //     Console.WriteLine($"├──ID: {c.ID}");
        //     Console.WriteLine($"├──Name: {c.Name}");
        //     Console.WriteLine($"├──Colors:");
        //     c.CardColors.ForEach(
        //         (color, index) => Console.WriteLine($"│  {(index == c.CardColors.Count ? "└──" : "├──")}{color.ToString()}")
        //     );
        //     Console.WriteLine($"├──Rarity: {c.Rarity}");
        //     Console.WriteLine($"├──Description: {c.Description}");
        //     Console.WriteLine($"├──Cost:");
        //     c.Cost.ForEach(
        //         (cost, index) => Console.WriteLine($"│  {(index == c.CardColors.Count ? "└──" : "├──")}{cost.ToString()}")
        //     );
        //     Console.WriteLine($"├──Actions:");
        //     c.Actions.ForEach((action, index) => {
        //         Console.WriteLine($"│  ├──Action{index}:");
        //         Console.WriteLine($"│  │  ├──Condition{index}:");
        //         action.Conditions
        //     });
        // }

        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action, int InitialIndex = 0)
        {
            foreach (var item in source)
                action(item, InitialIndex++);
        }

    }
}
