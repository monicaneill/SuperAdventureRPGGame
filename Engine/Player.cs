using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature //public scope so visible throughout whole solution
    {
        public int Gold { get; set; }             // “get” a value (read what is stored in the
                                                  // property) and “set” a value (store a value in
                                                  // the property).
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }


        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints,
            int level) : base(currentHitPoints, maximumHitPoints) //don't need to add
                                                             //these below as inherited from base
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }

        //Once program creates (instantiates) a Player object, it will be able to read and change
        // the values of the object’s properties.
    }
}
