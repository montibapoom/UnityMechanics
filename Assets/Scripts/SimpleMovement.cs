using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotationSpeed = 1f;

    private void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate()
    {
        var rotationVector = Vector3.zero;

        if (Input.GetKey(KeyCode.Q))
        {
            rotationVector = -Vector3.up;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotationVector = Vector3.up;
        }

        this.transform.eulerAngles += rotationVector * Time.deltaTime * rotationSpeed;
    }

    private void Move()
    {
        var moveVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveVector += Vector3.forward;
        }
        this.transform.Translate(moveVector * Time.deltaTime * moveSpeed);
    }
}
