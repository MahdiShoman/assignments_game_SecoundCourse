using UnityEngine;

public class TestingCustomObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    CustomObject customObject ;
    CustomObject customObject2 ;
    CustomObject customObject3;
    void Start()
    {
        customObject = new CustomObject(2,"mahdi");
        customObject2 = new CustomObject(2,"mahdi");
        customObject3 = new CustomObject(2,"mahdi2");

        print(customObject.ToString());
        print(customObject2.ToString());
        print(customObject3.ToString());

        print(customObject == customObject2);
        print(customObject != customObject2);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
