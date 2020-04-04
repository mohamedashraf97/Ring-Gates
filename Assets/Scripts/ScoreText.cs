using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        scoreText.text = "Score: " + Score.score.ToString();
    }

}

