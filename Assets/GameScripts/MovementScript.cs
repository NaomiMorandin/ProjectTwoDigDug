using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementMultiplier = 1f;
    
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
        int x = 0;
        int y = 0;
        if (Input.GetKey(KeyCode.S))
        {
            y += -1;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            x += 1;
        }
        if(Input.GetKey(KeyCode.W))
        {
            y += 1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            x += -1;
        }
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y) * movementMultiplier;

    }


    }

