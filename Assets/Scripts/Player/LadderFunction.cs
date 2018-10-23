using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class LadderFunction : MonoBehaviour 
{
    public float speed = 6f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetButton("Jump"))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (other.tag == "Player" && Input.GetKey(KeyCode.S))
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else if (other.tag == "Player")
        {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

    }

}
