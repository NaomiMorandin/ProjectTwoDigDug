using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ShrubDestroyer : MonoBehaviour
{
    Tilemap tilemap;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shrub")
        {
            
            Destroy(collision.gameObject);
         
        }
    }
}
