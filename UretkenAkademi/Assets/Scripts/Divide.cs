using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divide : MonoBehaviour
{
    private string[] list = { "Tüm Elemanlar : ", "Ikiye Bölünenler : ", "Üçe Bölünenler : ", "Dörde Bölünenler : ", "Beþe Bölünenler : " };
    private void Start()
    {
        TwoNumber(20, 37);
    }
    private void TwoNumber(int num1, int num2)
    {
        for (int i = 0; i <= num2-num1; i++)
        {
            list[0] += " - " + (num1 + i);
            if ((i + num1) % 2 == 0)
                list[1] += " - " + (i + num1);
            if ((i + num1) % 3 == 0)
                list[2] += " - " + (i + num1);
            if ((i + num1) % 4 == 0)
                list[3] += " - " + (i + num1);
            if ((i + num1) % 5 == 0)
                list[4] += " - " + (i + num1);
        }
        for (int i = 0; i < list.Length; i++)
            Debug.Log(list[i]);
    }
}
