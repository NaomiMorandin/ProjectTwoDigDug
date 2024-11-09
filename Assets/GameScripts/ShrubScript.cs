using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public class ShrubScript : MonoBehaviour
{

    public GameObject goodShrubPrefab;
    public GameObject badShrubPrefab;
    public int x = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void OnHit()
    {
        int x = Random.Range(0, 2);

        if (x == 0)
        {
            Instantiate(goodShrubPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(badShrubPrefab, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("PlayerWeapon"))
        {
            OnHit();
        }
  
    }
}


