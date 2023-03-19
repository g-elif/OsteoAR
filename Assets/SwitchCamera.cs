using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchCamera : MonoBehaviour
{
  
  public Camera camTop;
  public Camera camBottom;
  public Camera camRight;
  public Camera camLeft;
  
  
  Camera m_MainCamera;
  void Start(){
    m_MainCamera = Camera.main;
    m_MainCamera.enabled = true;
    camTop.enabled = false;
    camBottom.enabled = false;
    camRight.enabled = false;
    camLeft.enabled = false;
    


  }
  
   public void OnTOP()
   {
    m_MainCamera.enabled = false;
    camTop.enabled = true;
    camBottom.enabled = false;
    camRight.enabled = false;
    camLeft.enabled = false;
    
   }  

   public void OnBottom()
   {
        m_MainCamera.enabled = false;
    camTop.enabled = false;
    camBottom.enabled = true;
    camRight.enabled = false;
    camLeft.enabled = false;
    
   }
   public void OnRight()
   {
         m_MainCamera.enabled = false;
    camTop.enabled = false;
    camBottom.enabled = false;
    camRight.enabled = true;
    camLeft.enabled = false;
  
   }
   public void OnLeft()
   {
         m_MainCamera.enabled = false;
    camTop.enabled = false;
    camBottom.enabled = false;
    camRight.enabled = false;
    camLeft.enabled = true;
    
   }

 

   }
