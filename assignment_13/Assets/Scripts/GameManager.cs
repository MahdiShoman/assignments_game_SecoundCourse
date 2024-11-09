using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = new Player();
        Player player_two = new Player();
        player.InitializePlayer("mahdi",70);
        player_two.InitializePlayer("mohammad",80);

        player.Heal(15);
        player_two.Heal(10);


        player.Heal(true);
        player_two.Heal(false);

        Player.ShowPlayerCount();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
