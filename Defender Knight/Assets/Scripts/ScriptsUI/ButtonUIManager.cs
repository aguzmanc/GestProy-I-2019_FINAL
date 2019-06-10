using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUIManager : MonoBehaviour
{
    [SerializeField]
    private string escena;
    // Start is called before the first frame update
    public void btnStart()
    {
        SceneManager.LoadScene(escena);
    }
    public void btnExit()
    {
        Application.Quit();
    }
}
