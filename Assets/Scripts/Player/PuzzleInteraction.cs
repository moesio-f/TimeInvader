using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleInteraction : MonoBehaviour
{

    public Sprite[] images;
    public SpriteRenderer target;
    private int count = 0;
    private bool key;
    private bool onTouch = false;


    void Update()
    {
        key = Input.GetKeyDown(KeyCode.E);
    }

    void FixedUpdate()
    {
        if (key && onTouch)
        {
            target.sprite = images[count];
            count++;
            if (count > (images.Length - 1))
                count = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        onTouch = true;
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        onTouch = false;
    }
 
}
