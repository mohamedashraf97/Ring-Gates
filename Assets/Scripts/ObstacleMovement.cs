using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{ void Update()
    {
        if (PlayerMovement.dead != true)
        {
            transform.Translate(Vector3.back * 20f * Time.deltaTime);
            Destroy(gameObject, 10.0f);
        }
    }
}
