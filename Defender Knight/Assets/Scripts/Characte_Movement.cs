using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characte_Movement : MonoBehaviour
{

    public float speed = 100;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }


    //public float speed;
    //private Rigidbody2D rb2d;

    //void Start()
    //{
    //    rb2d = GetComponent<Rigidbody2D>();
    //}

    //void FixedUpdate()
    //{
    //    float movimiento_horizontal = Input.GetAxisRaw("Horizontal");

    //    float movimiento_vertical = Input.GetAxis("Vertical");

    //    Vector2 movement = new Vector2(movimiento_horizontal, movimiento_vertical);

    //    rb2d.AddForce(movement * speed);
    //}
}
