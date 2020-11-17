using System.Collections.Generic;
using System.Linq;
using MagicLib.DataAcess.TextHelper;

namespace MagicLib.DataAcess
{
    public static class TextConnector
    {
        private const string CreaturesFile = "CreaturesCards.csv";
        

        public static object CreatureCard(int ID)
        {
            Creature creature = CreaturesFile.FullFilePath().LoadFile().ConvertToCreature().Find(x => x.ID == ID);
            if (creature != null)
                return creature;
            throw new System.Exception("ID is not valid");
        }

        public static Creature Register(this Creature newCreature)
        {
            List<Creature> creatures = CreaturesFile.FullFilePath().LoadFile().ConvertToCreature();
            int currentID = creatures.Count > 0 ?
                currentID = creatures.OrderByDescending(x => x.ID).First().ID + 1 : 1;
            newCreature.ID = currentID;
            creatures.Add(newCreature);
            creatures.Save(CreaturesFile);
            return newCreature;
        }
    }
}