using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity02 : MonoBehaviour
{
    public float speed = 10;
    Vector2 move;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        // Force
        //rb.AddForce(move * speed * Time.deltaTime);

        // Velocity
        rb.velocity = new Vector2(- move.x * speed * Time.deltaTime, rb.velocity.y);
        //rb.velocity = new Vector2(move.x * speed * Time.deltaTime, move.y * speed * Time.deltaTime);
        //rb.velocity = move * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the character
        //transform.Translate(Input.GetAxis("Horizontal")* 15f * Time.deltaTime, 0f, 0f);

        // Transform
        //move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //transform.Translate(move * speed * Time.deltaTime);
        
        // RigidBody Force
        //move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        // RigidBody velocity
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
