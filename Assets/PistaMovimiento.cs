using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaMovimiento : MonoBehaviour
{
    public float Movi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        if (time > 0.5)
        {
            transform.Translate(Movi, 0, 0);
        }
    }
}
