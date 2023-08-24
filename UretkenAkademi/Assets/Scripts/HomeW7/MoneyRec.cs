using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyRec : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = PlayerPrefs.GetString("Money");
    }


}
