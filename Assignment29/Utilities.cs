using System;
using System.Linq;
using UnityEngine;

public static class Utilities 
{
  
    public static int Add (params int[] numbers){
        int sum = 0;
        
        foreach (int n in numbers){
            sum += n;
        }
        
        return sum;
    } 
    public static string RepeatString (this string st , int count){
        return string.Concat(Enumerable.Repeat(st, count));

    }
}
