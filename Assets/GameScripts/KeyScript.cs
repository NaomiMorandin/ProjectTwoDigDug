using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }

    
    
}


