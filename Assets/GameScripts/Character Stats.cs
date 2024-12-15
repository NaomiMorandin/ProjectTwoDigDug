using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterStats : MonoBehaviour
{

    public int health = 30;
    public bool playerAlive = true;
    public GameObject restartButton;
    public GameObject youDied;
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    float m_Red, m_Blue, m_Green;
    

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        //calling the component of the sprite that renders it to access the colour of the player character
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
            Destroy(gameObject.GetComponentInParent<MovementScript>().gameObject);
            //if the health is 0, kill the player, set the restart button and the you died text to active, destroy the empty object parent that holds the character.
        }
        if (health <= 10)
        {

            m_SpriteRenderer.color = Color.red;
            //from the sprite renderer we set the colour of the object to red.
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("BadShrub"))
        {
            OnPlayerDamage();
            health = health - 2;
            //when the player steps on a hazard left by destroyed shrubs, they take two damage.
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            OnPlayerDamage();
            health = health - 5;
            //if the player walks into an enemy they take five damage.
        }
    }
}

