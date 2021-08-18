using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine
{
    public class HealingPotion : Item // means HealingPotion has a base class of Item, so all the
                                      // public properties and methods from the Item class now
                                      // automatically show up in the HealingPotion class,
                                      // even after we delete the lines for the ID, Name, and
                                      // NamePlural properties.

      //HealingPotion is now a “child class”, or “derived class”, from the Item class
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
