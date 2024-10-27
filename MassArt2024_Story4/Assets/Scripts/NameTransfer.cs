using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class NameTransfer : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    //public GameHandler gameHandler;
    public GameObject welcomeDisplay;

    void Start()
    {
        welcomeDisplay.SetActive(true);
    }

    public void StoreName()
    {
        theName = inputField.GetComponentInChildren<TMP_Text>().text;
        textDisplay.GetComponent<TMP_Text>().text = "Welcome, " + theName + ", to the neighborhood!";
        welcomeDisplay.SetActive(true);
        //gameHandler.UpdateName(theName);
        GameHandler.playerName = theName;
    }
}