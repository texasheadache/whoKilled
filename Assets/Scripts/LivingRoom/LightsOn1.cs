using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LightsOn1 : MonoBehaviour
{

    public GameObject[] rooms;    

    public GameObject lightRoom;
    public GameObject noLightRoom;
    public GameObject midNoLightRoom;
    public GameObject midLightRoom;
    public GameObject livingTableNoLight;
    public GameObject livingTableLight;
    public GameObject middleRoomNoLight;
    public GameObject middleRoomLight;

    public Button bookshelfBtn;
    public Button lampBtn;
    public Button deskBtn;
    public Button tableLookBtn;
    public Button goToMidRoomBtn;

    public bool lightsAreOn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void lights()
    {
        Debug.Log("sdlfksdjf");
        if (!lightsAreOn)
        {
            lightRoom.SetActive(true);
            noLightRoom.SetActive(false);
            lightsAreOn = true;
            Debug.Log("lightson");
        }
        else if (lightsAreOn)
        {
            lightRoom.SetActive(false);
            noLightRoom.SetActive(true);
            lightsAreOn = false;
            Debug.Log("lligtsoff");
        }
    }

    public void roomClearing()
    {
        foreach (GameObject room in rooms)
        {
            room.SetActive(false);
        }
        Debug.Log("clear");
    }

    public void offing()
    {
        roomClearing();

        if (lightsAreOn)
        {
            midLightRoom.SetActive(true);
        }

        if (!lightsAreOn)
        {
            midNoLightRoom.SetActive(true);
        }
    }

    public void tableViewing()
    {
        roomClearing();

        if (lightsAreOn)
        {
            livingTableLight.SetActive(true);
        }

        if (!lightsAreOn)
        {
            livingTableNoLight.SetActive(true);
        }
    }

    public void goToMiddleRoom()
    {
        roomClearing();

        bookshelfBtn.gameObject.SetActive(true);
        lampBtn.gameObject.SetActive(false);
        deskBtn.gameObject.SetActive(false);
        tableLookBtn.gameObject.SetActive(false);
        goToMidRoomBtn.gameObject.SetActive(false);


        if (lightsAreOn)
        {
            middleRoomLight.SetActive(true);
        }

        if (!lightsAreOn)
        {
            middleRoomNoLight.SetActive(true);
        }
    }

    public void bookshelf()
    {
        roomClearing();

        if (lightsAreOn)
        {

        }
    }
}
