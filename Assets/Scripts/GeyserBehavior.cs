using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyserBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void OnTriggerStay2D()
    {
        rb.velocity = new Vector2(rb.velocity.x, 20 - Math.Abs(rb.velocity.y)/2);
        Debug.Log("triggered");
    }
}
