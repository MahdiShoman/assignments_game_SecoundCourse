using UnityEngine;
namespace Assignment_20
{
    public class FanRotation : MonoBehaviour
    {

        void Start()
        {

        }


        void Update()
        {
            // Rotate the fan around its local Y axis by 1 degree per frame
            transform.Rotate(Vector3.up, 1f);

        }
    }
}
