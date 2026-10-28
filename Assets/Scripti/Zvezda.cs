using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zvezda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Igrok player = collision.GetComponent<Igrok>();
            player.points++;
            Destroy(this.gameObject);
        }
    }
}