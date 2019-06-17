using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_base : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 7);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Si chocamos contra el enemigo lo borramos
        if (col.transform.tag == "Enemy")
        {
            col.GetComponent<Enemy>().Attacked();
            Destroy(gameObject);
        }
        if (col.transform.tag == "FireEnemy")
        {
            col.GetComponent<espiritu_de_fuego_ia>().Attacked();
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        // Si se sale de la pantalla borramos la roca
        Destroy(gameObject);
    }
}
