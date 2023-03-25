using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenechange_DD : MonoBehaviour
{
    public Button goBackButton;
    // Start is called before the first frame update
    void Start()
    {
        goBackButton.onClick.AddListener(GoToWelcome);
        
    }
    void GoToWelcome()
    {
       SceneManager.LoadScene("WelcomeScreen");
    }

    
}
