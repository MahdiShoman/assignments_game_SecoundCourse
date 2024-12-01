using UnityEditor;
using UnityEngine;
namespace Assignment_20
{
    public class RandomCubes : MonoBehaviour
    {
        public GameObject prefab;
        private float timer = 0f;
       
        void Update()
        {
            // Generate a random cubes between -10 and 10 x Axis every 1 second 
            timer += Time.deltaTime;
            if (timer >= 1f)
            {
                Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(0f, 100f));
                Instantiate(prefab, randomPosition, Quaternion.identity);
                Vector3 randomPosition1 = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(0f, 100f));
                Instantiate(prefab, randomPosition1, Quaternion.identity);
                Vector3 randomPosition2 = new Vector3(Random.Range(-10f, 10f), 1, Random.Range(0f, 100f));
                Instantiate(prefab, randomPosition2, Quaternion.identity);
                timer = 0f;
            }

        }
    }
}