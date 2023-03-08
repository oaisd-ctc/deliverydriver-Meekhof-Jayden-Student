using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float turnSpeed = 1f;
    [SerializeField]float moveSpeed = 15f;
    [SerializeField]float slowSpeed = 10f;
    [SerializeField]float boostSpeed = 20f;
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
