using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LightsOn1 : MonoBehaviour
{
    public GameObject[] rooms;

    public Locked locked;

    //ROOMS
    //living room
    public GameObject lightRoom;
    public GameObject noLightRoom;
    //mid living room 
    public GameObject midNoLightRoom;
    public GameObject midLightRoom;
    //living room table
    public GameObject livingTableNoLight;
    public GameObject livingTableLight;
    //dining room
    public GameObject diningRoomNoLight;
    public GameObject diningRoomLight;
    //bookshelf
    public GameObject bookshelfLight;
    public GameObject bookshelfNoLight;
    //mid-dining room
    public GameObject midDiningLightRoom;
    public GameObject midDiningDarkRoom;
    public GameObject midDiningTableDark;
    public GameObject midDiningTableLight; 
    //kitchen
    public GameObject kitchenDarkDark;
    public GameObject kitchenDarkLight;
    public GameObject kitchenLightDark;
    public GameObject kitchenLightLight;
    //kitchenPicture
    public GameObject kitchenPictureDark;
    public GameObject kitchenPictureLight; 
    //bathroomIntro
    public GameObject bathIntroLight;
    public GameObject bathIntroDark;
    //bathroom
    public GameObject bathroomDark;
    public GameObject bathroomLight;
    //bedroom
    public GameObject bedRoomBedDark;
    public GameObject bedRoomBedLight;
    //bedRoomComp
    public GameObject bedRoomCompLight;
    public GameObject bedRoomCompDark; 
    //tub
    public GameObject tubRoom; 

    //ARROWS
    //living room arrows
    public GameObject rightArrow1;
    public GameObject leftArrow1;
    public GameObject upArrow1;
    public GameObject rightArrow2;
    public GameObject leftArrow2;
    //mid dining room arrows
    public GameObject midDiningToDiningArrow;
    public GameObject midDiningToKitchenArrow;
    //dining room arrows
    public GameObject toMidDiningArrow;
    public GameObject toMidDiningArrowLight;
    //kitchen arrows
    public GameObject kitchenToMidDiningArrow;
    public GameObject kitchenToBathroomArrow;
    public GameObject kitchenPictureArrow; 
    //bathroom arrows
    public GameObject bathIntroRightArrow;
    public GameObject bathIntroUpArrow;
    //deep bathroom arrows
    public GameObject bathRoomRightArrow;
    public GameObject bathroomToTubArrow;
    public GameObject bathroomToIntroArrow; 
    //tub arrows
    public GameObject tubArrow;
    //bedRoomBed
    public GameObject bedRoomBedRightArrow;
    public GameObject bedRoomBedLeftArrow;
    //bedRoomComp
    public GameObject bedRoomCompRightArrow; 

    public GameObject diningTableBackBtn;


    //BUTTONS
    //living rooom
    public Button lampDarkBtn;
    public Button deskDarkBtn;
    public Button tableDarkBtn;
    public Button beachBoysBtn;
    public Button goToDiningRoomArrow;
    //lights - dining room
    public Button bookshelfLightBtn;
  //  public Button diningRoomLightLamp;
    public Button diningTableBtn;
    //nolights - dining room
    public Button diningRoomLampDark;
    public Button bookshelfDarkBtn;
    public Button carverBook;
    //lights - kitchen
    public Button kitchenLightBtn;
    public Button kitchenPictureBtn; 
    //lights - bathroom
    public Button bathIntroLightsBtn;
    //lights - bedRoom
    public Button bedRoomBedLightsBtn;
    //livingroom table buttons
    public Button westernCivButton;
    

    //BOOLS
    public bool livingRoomLightsOn = false;
    public bool diningRoomLightsOn = false;
    public bool kitchenRoomLightsOn = false;
    public bool bathRoomLightsOn = false;
    public bool bedRoomBedLightsOn = false;
    public bool haveKey = false; 
    
    // Start is called before the first frame update
    void Start()
    {
        rightArrow1.SetActive(true);
        livingRoomLightsOn = false;
        diningRoomLightsOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    //MOVE TO OTHER ROOMS
    public void goToDiningRoom()
    {
        roomClearing();

        lampDarkBtn.gameObject.SetActive(false);
        deskDarkBtn.gameObject.SetActive(false);
        tableDarkBtn.gameObject.SetActive(false);
        goToDiningRoomArrow.gameObject.SetActive(false);
        diningRoomLampDark.gameObject.SetActive(true);
        bookshelfLight.gameObject.SetActive(false);
        bookshelfNoLight.gameObject.SetActive(false);
        bookshelfDarkBtn.gameObject.SetActive(true);
        midDiningLightRoom.SetActive(false);
        midDiningDarkRoom.SetActive(false);
        kitchenToBathroomArrow.SetActive(false);
        kitchenToMidDiningArrow.SetActive(false);
        beachBoysBtn.gameObject.SetActive(false);
        rightArrow1.SetActive(false);
        leftArrow1.SetActive(true);
        leftArrow2.SetActive(false);
        toMidDiningArrow.SetActive(true);
        bookshelfLightBtn.gameObject.SetActive(false);
        carverBook.gameObject.SetActive(false);



        if (!diningRoomLightsOn)
        {
            diningRoomNoLight.SetActive(true);
        }

        if (diningRoomLightsOn)
        {
            diningRoomLight.SetActive(true);
        }  
    }

    public void goToMidDining()
    {
        roomClearing();

        goToDiningRoomArrow.gameObject.SetActive(false);
        diningRoomLampDark.gameObject.SetActive(false);
        bookshelfLight.gameObject.SetActive(false);
        bookshelfNoLight.gameObject.SetActive(false);
        bookshelfDarkBtn.gameObject.SetActive(false);
        kitchenLightLight.SetActive(false);
        kitchenLightDark.SetActive(false);
        kitchenDarkDark.SetActive(false);
        kitchenDarkLight.SetActive(false);
        kitchenPictureBtn.gameObject.SetActive(false);
        diningTableBackBtn.gameObject.SetActive(false);
       // diningTableBtn.gameObject.SetActive(false);
        leftArrow1.SetActive(false);
        midDiningToDiningArrow.SetActive(true);
        midDiningToKitchenArrow.SetActive(true);
        toMidDiningArrow.SetActive(false);
        toMidDiningArrowLight.SetActive(false);
        diningTableBtn.gameObject.SetActive(true);
        kitchenLightBtn.gameObject.SetActive(false);
        bookshelfLightBtn.gameObject.SetActive(false);
        carverBook.gameObject.SetActive(false);
       // diningTableBtn.gameObject.SetActive(false);



        if (!diningRoomLightsOn)
        {
            midDiningDarkRoom.SetActive(true);
          //  diningTableBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-29, -320, 0);
        }

        if (diningRoomLightsOn)
        {
            midDiningLightRoom.SetActive(true);
        //    diningTableBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-29, -320, 0);

        }
    }

    public void goToLivingRoom()
    {
        roomClearing();

        goToDiningRoomArrow.gameObject.SetActive(true);
        lampDarkBtn.gameObject.SetActive(true);
        deskDarkBtn.gameObject.SetActive(true);
        tableDarkBtn.gameObject.SetActive(true);
        diningRoomLampDark.gameObject.SetActive(false);
        bookshelfDarkBtn.gameObject.SetActive(false);
        bookshelfLightBtn.gameObject.SetActive(false);
        westernCivButton.gameObject.SetActive(false);
        leftArrow1.SetActive(false);
        rightArrow1.SetActive(true);
        upArrow1.SetActive(false);
        rightArrow2.SetActive(false);
        toMidDiningArrow.SetActive(false);
        toMidDiningArrowLight.SetActive(false);


        if (livingRoomLightsOn)
        {
            lightRoom.SetActive(true);
        }

        if (!livingRoomLightsOn)
        {
            noLightRoom.SetActive(true);

        }
    }

    public void kitchen()
    {
        roomClearing();

        midDiningToDiningArrow.SetActive(false);
        midDiningToKitchenArrow.SetActive(false);
        kitchenPictureArrow.SetActive(false);
        kitchenToMidDiningArrow.SetActive(true);
        kitchenToBathroomArrow.SetActive(true);
        kitchenPictureBtn.gameObject.SetActive(true);
        diningTableBtn.gameObject.SetActive(false);
        bathIntroRightArrow.SetActive(true);
        bathIntroUpArrow.SetActive(true);
        kitchenLightBtn.gameObject.SetActive(true);
        


        if (kitchenRoomLightsOn && !diningRoomLightsOn)
        {
            kitchenDarkLight.SetActive(true);
        }

        if (kitchenRoomLightsOn & diningRoomLightsOn)
        {
            kitchenLightLight.SetActive(true);

        }

        if (!kitchenRoomLightsOn && !diningRoomLightsOn)
        {
            kitchenDarkDark.SetActive(true);

        }

        if (!kitchenRoomLightsOn && diningRoomLightsOn)
        {
            kitchenLightDark.SetActive(true);

        }
    }

    public void goToBathIntro()
    {
        roomClearing();

        kitchenLightLight.SetActive(false);
        kitchenLightDark.SetActive(false);
        kitchenDarkDark.SetActive(false);
        kitchenDarkLight.SetActive(false);
        kitchenLightBtn.gameObject.SetActive(false);
        kitchenToBathroomArrow.SetActive(false);
        kitchenToMidDiningArrow.SetActive(false);
        kitchenPictureBtn.gameObject.SetActive(false);
        bathIntroRightArrow.SetActive(true);
        bathIntroUpArrow.SetActive(true);
        bathIntroLightsBtn.gameObject.SetActive(true);
 

        if (bathRoomLightsOn)
        {
            bathIntroLight.SetActive(true);

        }

        if (!bathRoomLightsOn)
        {
            bathIntroDark.SetActive(true);

        }
    }

    public void goToBathroomRoom()
    {
        roomClearing();

        bathIntroRightArrow.SetActive(false);
        bathIntroUpArrow.SetActive(false);
        bathIntroLightsBtn.gameObject.SetActive(false);
        tubArrow.gameObject.SetActive(false);
        bathRoomRightArrow.SetActive(true);
        bathroomToTubArrow.SetActive(true);
        bathroomToIntroArrow.SetActive(true);
        bedRoomBedLeftArrow.gameObject.SetActive(false);
        bedRoomBedRightArrow.gameObject.SetActive(false);
        bedRoomBedLightsBtn.gameObject.SetActive(false);


        if (!bathRoomLightsOn)
        {
            bathroomDark.SetActive(true);
            bathroomLight.SetActive(false);
        }
        else if (bathRoomLightsOn)
        {
            bathroomDark.SetActive(false);
            bathroomLight.SetActive(true);
        }
    }

    public void goToTub()
    {
        roomClearing();
        bathRoomRightArrow.SetActive(false);
        bathroomToTubArrow.SetActive(false);
        tubRoom.SetActive(true);
        tubArrow.gameObject.SetActive(true);
        bathroomToIntroArrow.gameObject.SetActive(false);
    }

    public void goToBedRoomBed()
    {

        if (haveKey)
        {
            roomClearing();

            bathRoomRightArrow.SetActive(false);
            bathroomToTubArrow.SetActive(false);
            bathroomToIntroArrow.SetActive(false);
            bedRoomBedLightsBtn.gameObject.SetActive(true);
            Debug.Log("gotoRoom");
            bedRoomBedLeftArrow.gameObject.SetActive(true);
            bedRoomBedRightArrow.gameObject.SetActive(true);
            bedRoomCompRightArrow.gameObject.SetActive(false);


            if (!bedRoomBedLightsOn)
            {
                bedRoomBedDark.SetActive(true);
                bedRoomBedLight.SetActive(false);
            }
            else if (bedRoomBedLightsOn)
            {
                bedRoomBedLight.SetActive(true);
                bedRoomBedDark.SetActive(false);
            }
        }

        else if (!haveKey)
        {
            Debug.Log("the door is locked!");
            locked.lockedDoor();
        }
    }

    public void goToBedRoomComp()
    {
        roomClearing();

        bedRoomBedLeftArrow.gameObject.SetActive(false);
        bedRoomBedRightArrow.gameObject.SetActive(false);
        bedRoomCompRightArrow.gameObject.SetActive(true);
        bedRoomBedLightsBtn.gameObject.SetActive(false);


        if (!bedRoomBedLightsOn)
        {
            bedRoomCompDark.SetActive(true);
            bedRoomCompLight.SetActive(false);
        }
        else if (bedRoomBedLightsOn)
        {
            bedRoomCompLight.SetActive(true);
            bedRoomCompDark.SetActive(false);
        }
    }
    //MOVE TO OTHER ROOMS

    //LIGHTS MANAGEMENT
    public void livingRoomLights()
    {
        
        if (!livingRoomLightsOn)
        {
           lightRoom.SetActive(true);
            noLightRoom.SetActive(false);
            livingRoomLightsOn = true;
            Debug.Log("lightson");
            
            lampDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-300, 208, 0);
            deskDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(467, 160, 0);
            tableDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-29, -47, 0);
            beachBoysBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-393, 160, 0);

        }
        else if (livingRoomLightsOn)
        {
            lightRoom.SetActive(false);
            noLightRoom.SetActive(true);
            livingRoomLightsOn = false;
            Debug.Log("lligtsoff");
            
            lampDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-330, 243, 0);
            deskDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(450, 180, 0);
            beachBoysBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-415, 184, 0);
            tableDarkBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-40, -28 ,0);


        }

    }
        

    public void diningRoomLights()
    {
        if (!diningRoomLightsOn)
        {
            diningRoomLight.SetActive(true);
            diningRoomNoLight.SetActive(false);
            diningRoomLightsOn = true;
            Debug.Log("lightson");

            //bookshelf
            bookshelfLightBtn.gameObject.SetActive(true);
            bookshelfDarkBtn.gameObject.SetActive(false);

            //lamp
            //   diningRoomLampDark.gameObject.SetActive(false);
            //   diningRoomLightLamp.gameObject.SetActive(true);
            diningRoomLampDark.transform.GetComponent<RectTransform>().localPosition = new Vector3(288, 183, 0);


            //upArrow

            toMidDiningArrowLight.SetActive(true);
            toMidDiningArrow.SetActive(false);
        }
        else if (diningRoomLightsOn)
        {
            diningRoomLight.SetActive(false);
            diningRoomNoLight.SetActive(true);
            diningRoomLightsOn = false;
            Debug.Log("lligtsoff");

            //bookshelf
            bookshelfLightBtn.gameObject.SetActive(false);
            bookshelfDarkBtn.gameObject.SetActive(true);

            //lamp
            //  diningRoomLampDark.gameObject.SetActive(true);
            //   diningRoomLightLamp.gameObject.SetActive(false);
            diningRoomLampDark.transform.GetComponent<RectTransform>().localPosition = new Vector3(182, 197, 0);

            //upArrow

            toMidDiningArrow.SetActive(true);
            toMidDiningArrowLight.SetActive(false);

        }
    }

    public void kitchenLights()
    {


        if (!diningRoomLightsOn)
        {
            if (!kitchenRoomLightsOn)
            {
                kitchenDarkLight.SetActive(true);
                kitchenDarkDark.SetActive(false);
                kitchenRoomLightsOn = true;
                Debug.Log("kitchenLightdDarkLight");
                kitchenPictureBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(63, 155, 0);
            }

            else if (kitchenRoomLightsOn)
            {
                kitchenDarkDark.SetActive(true);
                kitchenDarkLight.SetActive(false);
                kitchenRoomLightsOn = false;
                Debug.Log("kitchenLightDarkDark");
                kitchenPictureBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-10, 67, 0);
            }
        }


        else if (diningRoomLightsOn)
        {
            if (!kitchenRoomLightsOn)
            {
                kitchenLightLight.SetActive(true);
                kitchenLightDark.SetActive(false);
                kitchenRoomLightsOn = true;
                Debug.Log("kitchenlightlight");
                kitchenPictureBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(74, 168, 0);
            }

            else if (kitchenRoomLightsOn)
            {
                kitchenLightDark.SetActive(true);
                kitchenLightLight.SetActive(false);
                kitchenRoomLightsOn = false;
                Debug.Log("kitchenlightdark");
                kitchenPictureBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(15, 134, 0);
            }
        }
    }

    public void bathIntroLightWorks()
    {
        if (!bathRoomLightsOn)
        {
            bathIntroDark.SetActive(false);
            bathIntroLight.SetActive(true);
            Debug.Log("lights on");
            bathRoomLightsOn = true;
            bathIntroLightsBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-244, 280, 0);
        }

        else if (bathRoomLightsOn)
        {
            bathIntroDark.SetActive(true);
            bathIntroLight.SetActive(false);
            Debug.Log("ligtsOff");
            bathRoomLightsOn = false;
            bathIntroLightsBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-300, 233, 0);
        }
    }


    public void bedRoomLightWorks()
    {

        if (!bedRoomBedLightsOn)
        {
            bedRoomBedDark.SetActive(false);
            bedRoomBedLight.SetActive(true);
            Debug.Log("lights on");
            bedRoomBedLightsOn = true;
            bedRoomBedLightsBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-529, -42, 0);

        }

        else if (bedRoomBedLightsOn)
        {
            bedRoomBedLight.SetActive(false);
            bedRoomBedDark.SetActive(true);
            Debug.Log("ligtsOff");
            bedRoomBedLightsOn = false;
            bedRoomBedLightsBtn.transform.GetComponent<RectTransform>().localPosition = new Vector3(-678, -58, 0);

        }
    }
    //LIGHTS MANAGEMENT



    //ROOM BACKGROUND PICTURE CLEARING FUNCTION
    public void roomClearing()
    {
        foreach (GameObject room in rooms)
        {
            room.SetActive(false);
        }
    }
    //ROOM BACKGROUND PICTURE CLEARING FUNCTION



    //BUTTONS TO INVESTIGATE THINGS

    //LIVINGROOM
    public void deskView()
    {
        roomClearing();

        lampDarkBtn.gameObject.SetActive(false);
        tableDarkBtn.gameObject.SetActive(false);
        goToDiningRoomArrow.gameObject.SetActive(false);
        deskDarkBtn.gameObject.SetActive(false);
        rightArrow2.SetActive(true);


        if (livingRoomLightsOn)
        {
            midLightRoom.SetActive(true);
        }

        if (!livingRoomLightsOn)
        {
            midNoLightRoom.SetActive(true);
        }
    }

    public void tableViewing()
    {
        roomClearing();

        lampDarkBtn.gameObject.SetActive(false);
        deskDarkBtn.gameObject.SetActive(false);
        tableDarkBtn.gameObject.SetActive(false);
        goToDiningRoomArrow.gameObject.SetActive(false);
        upArrow1.SetActive(true);
        rightArrow1.SetActive(false);


        if (livingRoomLightsOn)
        {
            livingTableLight.SetActive(true);
            westernCivButton.gameObject.SetActive(true);
            westernCivButton.transform.GetComponent<RectTransform>().localPosition = new Vector3(-254, -46, 0);
        }

        if (!livingRoomLightsOn)
        {
            livingTableNoLight.SetActive(true);
            westernCivButton.gameObject.SetActive(true);
            westernCivButton.transform.GetComponent<RectTransform>().localPosition = new Vector3(-254, -31, 0);
        }
    }
    //LIVINGROOM


    //DININGROOM
    public void bookshelf()
    {
        roomClearing();

        leftArrow1.SetActive(false);
        leftArrow2.SetActive(true);
        toMidDiningArrow.SetActive(false);
        toMidDiningArrowLight.SetActive(false);


        if (diningRoomLightsOn)
        {
            bookshelfLight.gameObject.SetActive(true);
        }

        if (!diningRoomLightsOn)
        {
            bookshelfNoLight.gameObject.SetActive(true);
        }
    }

    public void midDiningTable()
    {
        roomClearing();
        diningTableBackBtn.gameObject.SetActive(true);
        midDiningToDiningArrow.SetActive(false);
        midDiningToKitchenArrow.SetActive(false);
        carverBook.gameObject.SetActive(true);
        diningTableBtn.gameObject.SetActive(false);



        if (diningRoomLightsOn)
        {
            midDiningTableLight.SetActive(true);
        }

        else if (!diningRoomLightsOn)
        {
            midDiningTableDark.SetActive(true);
        }
    }
    //DININGROOM


    //GETKEY

    public void getKey()
    {
        haveKey = true;
        Debug.Log("hasKey");
        locked.gotKey();
    }


    //KITCHEN
    
    public void kitchenPictureView()
    {
        roomClearing();
        kitchenPictureArrow.SetActive(true);
        kitchenToBathroomArrow.SetActive(false);
        kitchenToMidDiningArrow.SetActive(false);
        kitchenLightBtn.gameObject.SetActive(false);


        if (kitchenRoomLightsOn)
        {
            kitchenPictureLight.SetActive(true);
        }

        else if (!kitchenRoomLightsOn)
        {
            kitchenPictureDark.SetActive(true);
        }
    }
    //KITCHEN
}
