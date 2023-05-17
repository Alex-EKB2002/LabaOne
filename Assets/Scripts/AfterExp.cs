using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AfterExp : MonoBehaviour
{
    public Text d;
    public Text a0;

    void Start()
    {
        d = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        d.text = string.Format("{0:0.##}", Math.Sqrt(4 * Convert.ToDouble(a0.text.Remove(a0.text.Length - 5, 5)) / Math.PI)) + " μμ";
        PlayerPrefs.SetString("NewD", d.text);
    }
}
