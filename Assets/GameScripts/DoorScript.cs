using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject doorOpen;
    public int key = 0;


    // Update is called once per frame
    void Update()
    {
        key = GameObject.FindGameObjectsWithTag("Key").Length;
        //make a count of all the keys in the scene.
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Door");
        if (key == 0 && other.gameObject.CompareTag("Player"))
        {
            OnHit();
            gameObject.SetActive(false);
            //when a player touches the door, if there are no keys in the scene (because they were collected) run the on hit script, and turn off the closed door
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
        //Hide the key in the UI, instantiate an open door object, destroy every enemy still in the scene.
    }

}
