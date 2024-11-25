using UnityEngine;
namespace Assignment18_Part_1
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
           
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");

            
            string savedItem = gameContainer.GetItem();
            Debug.Log(savedItem);

            
            string description = GameUtils.DescribeItem(savedItem);
            Debug.Log(description);
        }
    }
}