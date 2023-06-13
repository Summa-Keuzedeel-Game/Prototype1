using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    public float rotSpeed = 20;

    public float horizontalInput;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        MoveForward();
        Rotate();
    }

    // Moves the vehicle forward
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * Time.deltaTime *  rotSpeed * horizontalInput);
    }
}
