using Assignment18;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Solider solider = new Solider("mahdi",50,new Position(0,2,0));
        Officer officer = new Officer();

        Character[] characters = new Character[]{solider,officer};

        for (int i =0 ; i < characters.Length ; i++){
            Debug.Log("Char [" + i + "] Info :");
            characters[i].DisplayInfo();
        }

        Debug.Log("Before Attack : "+ officer.Health);
        Debug.Log("Before Attack : "+solider.Health);

        officer.Attack(20,solider,"Assassination :) ");

        Debug.Log("After Attack : "+officer.Health);
        Debug.Log("After Attack : "+solider.Health);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
