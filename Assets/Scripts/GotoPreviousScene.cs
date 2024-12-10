using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoPreviousScene : MonoBehaviour
{
    private static List<string> sceneHistory = new List<string>();
    private static List<string> menuHistory = new List<string>();


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GoBack();
        }
    }
    private void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        if (sceneHistory.Count == 0 || sceneHistory[sceneHistory.Count - 1] != currentScene)
        {
            sceneHistory.Add(currentScene);
        }
    }
  
    public void GoBack()
    {
        if (menuHistory.Count > 0)
        {
           
            string previousMenu = menuHistory[menuHistory.Count - 1];
            Debug.Log("go to menu: " + previousMenu);
           
        }
        else if (sceneHistory.Count > 0)
        {

            string previousScene = sceneHistory[sceneHistory.Count - 1];
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.Log("null to go back");
        }

    }
}
