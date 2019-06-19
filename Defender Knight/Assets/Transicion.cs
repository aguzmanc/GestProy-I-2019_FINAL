using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transicion : MonoBehaviour
{
    public float Tiempo;
    public string NombreEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= Time.deltaTime;
        if (Tiempo<=0&&Tiempo>=-1)
        {
            SceneManager.LoadScene(NombreEscena);
        }
       
    }
}
