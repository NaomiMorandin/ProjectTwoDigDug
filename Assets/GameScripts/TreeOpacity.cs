using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TreeOpacity : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    

    //This script sets the alpha to transparent when a player is under a tree
    private void OnTriggerEnter2D(Collider2D other)
    {

       
        if (other != null && other.gameObject.CompareTag("Player"))
        //defensive code, checks for null before using the perameter, failsafe
        {
            GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {

        
        if (other != null && other.gameObject.CompareTag("Player"))
        //defensive code, checks for null before using the perameter, failsafe
        {
            GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
        }

    }
 


}
