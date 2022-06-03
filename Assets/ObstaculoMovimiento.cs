using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoMovimiento : MonoBehaviour
{
    public float Obi;
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
            transform.Translate(Obi, 0, 0);
        }
    }
}
