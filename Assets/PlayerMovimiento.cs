using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovimiento : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;

    public GameObject pista;
    public Vector3 posiconInicial;
    public GameObject panel;

    public GameObject cubo;
    GameObject clon;

    bool hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        posiconInicial = pista.transform.position;
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
            //Destroy(gameObject);
            pista.transform.position = posiconInicial;

        }
        if (col.gameObject.name == "Pista")
        {
            hasJump = true;
        }
        if (col.gameObject.name == "WIN")
        {
            panel.SetActive(true);
            for(int i = 0; i < 100; i++)
            {
                clon = Instantiate(cubo);
                Destroy(clon, 5);
            }
        }
        
    }
}