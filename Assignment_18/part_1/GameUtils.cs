using System;
using UnityEngine;
namespace Assignment18_Part_1
{

    public  class GameUtils
    {
        
        public static string DescribeItem<T>(T something)
        {
            return "This item is a " + something ;
        }
    }

}