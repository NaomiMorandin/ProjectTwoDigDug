using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject doorOpen;
    public int key = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        key = GameObject.FindGameObjectsWithTag("Key").Length;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Door");
        if (key == 0 && other.gameObject.CompareTag("Player"))
        {
            OnHit();
            gameObject.SetActive(false);
        }
    }

    public void OnHit()
    {
        GameManager gm = GameObject.FindAnyObjectByType<GameManager>();
        gm.HideKey();
        Instantiate(doorOpen, transform.position, Quaternion.identity);
        GameObject[] enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemyList) 
        {
            Destroy(enemy); 
        }
        gm.ShowWinUI();
    }

}
