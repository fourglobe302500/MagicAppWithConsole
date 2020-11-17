using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Configuration;

namespace MagicLib.DataAcess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) 
            => $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";

        public static List<string> LoadFile(this string file) => !File.Exists(file) ?
            new List<string>() : File.ReadAllLines(file).ToList();

        public static List<Creature> ConvertToCreature(this List<string> lines)
        {
            List<Creature> output = new List<Creature>();
            lines.ForEach(line => {
                List<object> cols = line.Parse();
                int ID = int.Parse((string)cols[0]);
                string Name = (string)cols[1];
                List<CardColor> colors = cols[2].ToListSimple<string>().ParseAsEnumArray<CardColor>();
                List<CardType> types = cols[3].ToListSimple<string>().ParseAsEnumArray<CardType>();
                CardRarity rarity = (CardRarity)Enum.Parse(typeof(CardRarity), (string)cols[4]);
                string description = (string)cols[5];
                List<ManaType> cost = cols[6].ToListSimple<string>().ParseAsEnumArray<ManaType>();
                List<Action> actions = cols[7].ToListSimple<List<object>>().ToList().ParseAsAction();
                Stats Status = ((List<object>)cols[8]).ParseAsStats();
                List<CreatureSpecies> species = cols[9].ToListSimple<string>().ParseAsEnumArray<CreatureSpecies>();
                Creature c = new Creature(ID, Name, colors, types, rarity, description, cost, actions, Status, species);
                output.Add(c);
            });
            return output;
        }
        public static List<T> ToListSimple<T>(this object cast)
        {
            return ((List<object>)cast).Cast<T>().ToList();
        }
        public static List<object> Parse(this string line)
        {
            List<string> rawOutput = new List<string>();
            int position = 0;
            int clean = 0;
            while (position < line.Length)
            {
                string written = "";
                while (line[position] != ',' || clean != 0)
                {
                    switch (line[position])
                    {
                        case '[': case '{':
                            clean++;
                            break;
                        case ']': case '}':
                            clean--;
                            break;
                    }
                    written += line[position++];
                    if (position >= line.Length)
                        break;
                }
                rawOutput.Add(written);
                position++;
            }
            List<object> output = new List<object>();
            rawOutput.ForEach(v => output.Add(v[0] == '[' || v[0] == '{' ? 
                v.Substring(1, v.Length - 2).Parse() : v));
            return output;
        }

        public static List<T> ParseAsEnumArray<T>(this List<string> arr)
            => arr.Select(v => (T)Enum.Parse(typeof(T), v)).ToList();

        public static List<Action> ParseAsAction(this List<List<object>> arr)
            =>   arr.Select(v => new Action(
                                v[0].ToListSimple<string>().ParseAsEnumArray<ActionType>(), 
                                v[1].ToListSimple<List<object>>().ParseAsModifier()))
                    .ToList();

        public static List<Modifier> ParseAsModifier(this List<List<object>> arr)
            =>   arr.Select(v => new Modifier(
                                int.Parse((string)v[0]), 
                                int.Parse((string)v[1]),
                                v[2].ToListSimple<string>().ParseAsEnumArray<SpecialEffects>()))
                    .ToList();

        public static Stats ParseAsStats(this List<object> arr)
        {
            
            Stats stat = new Stats(
                int.Parse((string)arr[0]),
                int.Parse((string)arr[1]),
                (new List<object>[]{arr[2].ToListSimple<object>()}).ToList().ParseAsModifier());
            return stat;
        }

        public static List<string> ConvertToString(this List<Creature> arr)
            => arr.Select(c => c.ConvertToString()).ToList();

        public static void Save(this List<Creature> creatures, string fileName)
            => File.WriteAllLines(fileName.FullFilePath(), creatures.ConvertToString());

        private static string ConvertToString(this Creature c)
        {
            string output = $"{c.ID},{c.Name},[";
            c.CardColors.ForEach(color => output += color.ToString() + ",");
            output = output.Insert(output.Length - 1, "]");
            output += "[";
            c.Types.ForEach(type => output += type.ToString() + ",");
            output = output.Insert(output.Length - 1, "]");
            output += $"{c.Rarity.ToString()},{c.Description},[";
            c.Cost.ForEach(cost => output += $"{cost.ToString()},");
            output = output.Insert(output.Length - 1, "]");
            output += "[";
            c.Actions.ForEach(a =>
            {
                output += "{[";
                a.Conditions.ForEach(cond => output += cond.ToString() + ",");
                output = output.Insert(output.Length - 1, "]");
                output += "[";
                a.Effects?.ForEach(effect =>
                {
                    output += "{" + $"{effect.PowerChanger},{effect.HPChanger},[";
                    if (effect.SpecialEffects?.Count > 0)
                        foreach (var sp in effect.SpecialEffects)
                            output += sp.ToString() + ",";
                    else 
                        output += ",";
                    output = output.Insert(output.Length - 1, "]}");
                });
                output = output.Insert(output.Length - 1, "]}");
            });
            output = output.Insert(output.Length - 1, "]");
            output += $"{{{c.Status.Power},{c.Status.HP},";
            c.Status.Modifiers.ForEach(mod =>
            {
                output += "{" + $"{mod.PowerChanger},{mod.HPChanger},[";
                mod.SpecialEffects.ForEach(sp => output += sp.ToString() + ",");
                output = output.Insert(output.Length - 1, "]}}");
            });
            output += "[";
            c.Species.ForEach(spec => output += spec.ToString() + ",");
            output = output.Insert(output.Length - 1, "]").Remove(output.Length);
            return output;
        }
    }
}