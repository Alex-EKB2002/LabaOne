using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AfterExp1 : MonoBehaviour
{
    public Text A;
    public Text AZam;
    double rand;
    

    void Start()
    {
        A = GetComponent<Text>();
        rand = UnityEngine.Random.Range(0.4f, 0.45f);
    }

    // Update is called once per frame
    public void Update()
    {
        A.text = string.Format("{0:0.##}", (Convert.ToInt32(MyDiam.myDiam) * (Convert.ToInt32(MyDiam.myDiam) * Math.PI)) * rand  / 4 ) + " Í‚.ÏÏ";
        AZam.text = A.text;
        PlayerPrefs.SetString("ash", AZam.text);
    }
    
}
