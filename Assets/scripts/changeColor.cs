using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangingColor : MonoBehaviour
{
   public GameObject uiObject;
    
    void Start()
    {
       uiObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
           Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
           RaycastHit hit;

           if(Physics.Raycast(ray, out hit))
           {
              if(hit.transform.tag == "ChangeColor")
              {
                Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                hit.collider.GetComponent<MeshRenderer>().material.color = newColor;
                uiObject.SetActive(true);
              }
           }
           if(Input.touches[0].phase == TouchPhase.Ended)
           {
             StartCoroutine("WaitForSec");
           }
        }
       
    }
  
  IEnumerator WaitForSec()
  {
   yield return new WaitForSeconds(5);
   Destroy(uiObject);
  }
}
