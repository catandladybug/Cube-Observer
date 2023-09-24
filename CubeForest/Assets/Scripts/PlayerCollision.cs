using UnityEngine;

public class PlayerCollision : Subject
{

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        
        //Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {

            movement.enabled = false;
            NotifyObservers ();
            FindObjectOfType<GameManager>().EndGame();

        }

    }

}
