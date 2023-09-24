using UnityEngine;
using UnityEngine.UI;

public class Score : Subject
{

    public Transform player;
    public Text scoreText;

    void Update()
    {

        scoreText.text = player.position.z.ToString("0");

        if(player.position.z > 100)
        {
            NotifyObservers();
        }
        
    }
}
