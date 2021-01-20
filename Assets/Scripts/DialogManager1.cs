using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class DialogManager1 : MonoBehaviour
{

    public TextAsset inkJsonAsset;
    public Story story;
    public GameObject panel;
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

    public void refresh()
    {
        if (story.canContinue)
        {
            string text = getNextStoryBlock();

            textPanel.text = text;
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
            Debug.Log("loged");
        }
        else
        {
            //  panel.SetActive(false);
            Debug.Log("done");
            //refreshStory();
        }
        return text;
    }

}
