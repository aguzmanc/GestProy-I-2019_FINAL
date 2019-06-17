using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    bool Spawning = false;
    public float SpawnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Spawning) StartCoroutine(Spawn(SpawnSpeed));
    }

    IEnumerator Spawn(float seconds)
    {
        Spawning = true;  // Activamos la bandera
        // Si el prefab es correcto creamos el enemigo
        if (enemy != null)
        {
            GameObject aux = Instantiate(enemy, transform.position, transform.rotation);
            // Esperamos los segundos de turno antes de hacer spawn de otro enemigo
            yield return new WaitForSeconds(seconds);
        }
        Spawning = false; // Desactivamos la bandera
    }
}
