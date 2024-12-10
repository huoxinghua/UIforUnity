using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoPreviousScene : MonoBehaviour
{
    private static Stack<string> sceneHistory = new Stack<string>();

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
        if (sceneHistory.Count == 0 || sceneHistory.Peek() != currentScene)
        {
            sceneHistory.Push(currentScene);
        }
    }
    public void GoBack()
    {

        if (sceneHistory.Count > 0)
        {
            
            sceneHistory.Pop();
            string previousScene = sceneHistory.Peek();
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.Log("null to go back");
        }

    }
}
