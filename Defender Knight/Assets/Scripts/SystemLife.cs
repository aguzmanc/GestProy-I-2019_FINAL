using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemLife : MonoBehaviour
{
    private float LifePoints, ArmorPoints, TimeArmor;
    public Scrollbar ScrollLifeUI, ScrollArmorUI;
    Renderer rend;
    Color c;


    void Start()
    {
        TimeArmor = -2f;
        ArmorPoints = 1f;
        LifePoints = 1f;
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }
    // Update is called once per frame
    void Update()
    {
        ScrollLifeUI.size = LifePoints;
        ScrollArmorUI.size = ArmorPoints;
        TimeArmor -= Time.deltaTime;
        if (TimeArmor<=0f && TimeArmor >= -1f)
        {
            TimeArmor = 3f;
            ArmorPoints = ArmorPoints + 0.2f;
        }
        if (LifePoints<=0)
        {
            //poner animacion y cosas que pase al morir
        }
        if (ArmorPoints >=1 )
        {
            TimeArmor = -2f;
        }
      
    }

    //controlador collision trigger
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" || col.tag == "FireEnemy" || col.tag=="EnemyAttack")
        {
            if (ArmorPoints>0)
            {
                ArmorPoints = ArmorPoints - 0.2f;
                TimeArmor = 3f;
                
            }
            if (ArmorPoints<=0)
            {
                LifePoints = LifePoints - 0.1f;
                TimeArmor = 3f;
                StartCoroutine("GetInvulnerable");
            }
            //LifePoints = LifePoints -0.1f;
            //StartCoroutine("GetInvulnerable");
        }
    }

    //Invulnerable
    IEnumerator GetInvulnerable()
    {
        Physics2D.IgnoreLayerCollision(0, 9, true);
        Physics2D.IgnoreLayerCollision(0, 10, true);
        Physics2D.IgnoreLayerCollision(0, 11, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(1f);
        Physics2D.IgnoreLayerCollision(0, 9, false);
        Physics2D.IgnoreLayerCollision(0, 10, false);
        Physics2D.IgnoreLayerCollision(0, 11, false);
        c.a = 1f;
        rend.material.color = c;
        
    }

}
