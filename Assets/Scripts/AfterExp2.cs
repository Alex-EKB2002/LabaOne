using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AfterExp2 : MonoBehaviour
{

    public Text l;
    public Text lZam;
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

    public double p1;
    public double p2;
    public double p3;
    public double p4;
    public double l1;
    public double l2;
    public double l3;
    public double l4;
    public double a0;
    public double randomina;
    public int l0;
    

    // Start is called before the first frame update
    void Start()
    {
        

        l = GetComponent<Text>();
        randomina = UnityEngine.Random.Range(-5, 5);
        a0 = Math.Round((Convert.ToInt32(MyDiam.myDiam) * (Convert.ToInt32(MyDiam.myDiam) * Math.PI) / 4),2);
        l0 = Convert.ToInt32(MyDiam.myDiam) * 5;
        p1 = 250 * a0 * (1 + randomina / 100);
        p2 = 280 * a0 * (1 + randomina / 100);
        p3 = 445 * a0 * (1 + randomina / 100);
        p4 = 305 * a0 * (1 + randomina / 100);
        l1 = 0.015 * l0 * (1 + randomina / 100);
        l2 = 0.034 * l0 * (1 + randomina / 100);
        l3 = 0.170 * l0 * (1 + randomina / 100);
        l4 = 0.260 * l0 * (1 + randomina / 100);

    }

    // Update is called once per frame
    void Update()
    {
        l.text = string.Format("{0:0.##}", l0 + l4 - (p4/p1*l1)) + " μμ";
        lZam.text = l.text;
        l1Zam.text = string.Format("{0:0.##}", l1) + " μμ";
        l2Zam.text = string.Format("{0:0.##}", l2) + " μμ";
        l3Zam.text = string.Format("{0:0.##}", l3) + " μμ";
        l4Zam.text = string.Format("{0:0.##}", l4) + " μμ";

        p1Zam.text = string.Format("{0:0.##}", p1) + " Ν/μμ^2";
        p2Zam.text = string.Format("{0:0.##}", p2) + " Ν/μμ^2";
        p3Zam.text = string.Format("{0:0.##}", p3) + " Ν/μμ^2";
        p4Zam.text = string.Format("{0:0.##}", p4) + " Ν/μμ^2";

        d0Zam.text = MyDiam.myDiam + " μμ";
        l0Zam.text = (Convert.ToInt32(MyDiam.myDiam) * 5).ToString() + " μμ";
        a0Zam.text = string.Format("{0:0.##}", a0) + " κβ.μμ";
        v0Zam.text = string.Format("{0:0.##}", a0 * l0) + " κσα.μμ";

        PlayerPrefs.SetString("NewL", l.text);

        PlayerPrefs.SetString("p1", p1Zam.text);
        PlayerPrefs.SetString("p2", p2Zam.text);
        PlayerPrefs.SetString("p3", p3Zam.text);
        PlayerPrefs.SetString("p4", p4Zam.text);

        PlayerPrefs.SetString("l1", l1Zam.text);
        PlayerPrefs.SetString("l2", l2Zam.text);
        PlayerPrefs.SetString("l3", l3Zam.text);
        PlayerPrefs.SetString("l4", l4Zam.text);

        PlayerPrefs.SetString("d0", d0Zam.text);
        PlayerPrefs.SetString("l0", l0Zam.text);
        PlayerPrefs.SetString("v0", v0Zam.text);
        PlayerPrefs.SetString("a0", a0Zam.text);



    }
}
