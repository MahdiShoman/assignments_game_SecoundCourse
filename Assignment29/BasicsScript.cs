using UnityEngine;

public class BasicsScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var integer_val = 0 ;
        var string_val = "GG";
        var boolean_val = true;

        // if statement using ? :
        string_val= (integer_val/2) != 0 ?  $"The number {integer_val}  is odd.":  $"The number {integer_val}  is even";
        Debug.Log(string_val);

        // Log thecurrent date using System.DateTime.?
        Debug.Log($"The current date is {System.DateTime.Now.Date}");

        // Log thecurrent time using System.DateTime.?
        Debug.Log($"The current time is {System.DateTime.Now.TimeOfDay}");

        // Log thecurrent day using System.DateTime.?
        Debug.Log($"The current day is {System.DateTime.Now.DayOfWeek}");
    }

   
}
