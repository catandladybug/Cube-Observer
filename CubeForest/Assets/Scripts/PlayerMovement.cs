using UnityEngine;

public class PlayerMovement : Subject
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidwaysForce = 500f;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {

            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -1f)
        {

           // NotifyObservers();

            FindObjectOfType<GameManager>().EndGame();

        }

        if(rb.position.y < -1.9f && rb.position.y > -2f)
        {
            NotifyObservers();
        }
    }
}
