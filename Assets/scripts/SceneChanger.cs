using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SceneChanger : MonoBehaviour
{

 
        public void CowSkeletonButtonEvent()
    {
       Screen.orientation = ScreenOrientation.LandscapeLeft;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Back()
    {
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

      public void BackForTrainingMode()
    {
       Screen.orientation = ScreenOrientation.Portrait;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

    public void AxisC2Event()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    

    public void ArEvent()
    {
      Screen.orientation = ScreenOrientation.Portrait;
      SceneManager.LoadScene(3);
    }

    public void toTheFirstQuestionEvent(){
        Screen.orientation = ScreenOrientation.Portrait;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
    }

    public void nextQuestion()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Reset() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    public void trainingQAR() => SceneManager.LoadScene(4);

    

    public void MainMenu()
    {
      Screen.orientation = ScreenOrientation.Portrait;
      SceneManager.LoadScene(0);
    }
        public void toTheAboutUs()
        {
        Screen.orientation = ScreenOrientation.Portrait;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +6);
    }

    public void toTheReources()
    {
        Screen.orientation = ScreenOrientation.Portrait;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +7);
    }

    public void ToBosInformation() => SceneManager.LoadScene(2);
    

    public void ToCanisInformation() => SceneManager.LoadScene(9);
   

    public void ToOvisInformation() =>SceneManager.LoadScene(8);
   

    public void ToCowMAIN() => SceneManager.LoadScene(1);

    public void toTheFirstQuestion() => SceneManager.LoadScene(4);

    //public void BackFromAREvent () => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);



    public void NewLoadMainFromARQ1() => SceneManager.LoadScene("MainMenu");
    public void NewLoadCowMTinfoFromARbuttons()=> SceneManager.LoadScene("CowMetatarsusInfo");
    
     public void NewLoadARq1FromARQ2() => SceneManager.LoadScene("AR_question1");
    
  

}
