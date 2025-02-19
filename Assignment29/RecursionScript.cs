using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Call the recursive function
      Debug.Log(FibonacciRecursive(10));
      Debug.Log(FibonacciIterative(10));
      Debug.Log(FibonacciRecursive(30));
      Debug.Log(FibonacciIterative(30));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int FibonacciRecursive(int n){
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    //(using a loop) FibonacciIterative(int n)
    public int FibonacciIterative(int n)
    {
        int a = 0, b = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
         return b;

    }
}
