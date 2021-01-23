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
    public Text textPanel;
    public List<string> tags;
    public bool storyGoing;
    

    //scripts called and related to this one within here and otherwise

    // public dialogStory1 dialogStory1;


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
            parseTags();

            storyGoing = true;

            string text = getNextStoryBlock();

            textPanel.text = text;
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

        if (tags.Contains("buttonsOn"))
        {
            Debug.Log("scene Ended");
        }
    }

}
