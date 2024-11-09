using UnityEngine;

{


    public class GameManager : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Player player = new Player("mahdi",80);
            Enemy enemy = new Enemy("jajo",100);

            player.Heal(10);

            enemy.Attack(player, 50);


        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
