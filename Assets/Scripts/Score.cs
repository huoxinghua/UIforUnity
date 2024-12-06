using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
  
    [SerializeField] private TMP_Text _scoreText;
    private void Start()
    {
        _scoreText.text ="Score: " + 1;
    }
 
}

