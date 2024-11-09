using UnityEngine;


    public class Character
    {
        string name;
        int health;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int Health
        {

            get { return health; }

            set
            {
                if (health >= 0 || health <= 100) health = value;
            }

        }


        public Character(string name, int health)
        {
            this.name = name;
            this.health = health;
        }



    }




