using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Banuti : MonoBehaviour
{
    public Text Banut;
    void SetCountText()
    {
        Banut.text = Data.banuti.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        SetCountText();
    }
}
