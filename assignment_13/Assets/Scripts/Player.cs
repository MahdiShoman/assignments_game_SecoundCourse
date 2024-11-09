using UnityEngine;

public class Player
{
    public string playerName;
    public int health = 0;
    static int playercount = 0;


       public void InitializePlayer(string name, int initialHealth)
    {

        if (string.IsNullOrEmpty(name)) { return; }
        playerName = name;
        health = initialHealth;
        playercount++;

    }

    public void Heal(int amount)
    {

        health += amount;
        Debug.Log("health : " + health);

    }
    public void Heal(bool fullRestore)
    {

        if (fullRestore)
        {
            health = 100;
        }

    }


    public static void ShowPlayerCount()
    {
        Debug.Log("plyer count : " + playercount);
    }




}
