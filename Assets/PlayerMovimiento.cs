using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;

    int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
    }