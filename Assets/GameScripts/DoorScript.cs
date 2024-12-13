using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject doorOpen;
    public bool keyCollected = false;

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
        if (other.gameObject.CompareTag("Player") && keyCollected)
        {
            OnHit();
            gameObject.SetActive(false);
        }
    }
    public void OnHit()
    {
        Instantiate(doorOpen, transform.position, Quaternion.identity);
        GameObject[] enemyList = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemyList) 
        {
            Destroy(enemy); 
        }
        
    }

}
