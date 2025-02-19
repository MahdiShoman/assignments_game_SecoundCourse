using System.Collections.Generic;
using UnityEngine;

public class TypeManagementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Type Casting
        Cat cat = new Cat();
        
        // UpCasting
        Animal animal = cat;
        animal.MakeSound(); 
        animal.Move(); 
        
        // DownCasting
        Cat downCast_Cat = animal as Cat; 
        downCast_Cat.MakeSound(); 
        downCast_Cat.Move();

        // Type Checking
        List<ICanFight> canFights = new List<ICanFight>
        {
            new Cat(),
            new Warrior()
        };

        foreach (ICanFight fighter in canFights)
        {
            fighter.Attack();

            if (fighter is Cat)
            {
                Debug.Log("The object is a Cat.");
            }
            else if (fighter is Warrior)
            {
                Debug.Log("The object is a Warrior.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 class Animal {
    
    public virtual void MakeSound(){
        Debug.Log("Animal makes a sound");
    } 
    public void Move(){
        Debug.Log("Animal is moving");
    }
 }
 class Cat : Animal ,ICanFight {
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }
    public void Move(){
        Debug.Log("Cat runs quickly.");
    }
    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }
}

class Warrior : ICanFight
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with sword!");
    }
}


public interface ICanFight{
    public void Attack();
} 