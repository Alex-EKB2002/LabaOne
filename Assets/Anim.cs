using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim : MonoBehaviour
{
    public Button NextButton;

    public void OnNextButton()
    {
        NextButton.interactable = true;
    }
}
