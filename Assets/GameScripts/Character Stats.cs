using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public int health = 30;
    public bool playerAlive = true;
    public GameObject restartButton;
    public GameObject youDied;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPlayerDamage()
    {
        if (health <= 0)
        {
            playerAlive = false;
            restartButton.SetActive(true);
            youDied.SetActive(true);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("BadShrub"))
        {
            OnPlayerDamage();
            health = health - 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            OnPlayerDamage();
            health = health - 5;
        }
    }
}

