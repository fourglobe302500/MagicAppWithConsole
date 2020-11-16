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
                List<CardColor> colors = ((List<string>)cols[2]).ParseAsEnumArray<CardColor>();
                List<CardType> types = ((List<string>)cols[3]).ParseAsEnumArray<CardType>();
                CardRarity rarity = ((List<string>)cols[4]).ParseAsEnumArray<CardRarity>().First();
                string description = (string)cols[5];
                List<ManaType> cost = ((List<string>)cols[6]).ParseAsEnumArray<ManaType>();
                List<Action> actions = ((List<List<object>>)cols[7]).ParseAsAction();
                Stats Status = ((List<List<object>>)cols[8]).ParseAsStats();
                List<CreatureSpecies> species = ((List<string>)cols[9]).ParseAsEnumArray<CreatureSpecies>();
                Creature c = new Creature(ID, Name, colors, types, rarity, description, cost, actions, Status, species);
                output.Add(c);
            });
            return output;
        }

        public static List<object> Parse(this string line)
        {
            List<string> rawOutput = new List<string>();
            int position = -1;
            int clean = 0;
            while (++position < line.Length)
            {
                string written = "";
                while ((line[position] != ',' || clean != 0) && position < line.Length)
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
                }
                rawOutput.Add(written);
            }
            List<object> output = new List<object>();
            rawOutput.ForEach(v => output.Add(v[0] == '[' || v[0] == '}' ? 
                v.Substring(1, v.Length - 3).Parse() : v));
            return output;
        }

        public static List<T> ParseAsEnumArray<T>(this List<string> arr)
            => arr.Select(v => (T)Enum.Parse(typeof(T), v)).ToList();

        public static List<Action> ParseAsAction(this List<List<object>> arr)
            =>   arr.Select(v => new Action(
                                ((List<string>)v[0]).ParseAsEnumArray<ActionType>(), 
                                ((List<List<object>>)v[1]).ParseAsModifier()))
                    .ToList();

        public static List<Modifier> ParseAsModifier(this List<List<object>> arr)
            =>   arr.Select(v => new Modifier(
                                int.Parse((string)v[0]), 
                                int.Parse((string)v[1]),
                                ((List<string>)v[2]).ParseAsEnumArray<SpecialEffects>()))
                    .ToList();

        public static Stats ParseAsStats(this List<List<object>> arr)
            =>   arr.Select(v => new Stats(
                                int.Parse((string)v[0]),
                                int.Parse((string)v[1]),
                                ((List<List<object>>)v[2]).ParseAsModifier()))
                    .ToList()
                    .Single();

        public static List<string> ConvertToString(this List<Creature> arr)
            => arr.Select(c => c.ConvertToString()).ToList();

        public static void Save(this List<Creature> creatures, string fileName)
            => File.WriteAllLines(fileName.FullFilePath(), creatures.ConvertToString());

        private static string ConvertToString(this Creature c)
        {
            string output = $"{c.ID},{c.Name},[";
            c.CardColors.ForEach(color => output += color.ToString() + ",");
            output = output.Insert(output.Length - 1, "]");
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
                output += "],[";
                a.Effects.ForEach(effect =>
                {
                    output += "{" + $"{effect.PowerChanger},{effect.HPChanger},[";
                    effect.SpecialEffects.ForEach(sp => output += sp.ToString());
                    output += output.Insert(output.Length - 1, "]}");
                });
                output += output.Insert(output.Length - 1, "]}");
            });
            output += $"],{{{c.Status.Power},{c.Status.HP},";
            c.Status.Modifiers.ForEach(mod =>
            {
                output += "{" + $"{mod.PowerChanger},{mod.HPChanger},[";
                mod.SpecialEffects.ForEach(sp => output += sp.ToString());
                output += output.Insert(output.Length - 1, "]}");
            });
            output += "[";
            c.Species.ForEach(spec => output += spec.ToString() + ",");
            output = output.Insert(output.Length - 1, "]").Remove(output.Length - 1);
            return output;
        }
    }
}