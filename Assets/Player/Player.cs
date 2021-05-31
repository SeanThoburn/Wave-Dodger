using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D body;
    public float speedX;
    public float speedY;

    public GameObject fail;

    private void FixedUpdate()
    {
        body.AddForce(new Vector2(Input.GetAxis("Horizontal") * speedX, Input.GetAxis("Vertical") * speedY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hazard")
        {
            Time.timeScale = 0;
            fail.gameObject.SetActive(true); //this will bring up the screen to retry the mission when you collide with a hazardous object.
        }
    }


}
