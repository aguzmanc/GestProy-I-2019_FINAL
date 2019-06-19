using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cristal : MonoBehaviour
{



    private Animator animator;
    public float VidaCristal {
        set {
            animator.SetFloat("VidaDelCristal", value);
        }
    }


    void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
