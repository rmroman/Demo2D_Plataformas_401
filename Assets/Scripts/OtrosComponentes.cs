using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtrosComponentes : MonoBehaviour
{
    public Slider slider;

    public void CambiaSlider()
    {
        float valor = slider.value;  // [0, 1]
        Time.timeScale = valor;
    }
}
