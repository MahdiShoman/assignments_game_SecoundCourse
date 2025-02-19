using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    void OnEnable(){
        print( "GameObject Enabled" ); 
    }
    void OnDisable() {
        print( "GameObject Disabled" );
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print( "GameObject Started" );
        if(GameObject.Find("TargetObject")){
            print( "TargetObject" );
        }else{
            print( "No TargetObject Found" );
        }
        if(GameObject.FindGameObjectWithTag("Joker")){
            print( "Joker Object Found" );
        }else{
            print( "No Joker Object Found" );
        }
        if(GameObject.FindObjectOfType<Light>()){
            print( "Light Object Found" );
        }else{
            print( "No Light Object Found" );
        }
    }

    // Update is called once per frame
    void Update()
    {
        //  Use SetActive() to deactivate TargetObject when the "D" key is pressed.
    if (Input.GetKeyDown(KeyCode.D))
    {
       GameObject.Find("TargetObject").SetActive(false);
       print("TargetObject deactivated!");
    }

        
    }
}
