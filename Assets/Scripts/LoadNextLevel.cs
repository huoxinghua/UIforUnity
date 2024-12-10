using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;  

public class LoadNextLevel : MonoBehaviour
{
    
    private void Start()
    {
        Invoke("LoadLevel",5f);
    }
    void LoadLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}
