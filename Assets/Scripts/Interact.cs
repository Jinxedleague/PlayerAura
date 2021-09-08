using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool active;
    private SpriteRenderer sprite;

    private void Start()
    {
        active = false;
        sprite = GetComponent<SpriteRenderer>();
        interaction();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("myPlayer"))
        {
            active = true;
            interaction();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("myPlayer"))
        {
            active = false;
            interaction();
        }
    }

    //Interaction is a placeholder, change contents based on what you need
    public void interaction()
    {
        if(active == true)
        {
            sprite.color = new UnityEngine.Color(1, 0, 0, 1);
        }
        else
        {
            sprite.color = new UnityEngine.Color(0, 0, 0, 1);
        }
    }
}
