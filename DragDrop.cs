using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragDrop : MonoBehaviour
{
    public GameObject objectToDrag;
    public GameObject objectDragToPos;
    public Button goBackButton;

    public float DropDistance;

    public bool isLocked;

    Vector2 objectInitPos;

    // Start is called before the first frame update
    void Start()
    {
       // goBackButton.onClick.AddListener(GoToWelcome);

        objectInitPos = objectToDrag.transform.position;
    }
    /*
    void GoToWelcome()
    {
       SceneManager.LoadScene("WelcomeScreen");
    }
    */

    public void DragObject()
    {
         if(!isLocked)
         {
            objectToDrag.transform.position = Input.mousePosition;
         }
    }

    public void DropObject()
    {
        float Distance = Vector3.Distance(objectToDrag.transform.position ,objectDragToPos.transform.position);
        if(Distance<=DropDistance)
        {
            isLocked = true;
            objectToDrag.transform.position = objectDragToPos.transform.position; 
        }
        else
        {
            objectToDrag.transform.position = objectInitPos;
        }

    }

    

    
}
