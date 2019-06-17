using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUIManager : MonoBehaviour
{
    [SerializeField]
    private string escena;
    public GameObject music;
    // Start is called before the first frame update
    public void btnStart()
    {
        Destroy(GameObject.Find(music.name));
        SceneManager.LoadScene(escena);
    }
    public void btnExit()
    {
        Application.Quit();
    }
}
