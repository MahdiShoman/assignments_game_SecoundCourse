using UnityEngine;
namespace Assignment18_Part_2
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {

            Inventory potion = new Inventory();
            potion.AddItem("Healing Potion");
            potion.AddItem("Strength Potion");
            
            Inventory elixir = new Inventory();
            elixir.AddItem("Elixir");
            elixir.AddItem("Dark Elixir");

            Inventory margeInventory = potion + elixir;
            margeInventory.ShowItems();
        }
    }
}