using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwordScript : MonoBehaviour
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

        Debug.Log("hit");
        if (other != null && other.gameObject.CompareTag("Enemy"))
            //defensive code, checks for null before using the perameter, failsafe
        {
            other.gameObject.SetActive(false);
            DestroyEnemy();
        }
    }
    private void DestroyEnemy()
    {
        //when enemy destroyed, check if enemyCount == 0
        GameManager gm = GameObject.FindAnyObjectByType<GameManager>();
        gm.enemyCount--;

        if (gm.enemyCount <= 0)
        {
            gm.ShowWinUI();
        }
    }
}
