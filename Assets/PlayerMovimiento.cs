using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovimiento : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
   

    bool hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        hasJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJump == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Obstaculo")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Pista")
        {
            hasJump = true;
        }
    }
}