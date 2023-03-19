using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class MyRotation2 : ARBaseGestureInteractable
{
    [SerializeField, Tooltip("The rate at which Unity rotates the attached object with a drag gesture.")]
    float m_RotationRateDownDrag = 100f;

    public float rotationRateDownDrag
    {
        get => m_RotationRateDownDrag;
        set => rotationRateDownDrag = value;
    }

    protected override bool CanStartManipulationForGesture(DragGesture gesture)
    {
        return IsGameObjectSelected() && gesture.targetObject==null;
    }

    protected override void OnContinueManipulation(DragGesture gesture)
    {
            var camera = xrOrigin != null
            ? xrOrigin.Camera
            #pragma warning disable 618
            : (arSessionOrigin != null ? arSessionOrigin.camera : Camera.main);
            #pragma warning restore 618
            if(camera == null)
            return;

            var right = camera.transform.right;
            var worldToVerticalOrientedDevice = Quaternion.Inverse(Quaternion.LookRotation(right, Vector3.right));
            var deviceToWorld = camera.transform.rotation;
            var rotatedDelta = worldToVerticalOrientedDevice*deviceToWorld*gesture.delta;

            var rotationAmount = -1f *(rotatedDelta.y / Screen.dpi)* m_RotationRateDownDrag;
            transform.Rotate(rotationAmount, 0f,0f);


    }
}
