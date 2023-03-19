using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class LightEstimation : MonoBehaviour
{
    [SerializeField]
    private ARCameraManager aRCameraManager;

   
    private Text brightnessValue;

    

    private Text tempValue;

    

    private Text colorCorrectionValue;

    private Light currentLight;

    private void Awake(){
        currentLight = GetComponent<Light>();
    }

    private void OnEnable()
    {
        aRCameraManager.frameReceived += FrameUpdated;

        if(aRCameraManager==null)
        return;
    }

    private void OnDisable()
    {

        aRCameraManager.frameReceived -= FrameUpdated;
        if(aRCameraManager==null)
        return;
    }

    private void FrameUpdated(ARCameraFrameEventArgs args)
    {
       if(args.lightEstimation.averageBrightness.HasValue)
       {
          
          brightnessValue.text = $"Brightnes: {args.lightEstimation.averageBrightness.Value}";
           currentLight.intensity = args.lightEstimation.averageBrightness.Value;
       }

       if(args.lightEstimation.averageColorTemperature.HasValue)
       {
           
           tempValue.text = $"Temp: {args.lightEstimation.averageColorTemperature.Value}";
           currentLight.colorTemperature = args.lightEstimation.averageColorTemperature.Value;
       }

       if(args.lightEstimation.colorCorrection.HasValue)
       {
        
           colorCorrectionValue.text = $"Color: {args.lightEstimation.colorCorrection.Value}";
           currentLight.color = args.lightEstimation.colorCorrection.Value;
       
       }
    
    
    }



}
