using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARRaycastManager))]
public class PlacementController : MonoBehaviour
{
    
    [SerializeField]
    private Button bos;
    [SerializeField]
    private Button ovisCapra;
    [SerializeField]
    private Button canis;
    [SerializeField] private Button destroy;
    [SerializeField] private Text scaleText;
    private GameObject placedPrefab;
    private ARRaycastManager aRRaycastManager;


    void Awake()
    {
       aRRaycastManager = GetComponent<ARRaycastManager>();
       
       ChangePrefabTo("CowMTbone");
       
       bos.onClick.AddListener(() => ChangePrefabTo("CowMTbone"));
       ovisCapra.onClick.AddListener(() => ChangePrefabTo("Cube"));
       canis.onClick.AddListener(() => ChangePrefabTo("canisMTbone"));
    //destroy.onClick.AddListener(() => DestroyAllGameObjects());
    }

    void ChangePrefabTo(string prefabName)
    {
        placedPrefab = Resources.Load<GameObject>(prefabName);
                
        if(placedPrefab == null)
        {
            Debug.LogError($"Prefab with name {prefabName} could not be loaded");
        }
     }

    public void DestroyAllGameObjects()
    {
        GameObject[] GameObjects = (FindObjectsOfType<GameObject>() as GameObject[]);

        for (int i = 0; i < GameObjects.Length; i++)
        {
            Destroy(GameObjects[i]);
        }
    }

    void Update()
    {

        bool TryGetTouchPosition(out Vector2 touchPosition)
        {
            if (Input.touchCount > 0)
            {
                touchPosition = Input.GetTouch(0).position;
                return true;
            }
            touchPosition = default;

            return false;

        }

        if (placedPrefab == null)
        {
            return;
        }

        if(!TryGetTouchPosition(out Vector2 touchPosition))
        return;

        if(aRRaycastManager.Raycast(touchPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon ))
        {
            var hitPose = hits[0].pose;
            Instantiate(placedPrefab, hitPose.position, hitPose.rotation);
            scaleText.text = placedPrefab.transform.localScale.ToString("P");
            //sahnede birden çok placedPrefab olduğunda hangisinin LocalScaleini alacak? yani ben scale yaptgımda
            //sahnedeki tüm objeler aynı anda aynı oranda büyümeli bu koda göre. 
            //rotasyon eklediğimde de aynı anda aynı şekilde dönecekler demektir bu.
        }

        
    }

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
}