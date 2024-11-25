using System;
using UnityEngine;
namespace Assignment18_Part_1
{
    public class GameContainer<T>
    {
        private T item;

     
        public void SetItem(T item)
        {
            this.item = item;
        }

       
        public T GetItem()
        {
            return item;
        }
    }
}
