using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetMoney : MonoBehaviour
{
    public TextMeshProUGUI texts;
    private void OnTriggerEnter(Collider other)
    {
        texts.text = (int.Parse(texts.text) + 1).ToString();
        PlayerPrefs.SetString("Money", texts.text);
    }
}
