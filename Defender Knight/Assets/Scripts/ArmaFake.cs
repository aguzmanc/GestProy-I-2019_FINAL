using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaFake : MonoBehaviour
{
    public GameObject EfectoDisparo;
    
    Transform anclaje;

    void Awake(){
        anclaje = transform.Find("anclaje_disparo");
    }

    public void DisparoSimple(){
        StartCoroutine(InstanciarDisparo());
    }


    public void DisparoRafaga(){
        StartCoroutine(Rafaga());
    }


    IEnumerator Rafaga(){
        for(int i=0;i<3;i++){
            StartCoroutine(InstanciarDisparo());
            yield return new WaitForSeconds(0.1f);
        }
    }
    

    IEnumerator InstanciarDisparo() {
        GameObject obj = (GameObject)Instantiate(EfectoDisparo, anclaje.position, anclaje.rotation);
        obj.GetComponent<EfectoDisparo>().Disparar();
        yield return new WaitForSeconds(2f);
        Destroy(obj);
    }
}
