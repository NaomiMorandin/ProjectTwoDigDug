using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShrubScript : MonoBehaviour
{

    public GameObject goodShrubPrefab;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject == false)
        {
            Instantiate(goodShrubPrefab, transform.position, Quaternion.identity);
        }

    }

}
