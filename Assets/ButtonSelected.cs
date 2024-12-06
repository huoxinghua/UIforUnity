using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour
{
    [SerializeField] Button primaryButton;
    void Start()
    {
   
        StartCoroutine(SelectButton());
    }

    private IEnumerator SelectButton()
    {
        Debug.Log("select play");
        // Wait one frame to ensure the UI is fully initialized
        yield return null;

        if (EventSystem.current != null && primaryButton != null && primaryButton.interactable)
        {
            EventSystem.current.SetSelectedGameObject(primaryButton.gameObject);
        }
        else
        {
            Debug.LogWarning("Button or EventSystem not available or button is not interactable.");
        }
    }
}