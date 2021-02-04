using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class Locked : MonoBehaviour
{
    //  public Story story;
    public DialogManager1 dialogManager1;
    public GameObject talkPanel;
    public GameObject btnBlockerPanel;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }




    public void lockTalk1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogManager1.refresh();
        }
    }

    public void lockedDoor()
    {
        Debug.Log("lockedDoooooor");
        talkPanel.SetActive(true);
        btnBlockerPanel.SetActive(true);
        dialogManager1.story.ChoosePathString("locked");
        dialogManager1.refresh();
    }


    public void gotKey()
    {
        talkPanel.SetActive(true);
        btnBlockerPanel.SetActive(true);
        dialogManager1.story.ChoosePathString("foundKey");
        dialogManager1.refresh();
    }
}
