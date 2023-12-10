using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text _scoreText;
    
    private void Update()
    {
        
        
        _scoreText.text = "Score: " + PlayerPrefs.GetInt("score", color.score); 

    }



}
