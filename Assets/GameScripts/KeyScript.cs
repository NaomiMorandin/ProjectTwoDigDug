using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
   
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            OnHit();
            Debug.Log("hit");
        }
        
    }
    public void OnHit()
    {
        Destroy(gameObject);
        GameManager gm = GameObject.FindAnyObjectByType<GameManager>();
        gm.ShowKey();
        //destroy the key in the scene, toggle on the key UI element so the player knows they have the key.
    }

    
    
}


