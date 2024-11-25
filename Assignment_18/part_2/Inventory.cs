using System.Collections.Generic;
using UnityEngine;
namespace Assignment18_Part_2
{
    public class Inventory
    {

        private List<string> items = new List<string>();
        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string i in items)
            {
                Debug.Log(i);
            }
        }


        public static Inventory operator +(Inventory inventory1, Inventory inventory2)
        {
            Inventory margeInventories = new Inventory();

            foreach (var item in inventory1.items)
            {
                margeInventories.AddItem(item);
            }

            foreach (var item in inventory2.items)
            {
                margeInventories.AddItem(item);
            }
            return margeInventories;
        }
    }
}