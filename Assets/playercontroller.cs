using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D Rigidbody;
    public float speed = 5.0f;
    public float jumpForce = 8.0f;
    public float airControlForce = 10.0f;
    public float airControlMax = 1.5f;

    Vector2 boxExtents;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        //get the extent of the collision box
        boxExtents = GetComponent<BoxCollider2D>().bounds.extents;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (h != 0.0f)
            Rigidbody.velocity = new Vector2(h * speed, 0.0f);
    }
}