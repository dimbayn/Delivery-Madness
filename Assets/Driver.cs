using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 0.01f;
    float moveSpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
        
        if (steerSpeed <= 1) {
            steerSpeed += 0.001f;
        }
        
        if (moveSpeed <= 0.1) {
            moveSpeed += 0.0001f;
        }
    }
}
