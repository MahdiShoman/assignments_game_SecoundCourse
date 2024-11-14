using UnityEngine;
namespace Assignment18
{
    public class Solider : Character
    {
       public  Solider(string name, int health, Position position) : base(name, health, position) {

        
       }

        public void DisplayInfo(){

            Debug.Log("Solider");
            base.DisplayInfo();
        }


    }
}
