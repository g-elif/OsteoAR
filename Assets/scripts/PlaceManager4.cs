using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEditor;


public class PlaceManager4 : MonoBehaviour
{
    private PlaceIndicator4 PlaceIndicator2;
    public GameObject PlaceObject1;
    public GameObject PlaceObject2;
    public GameObject PlaceObject3;

    private GameObject newPlacedObject;
    
    private List<GameObject> createdObjects = new List<GameObject>();

     [SerializeField]
    private Button bos;
    [SerializeField]

    
    private Button ovisCapra;
    [SerializeField]
    private Button canis;
     [SerializeField] 
     
    private Button destroyAll;

    [SerializeField] 
     
    private GameObject welcomePanel;

    [SerializeField]
    private Button dismiss;
   
     
    void Start()
    {
        PlaceIndicator2= FindObjectOfType<PlaceIndicator4>();
    }
    
    void Awake()
    {
         
         /*bos.onClick.AddListener(() => ClickToPlace1());
         ovisCapra.onClick.AddListener(()=> ClickToPlace2());
         canis.onClick.AddListener(()=>ClickToPlace3()); */
        destroyAll.onClick.AddListener(()=>ClicktToDestroyAll());
    
    }

    public void ClickToPlace1()
    {
        newPlacedObject = Instantiate(PlaceObject1, PlaceIndicator2.transform.position, PlaceIndicator2.transform.rotation); 
    }

     public void ClickToPlace2()
    {
        newPlacedObject = Instantiate(PlaceObject2, PlaceIndicator2.transform.position, PlaceIndicator2.transform.rotation);   
    }

    public void ClickToPlace3()
    {
        newPlacedObject = Instantiate(PlaceObject3, PlaceIndicator2.transform.position, PlaceIndicator2.transform.rotation);
    }

    public void Dismiss()=> welcomePanel.SetActive(false);

    public void ClicktToDestroyAll()
    {
        GameObject[] createdObjects = GameObject.FindGameObjectsWithTag("Respawn");
        for (int i=0; i <createdObjects.Length; i++)
        {
           Destroy(createdObjects[i]);
        }
    }
}
