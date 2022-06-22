using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public Text txt_Timetime;
    public Text txt_TimeFloored;

    float customTime;
    bool isCounting; 

    // Start is called before the first frame update
    void Start()
    {
        customTime = 0;
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting == true)
        {
            float time = Time.time;
            txt_Timetime.text = time.ToString();

            txt_TimeFloored.text = Mathf.Floor(time).ToString();
        }
       
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "WIN")
        {
            isCounting = false;
        }
    }
}
