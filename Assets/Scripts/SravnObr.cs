using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SravnObr : MonoBehaviour
{
    public Text d0;
    public Text dsh;
    public Text l0;
    public Text lr;

   
    public Text ashZam;
    public Text lrZam;
    public Text dshZam;

    public Text p1Zam;
    public Text p2Zam;
    public Text p3Zam;
    public Text p4Zam;

    public Text l1Zam;
    public Text l2Zam;
    public Text l3Zam;
    public Text l4Zam;

    public Text d0Zam;
    public Text a0Zam;
    public Text v0Zam;
    public Text l0Zam;

    

    // Update is called once per frame
    void Update()
    {
        d0.text = MyDiam.myDiam + " μμ";
        l0.text = Convert.ToInt32(MyDiam.myDiam) * 5 + " μμ";
        dsh.text = PlayerPrefs.GetString("NewD");
        lr.text = PlayerPrefs.GetString("NewL");

        p1Zam.text = PlayerPrefs.GetString("p1");
        p2Zam.text = PlayerPrefs.GetString("p2");
        p3Zam.text = PlayerPrefs.GetString("p3");
        p4Zam.text = PlayerPrefs.GetString("p4");

        l1Zam.text = PlayerPrefs.GetString("l1");
        l2Zam.text = PlayerPrefs.GetString("l2");
        l3Zam.text = PlayerPrefs.GetString("l3");
        l4Zam.text = PlayerPrefs.GetString("l4");

        d0Zam.text = PlayerPrefs.GetString("d0");
        l0Zam.text = PlayerPrefs.GetString("l0");
        v0Zam.text = PlayerPrefs.GetString("v0");
        a0Zam.text = PlayerPrefs.GetString("a0");

        dshZam.text = PlayerPrefs.GetString("NewD");
        lrZam.text = PlayerPrefs.GetString("NewL");
        ashZam.text = PlayerPrefs.GetString("ash");

    }
}
