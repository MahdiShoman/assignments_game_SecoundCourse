using Unity.VisualScripting;
using UnityEngine;
namespace Assignment27
{
    public class NewMonoBehaviourScript : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int a =0;
            int b = 0;

            AddNumberToVar_ByVale(a);
            Debug.Log("after calling the BY Value method = " + a);
            AddNumberToVar_ByReference(ref b);
            Debug.Log("after calling the BY REF method = " + b);
            int c; 
            AssignValue(out c);
            Debug.Log("Value of c after calling AssignValue method : " + c);

        }

        void AddNumberToVar_ByVale(int a){
             a =+ 10;
            Debug.Log("after adding 10 to a = "+a);
        } 
         void AddNumberToVar_ByReference (ref int b){
             b =+ 10;
            Debug.Log("after adding 10 to b = "+b);
         }

          void AssignValue(out int c)
        {
            c = 50; // Must be assigned inside the method
            Debug.Log("Value inside AssignValue method: " + c);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}