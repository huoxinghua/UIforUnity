using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] GameObject pauseMenu;
    //private void Start()
    //{
    //    pauseMenu.SetActive(false);
    //}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("PauseMenu");
        }
    }
}
