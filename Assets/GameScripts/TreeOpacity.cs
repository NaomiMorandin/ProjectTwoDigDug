using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOpacity : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;


    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("hit");
        if (other != null && other.gameObject.CompareTag("Player"))
        //defensive code, checks for null before using the perameter, failsafe
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();

            //m_SpriteRenderer.color.a = 155f; 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
