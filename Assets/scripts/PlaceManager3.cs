using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class PlaceManager3 : MonoBehaviour
{
    private PlaceIndicator3 PlaceIndicator3GameObject;
    public GameObject PlaceObjectOne;
    private GameObject newPlacedObject3;
   public GameObject myButton;

    void Start()
    {
        PlaceIndicator3GameObject= FindObjectOfType<PlaceIndicator3>();
    }




    public void ClickToPlace()
    {
        newPlacedObject3 = Instantiate(PlaceObjectOne, PlaceIndicator3GameObject.transform.position, PlaceIndicator3GameObject.transform.rotation);
        myButton.SetActive(false);
        newPlacedObject3.SetActive(true);
        Destroy (GameObject.FindWithTag("Aim")); //this doesn't work
    }

}
