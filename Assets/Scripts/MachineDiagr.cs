using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class MachineDiagr : MonoBehaviour
{
    public Text p1Kn;
    public Text p2Kn;
    public Text p3Kn;
    public Text p4Kn;
    public double p1;
    public double p2;
    public double p3;
    public double p4;
    // Start is called before the first frame update
    void Start()
    {
        p1 = Convert.ToDouble(PlayerPrefs.GetString("p1").Remove(PlayerPrefs.GetString("p1").Length - 2, 2));
        p2 = Convert.ToDouble(PlayerPrefs.GetString("p2").Remove(PlayerPrefs.GetString("p2").Length - 2, 2));
        p3 = Convert.ToDouble(PlayerPrefs.GetString("p3").Remove(PlayerPrefs.GetString("p3").Length - 2, 2));
        p4 = Convert.ToDouble(PlayerPrefs.GetString("p4").Remove(PlayerPrefs.GetString("p4").Length - 2, 2));
        
    }

    // Update is called once per frame
    void Update()
    {
        p1Kn.text = string.Format("{0:0.##}", (p1/1000));
        p2Kn.text = string.Format("{0:0.##}", (p2/ 1000));
        p3Kn.text = string.Format("{0:0.##}", (p3/1000));
        p4Kn.text = string.Format("{0:0.##}", (p4 / 1000));
    }
}
