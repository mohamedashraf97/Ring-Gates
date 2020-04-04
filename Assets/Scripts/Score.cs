using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score=0;
    public GameObject ob;

void Update()
{
    if(PlayerMovement.dead)
    {
        score = 0;
    }
}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ob= Instantiate (Resources.Load ("AudioSourcePrefab")) as GameObject;
            score += 1;
        }
    }
}
