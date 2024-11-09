using UnityEngine;


    public class Enemy : Character
    {
     
        public Enemy(string name, int health) : base(name, health)
        {

        }

        public void Attack(Character character , int amount)
        {
            character.Health -= amount;
            if (character.Health < 0)
            {
                character.Health = 0;
            }

            Debug.Log("Charachter Attaked !! \n     Health now :" + character.Health);

        }





    }

