using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;
    
    // Update is called once per frame
    void Update()
    {
    
    Vector3 playerOffSetFromPortal = playerCamera.position - otherPortal.position;
    transform.position = portal.position + playerOffSetFromPortal;
    
    
    float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);
    
    
    Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
    Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
    transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
          
          
    }
}
