using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseMenu");
        }
    }
    public void LoadSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void Start()
    {
        string currentScene =SceneManager.GetActiveScene().name;
        if (currentScene =="Level2New")
        {
            Invoke("LoadGameOver",3f);
        }
    }
    private void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }



}
