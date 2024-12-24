using System.Collections.Generic;
using UnityEngine;
namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Create a new creature
            List<Creature> test;

            test = new List<Creature>();
            Kangaroo kangaroo = new Kangaroo();
            test.Add(kangaroo);
            // Add the creature to the list
            Duck duck = new Duck();
            test.Add(duck);


            List<IRunnable> runnables = new List<IRunnable>();
            runnables.Add(kangaroo);
            runnables.Add(duck);

            List<IJumpable> jumpables = new List<IJumpable>();
            jumpables.Add(kangaroo);

            List<ISwimmable> swimmables = new List<ISwimmable>();
            swimmables.Add(duck);

            foreach (Creature c in test)
            {
                c.Speak();
            }
            foreach (IRunnable r in runnables)
            {
                r.Run();
            }
            foreach (IJumpable j in jumpables)
            {
                j.Jump();
            }
            foreach (ISwimmable s in swimmables)
            {
                s.Swim();
            }





        }

    }
}