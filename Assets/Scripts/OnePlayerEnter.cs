using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnePlayerEnter : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
          //  Debug.Log("load level1");
            LoadScene("Level1");


        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    
}
