using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoDisparo : MonoBehaviour
{
    private Animator animator;

    void Awake(){
        animator = GetComponent<Animator>();
    }

    public void Disparar(){
        animator.SetTrigger("Dispara");
    }
}
