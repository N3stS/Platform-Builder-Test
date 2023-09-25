using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float moveForce = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right*moveForce*Input.GetAxis("Horizontal"),ForceMode2D.Force);
        rb.AddForce(transform.up*moveForce*Input.GetAxis("Vertical"),ForceMode2D.Force);
    }
}
