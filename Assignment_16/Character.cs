using UnityEngine;
namespace Assignment18
{
    public class Character : MonoBehaviour
    {
            private string name;
            private int health;
            private Position position;

             public int Health
            {
                set{
                        if(value>=0 && value<=100){
                            health=value;
                        }

                    }
                    get{
                        return health;
                    }
            }
        

         public Character(): this("No name", 100, new Position(0,0,0)){
            // empty constructor
        }

        public Character(string name , int health , Position position){
            this.name = name;
            this.health = health;
            this.position=position;
        }


        public void DisplayInfo(){
            Debug.Log("name : "+ name);
            Debug.Log("health : "+health);
            position.printPosition();
        }

        public void Attack(int damage , Character target){
            target.health -= damage;
            
        } 
        public void Attack(int damage , Character target ,string attackType){
            Attack(damage,target);
            Debug.Log("Attacked by :"+attackType);
        }
       





    }
}