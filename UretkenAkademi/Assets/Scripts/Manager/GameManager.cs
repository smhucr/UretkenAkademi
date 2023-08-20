using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI[] showLabels;
    [Serializable]
    public struct Users
    {
        [SerializeField] public float unityLikeValue;
        [SerializeField] public string gender;
        [SerializeField] public bool isGameDeveloper;
        [SerializeField] public string name;
        [SerializeField] public string surname;
        [SerializeField] public string schoolName;
        [SerializeField] public int age;
        [SerializeField] public string hobby;
    }

    [SerializeField] public Users[] users = null;

    private void Start()
    {
        showLabels[0].text = PlayerPrefs.GetString("NAME");
        showLabels[1].text = PlayerPrefs.GetString("SURNAME");
        showLabels[2].text = PlayerPrefs.GetString("AGE");
        showLabels[3].text = PlayerPrefs.GetString("GENDER");
        showLabels[4].text = PlayerPrefs.GetString("SCHOOLNAME");
        showLabels[5].text = PlayerPrefs.GetString("UNITY");
        showLabels[6].text = PlayerPrefs.GetString("HOBBY");
    }

    private void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }

    private void Awake()
    {
        MakeInstance();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("HomeW4");
    }
}