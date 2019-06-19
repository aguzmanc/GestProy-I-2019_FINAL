using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_Esqueleto : MonoBehaviour
{
    private bool perseguir;
    public float speed;
    public float stoppingDistance;

    private Transform target , player;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Objetivo").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (!perseguir)
        {
            if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            perseguir = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
            perseguir = false;
    }

}
