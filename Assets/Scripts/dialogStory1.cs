using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class dialogStory1 : MonoBehaviour
{
    public Story story;
    public DialogManager1 dialogManager1;

    // Start is called before the first frame update
    void Start()
    {
        story = dialogManager1.story;
    }

    // Update is called once per frame
    void Update()
    {
        Talk1();
    }


    public void Talk1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogManager1.refresh();
        }
    }
}
