using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    public void PushOnSpace()
    {
        SceneManager.LoadScene("Main");
    }
}
