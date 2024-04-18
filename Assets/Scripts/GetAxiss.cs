using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxiss : MonoBehaviour
{
    private float deger, deger2;
    void Update()
    {
        deger = Input.GetAxisRaw("Horizontal");
        deger2 = Input.GetAxisRaw("Vertical");

        //deger sart blogu
        if (deger > 0)
        {
            print("D veya Sag Ok tusuna bastiniz");
        }
        else if (deger == 0)
        {
            print("Hic tusa basmad�n�z");
        }
        else
        {
            print("A veya Sol Ok tusuna bastiniz");
        }

        //deger2 sart blogu
        if (deger2 > 0)
        {
            print("W veya Yukar� Ok tusuna bastiniz");
        }
        else if (deger2 == 0)
        {
            print("Hic tusa basmad�n�z");
        }
        else
        {
            print("S veya Asag� Ok tusuna bastiniz");
        }
    }
}
