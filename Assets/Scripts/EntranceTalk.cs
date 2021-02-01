using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class EntranceTalk : MonoBehaviour
{
    //  public Story story;
    public DialogManager1 dialogManager1;
    public GameObject talkPanel;
    public GameObject btnBlockerPanel;


    // Start is called before the first frame update
    void Start()
    {
        introPause();
        Debug.Log("started");
    }

    // Update is called once per frame
    void Update()
    {
        Talk1();
    }


    public void introPause()
    {
        StartCoroutine(introPauseEnumerator());
    }

    IEnumerator introPauseEnumerator()
    {
        yield return new WaitForSeconds(3);
        talkPanel.SetActive(true);
        Debug.Log("introPause");
        dialogManager1.refresh();

    }


    public void Talk1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogManager1.refresh();
        }
    }


    //objects to investigate

    public void westernCivLook()
    {
        Debug.Log("testingButton");
        talkPanel.SetActive(true);
        btnBlockerPanel.SetActive(true);
        dialogManager1.story.ChoosePathString("westernCiv");
        dialogManager1.refresh();
       // dialogManager1.story.Continue();
    }

    public void beachBoysRecord1()
    {
        Debug.Log("testingButton");
        talkPanel.SetActive(true);
        btnBlockerPanel.SetActive(true);
        dialogManager1.story.ChoosePathString("beachBoys1");
        dialogManager1.refresh();
    }
}
