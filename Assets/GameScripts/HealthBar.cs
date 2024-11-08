using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    CharacterStats characterStats;
    private Slider healthBar;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        characterStats = GameObject.FindObjectOfType<CharacterStats>();
        maxHealth = characterStats.health;
        healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = characterStats.health / (float)maxHealth;
    }
}
