using UnityEngine;

public class TestingUtilities : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Utilities.Add(1,2,3,4,5,6,7,8,9,4,56,4,585));
        Debug.Log(Utilities.RepeatString("Hello",5));
        
    }

  
}
