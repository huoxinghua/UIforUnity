using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour
{
    [SerializeField] Button firstButton;
    private void Start()
    {
        StartCoroutine(SetFirstButton());
    }

    private IEnumerator SetFirstButton()
    {
        yield return null; 
        firstButton.Select(); 
    }
}
