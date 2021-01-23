using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuButtons : MonoBehaviour
{

    public AudioSource menuTheme; 

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
        menuTheme.mute = true;
    }

    public void quittingGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}
