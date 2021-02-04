using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class DialogManager1 : MonoBehaviour
{
    //
    public TextAsset inkJsonAsset;

    public Story story;

    public GameObject panel1;
    public GameObject talkPanel;
    public GameObject btnBlockerPanel;

    public bool storyGoing;

    public List<string> tags;

    public Text textPanel;


    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJsonAsset.text);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //refresh UI elements
    //clear any current elemenst
    //show any text chunks
      
    public void refresh()
    {
        /*
        if (story.currentChoices.Count < 1)
        {
            clearUI();
        }
        */

        if (story.canContinue)
        {
           clearUI();

            storyGoing = true;

            string text = getNextStoryBlock();

            textPanel.text = text;

            parseTags();
        }

        if(story.canContinue == false)
        {
            Debug.Log("story can't continue");
            storyGoing = false;
            clearUI();
        }
    }

    public void clearUI()
    {
        textPanel.text = "";
    }

    //load and potentially return the next story block
    string getNextStoryBlock()
    {
        string text = "";

        if (story.canContinue)
        {
            text = story.Continue();
        }
        else
        {
        }
        return text;
    }



    //tag parser
    public void parseTags()
    {
        tags = story.currentTags;

        if (tags.Contains("dog"))
        {
            Debug.Log("doggie");
        }

        if (tags.Contains("endScene"))
        {
            Debug.Log("ending the scene");
            talkPanel.SetActive(false);
            btnBlockerPanel.SetActive(false);
        }
    }
}
