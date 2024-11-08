using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
 
    public int health = 30;
    public bool playerAlive = true;


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
            Die();
    }
    public void Die()
    {
        Destroy(gameObject);
        Debug.Log("Player has died");
    }
}
