using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuButtons : MonoBehaviour
{

    public Button startButton;
    public Button optionsButton;
    public Button quitButton; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("LivingRoom");
    }

    public void quittingGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}
