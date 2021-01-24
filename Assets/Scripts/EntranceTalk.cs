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
    public List<string> tags;

    public bool closedIntroTalkPanel = false;

    // Start is called before the first frame update
    void Start()
    {
        //  story = dialogManager1.story;
        introPause();
        Debug.Log("lkj");
    }

    // Update is called once per frame
    void Update()
    {
        Talk1();
        //        closeIntroTalkPanel();
       // tagsTags();
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

    public void talkkkk()
    {
        Debug.Log("sdlfkjslkj");
    }


    public void tagsTags()
    {
       // tags = dialogManager1.story.currentTags;

        if (tags.Contains("endScene"))
        {
            Debug.Log("ending the scene");
            talkPanel.SetActive(false);
            btnBlockerPanel.SetActive(false);
            closedIntroTalkPanel = true;
        }
    }




    //objects to investigate

    public void westernCivLook()
    {
        Debug.Log("testingButton");
        talkPanel.SetActive(true);
        btnBlockerPanel.SetActive(true);
        dialogManager1.story.ChoosePathString("westernCiv");
        // dialogManager1.story.Continue();


    }
}
