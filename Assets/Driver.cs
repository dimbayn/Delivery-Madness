using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300.0f;
    [SerializeField] float moveSpeed = 20.0f;
    [SerializeField] float speedUpSpeed = 30.0f;
    [SerializeField] float slowDownSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Speed Up")
        {
            Debug.Log("Made in Heaven ...");
            moveSpeed = speedUpSpeed;
            Destroy(other.gameObject);
        }

        if (other.tag == "Slow Down")
        {
            Debug.Log("Za Warudo ...");
            moveSpeed = slowDownSpeed;
            Destroy(other.gameObject);
        }
    }
}
