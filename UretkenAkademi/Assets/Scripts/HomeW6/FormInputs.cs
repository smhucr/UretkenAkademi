using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FormInputs : MonoBehaviour
{

    public GameObject mainPanel;
    public GameObject formPanel;
    public GameObject answerPanel;
    public GameObject saveButton;

    public TextMeshProUGUI[] showLabels;

    public void SetUnityLikeValue(float likeValue)
    {
        GameManager.instance.users[0].unityLikeValue = likeValue;
    }

    public void SetGender(int index)
    {
        if (index == 0)
            GameManager.instance.users[0].gender = "Undefined";
        else if (index == 1)
            GameManager.instance.users[0].gender = "Girl";
        else
            GameManager.instance.users[0].gender = "Boy";
    }

    public void SetBeforeGameDevelopment(bool isGameDeveloper)
    {
        GameManager.instance.users[0].isGameDeveloper = isGameDeveloper;
    }

    public void SetName(string name)
    {
        GameManager.instance.users[0].name = name;
    }

    public void SetSurname(string surname)
    {
        GameManager.instance.users[0].surname = surname;
    }

    public void SetSchool(string schoolName)
    {
        GameManager.instance.users[0].schoolName = schoolName;
    }

    public void SetAge(string ageString)
    {
        GameManager.instance.users[0].age = int.Parse(ageString);
    }

    public void SetHobby(string hobby)
    {
        GameManager.instance.users[0].hobby = hobby;
    }

    public void ChangeMainToFormPagePanel()
    {
        mainPanel.SetActive(false);
        formPanel.SetActive(true);
    }
    public void ChangeFormToMainPanel()
    {
        mainPanel.SetActive(true);
        formPanel.SetActive(false);
    }
    public void ChangeShowToMainPanel()
    {
        mainPanel.SetActive(true);
        answerPanel.SetActive(false);
    }
    public void ChangeMainToShowPanel()
    {
        mainPanel.SetActive(false);
        answerPanel.SetActive(true);
    }

    public void SaveForm()
    {
        formPanel.SetActive(false);
        answerPanel.SetActive(true);
        saveButton.SetActive(true);
        showLabels[0].text = "NAME : " + GameManager.instance.users[0].name;
        showLabels[1].text = "SURNAME : " + GameManager.instance.users[0].surname;
        showLabels[2].text = "AGE : " + GameManager.instance.users[0].age.ToString();
        showLabels[3].text = "GENDER : " + GameManager.instance.users[0].gender;
        showLabels[4].text = "SCHOOL NAME : " + GameManager.instance.users[0].schoolName;
        showLabels[5].text = "YOU  LIKE UNITY " + GameManager.instance.users[0].unityLikeValue.ToString() + " OF 5 ";
        showLabels[6].text = "HOBBY : " + GameManager.instance.users[0].hobby;

    }

    public void AreYouSureSave()
    {
        PlayerPrefs.SetString("NAME", "NAME : " + GameManager.instance.users[0].name);
        PlayerPrefs.SetString("SURNAME", "SURNAME : " + GameManager.instance.users[0].surname);
        PlayerPrefs.SetString("AGE", "AGE : " + GameManager.instance.users[0].age.ToString());
        PlayerPrefs.SetString("GENDER", "GENDER : " + GameManager.instance.users[0].gender);
        PlayerPrefs.SetString("SCHOOLNAME", "SCHOOL NAME : " + GameManager.instance.users[0].schoolName);
        PlayerPrefs.SetString("UNITY", "YOU  LIKE UNITY " + GameManager.instance.users[0].unityLikeValue.ToString() + " OF 5 ");
        PlayerPrefs.SetString("HOBBY", "HOBBY : " + GameManager.instance.users[0].hobby);
        PlayerPrefs.SetInt("SAVED", 1);
        answerPanel.SetActive(false);
        mainPanel.SetActive(true);
        saveButton.SetActive(false);
    }

}
