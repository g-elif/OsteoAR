using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class PlaceIndicator4 : MonoBehaviour
{
    private ARRaycastManager raycastManager;
 
    private GameObject indicator;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();


    void Start()
    {
        raycastManager = FindObjectOfType<ARRaycastManager>();
        indicator = transform.GetChild(0).gameObject;
        indicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Vector2(Screen.width/2, Screen.height/2);

        if (raycastManager.Raycast(ray, hits, TrackableType.Planes))
        {
              Pose hitPose = hits[0].pose;
              
              transform.position = hitPose.position;
              transform.rotation = hitPose.rotation;
             
        }

              if(!indicator.activeInHierarchy)
              {
                indicator.SetActive(true);
              }

        }
    }

