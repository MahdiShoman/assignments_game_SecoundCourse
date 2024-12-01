using UnityEngine;
namespace Assignment_20
{
    public class HelicopterArrowsMove : MonoBehaviour
    {
        public float speed = 7f;
        public Transform helicopterObject;
        private Vector3 direction;
        void Update()
        {

            helicopterObject.localRotation = Quaternion.identity;
            direction = Vector3.zero;


            if (Input.GetKey(KeyCode.RightArrow))
            {
                helicopterObject.localRotation = Quaternion.Euler(0, 0, -45);
                direction = Vector3.right;

            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {

                helicopterObject.localRotation = Quaternion.Euler(0, 0, 45);
                direction = Vector3.left;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {

                helicopterObject.localRotation = Quaternion.Euler(45, 0, 0);
                direction = Vector3.forward;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {

                helicopterObject.localRotation = Quaternion.Euler(-45, 0, 0);
                direction = Vector3.back;
            }


            transform.position += direction * speed * Time.deltaTime;
        }
    }
}