using UnityEngine;



    public class Player : Character
    {

   

        public Player(string name, int health) : base(name, health)
        {
        }

        public void Heal(int amount)
        {

            Health += amount;
            if (Health > 100) 
            {
                Health = 100;
            }
            Debug.Log("health : " + Health);

        }



    }
