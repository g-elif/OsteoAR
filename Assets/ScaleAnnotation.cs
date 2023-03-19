using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleAnnotation : MonoBehaviour
{
    public TextMeshPro scaleText;
    private Vector3 referantScale;
    void Start()
    {
        referantScale = new Vector3(1,1,1);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 actualScale = gameObject.transform.localScale;
        float percent = actualScale.x / referantScale.x;
        string label = $"{(percent * 100f).ToString("F0")}%";
        scaleText.text = label;
    }
}
