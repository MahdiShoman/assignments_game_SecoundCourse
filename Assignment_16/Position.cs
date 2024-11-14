using UnityEngine;
namespace Assignment18
{
    public struct Position
    {
        float X;
        float Y;
        float Z;
         public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void  printPosition(){
            Debug.Log("position X : "+X);
            Debug.Log("position Y : "+Y);
            Debug.Log("position Z : "+Z);
        }

    }
}
