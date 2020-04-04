using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DyingScript : MonoBehaviour
{
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }
    void Update()
    {
        
            if (PlayerMovement.dead == true)
            {
            scoreText.text = "YOU DIED !! ";
            }
    }
}
