using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordIgnorer : MonoBehaviour
{

    public void update()
    {
        GameObject sword = GameObject.FindGameObjectWithTag("BadShrub");
        Physics2D.IgnoreCollision(sword.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}
