using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;



public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

   

    void Start()
    {
        //Screen.SetResolution(1920, 1080, false);
    }
    public string nextSceneName;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
