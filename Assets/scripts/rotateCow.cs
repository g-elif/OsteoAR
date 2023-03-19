using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateCow : MonoBehaviour
{
    public float RotationSpeed = 10f;
    //public float MobileRotationSpeed = 0.4f;
    public Camera cam;
    

    void OnMouseDrag(){
        float rotX = Input.GetAxis("Mouse X") * RotationSpeed;
        float rotY = Input.GetAxis("Mouse Y") * RotationSpeed;

        Vector3 right = Vector3.Cross(cam.transform.up, transform.position - cam.transform.position);
        Vector3 up = Vector3.Cross(transform.position - cam.transform.position, right);

        transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation = Quaternion.AngleAxis(-rotY, right) * transform.rotation;
    }

   
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
             Debug.Log("Touching at " + touch.position);
             Ray camRay = cam.ScreenPointToRay (touch.position);
             RaycastHit raycastHit;

             if(Physics.Raycast (camRay, out raycastHit, 10))
             {
                 if (touch.phase == TouchPhase.Began)
                 {
                    Debug.Log("Touch phase began at: " + touch.position);
                    
                 }
             else if (touch.phase == TouchPhase.Moved)
             {
                     Debug.Log("Touch phase moved");
                     transform.Rotate(-touch.deltaPosition.y* RotationSpeed * Time.deltaTime, -touch.deltaPosition.x* RotationSpeed*Time.deltaTime,0, Space.Self);
                     
             }    
             else if(touch.phase == TouchPhase.Ended)
             {
                Debug.Log("Touch phase ended");
                
             }
             }
        }
    }
}
