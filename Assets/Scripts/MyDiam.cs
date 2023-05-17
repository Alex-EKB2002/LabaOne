using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyDiam : MonoBehaviour
{
    public static string myDiam;
    private Text myText;
    void Start()
    {
        myText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        myDiam = myText.text.ToString();
    }
}
