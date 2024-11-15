using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float movementMultiplier = 1f;
    public GameObject swordDown;
    public GameObject swordUp;
    public GameObject swordLeft;
    public GameObject swordRight;
    // Start is called before the first frame update
    void Start()
    {
        swordDown.SetActive(false);
        swordUp.SetActive(false);
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gm = GameObject.FindAnyObjectByType<GameManager>();
        if (gm != null && gm.canMove == true)
        {
            Control2DInput();
            
        }
        else
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * movementMultiplier;
        }

    }

    void Control2DInput()
    {
        int x = 0;
        int y = 0;
        if (Input.GetKey(KeyCode.S))
        {
            swordDown.SetActive(true);
            swordUp.SetActive(false);
            swordLeft.SetActive(false);
            swordRight.SetActive(false);
            y += -1;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            swordRight.SetActive(true);
            swordDown.SetActive(false);
            swordUp.SetActive(false);
            swordLeft.SetActive(false);
            x += 1;
        }
        if(Input.GetKey(KeyCode.W))
        {
            
            swordUp.SetActive(true);
            swordLeft.SetActive(false);
            swordRight.SetActive(false);
            swordDown.SetActive(false);
            y += 1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            
            swordLeft.SetActive(true);
            swordRight.SetActive(false);
            swordDown.SetActive(false);
            swordUp.SetActive(false);

            x += -1;
        }
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, y) * movementMultiplier;

    }


    }

