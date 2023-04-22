using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ImportDiametr : MonoBehaviour
{
    public Text textt;
    public Button but;
    public Text len;
    public Text a0;
    public Text v0;
    public bool IsTrue = false;

    // Update is called once per frame
    void Update()
    {
        IsTrue = textt.text.All(char.IsDigit);
            
        
        if (IsTrue && textt.text != "" && Convert.ToInt32(textt.text) >= 5 && Convert.ToInt32(textt.text) <= 25)
        {
            but.interactable = true;
            len.text = (Convert.ToInt32(textt.text) * 5).ToString() + " ìì";
            a0.text =  string.Format("{0:0.##}", (Convert.ToInt32(textt.text) * (Convert.ToInt32(textt.text) * Math.PI)) / 4) + " êâ.ìì";
            v0.text = string.Format("{0:0.##}", Convert.ToDouble(a0.text.Remove(a0.text.Length - 6, 6)) * Convert.ToInt32(len.text.Remove(len.text.Length - 3,3)) + " êóá.ìì");
        }
        else
        {
            but.interactable = false;
            len.text = "";
            a0.text = "";
            v0.text = "";
        }
        
    }
}
