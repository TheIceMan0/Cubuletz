using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySkin : MonoBehaviour
{
    public Material[] lista = new Material[4];
    public Slider slider;
    public Text bani;
    public Text buton;
    float value = 0;
    private void Awake()
    {
        if (Data.cump[0] == 1)
            buton.text = "Equip";
    }
    public void ChangedMaterial()
    {
        value=slider.value;
        gameObject.GetComponent<MeshRenderer>().material = lista[(int)value];
        if (Data.cump[(int)value] == 1)
            buton.text = "Equip";
        else
            buton.text = "Buy for 5 coins";
    }

    public void Buy()
    {
        if (Data.cump[(int)value] == 0 && Data.banuti >= 5)
        {
            Data.banuti -= 5;
            Data.cump[(int)value] = 1;
            buton.text = "Equip";
        }
        else if (Data.banuti < 5)
            buton.text = "Not enough money";
        Data.nou = lista[(int)value];
    }
    private void Update()
    {
        bani.text = "Banuti: " + Data.banuti.ToString();
    }
}
