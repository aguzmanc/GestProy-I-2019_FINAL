using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic backgrounMusic;
    // Start is called before the first frame update
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        //if (backgrounMusic==null)
        //{
        //    backgrounMusic = this;
        //    DontDestroyOnLoad(gameObject);
        //    Debug.Log("1");
        //}
        //else if (backgrounMusic!=this)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("2");
        //}
       
    }
 
}
