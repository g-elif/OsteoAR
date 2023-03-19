using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeButtonColor : MonoBehaviour
{
    public Color greenColor;
    public Color redColor;
    public Button CorrectAnswer;
    public Button WrongAnswer1;
    public Button WrongAnswer2;
    public Button WrongAnswer3;
  
   
    

    public void ChangeButtonColorGreen()
    {
      CorrectAnswer.GetComponent<Image>().color = greenColor;

    }
     public void ChangeButtonColorRed() 
     {
      WrongAnswer1.GetComponent<Image>().color = redColor;
      WrongAnswer2.GetComponent<Image>().color = redColor;
      WrongAnswer3.GetComponent<Image>().color = redColor;
      }
}
