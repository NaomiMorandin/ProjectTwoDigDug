using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Control2DInput();
    }

    void Control2DInput()
    {
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1f);
        }
    }
}
