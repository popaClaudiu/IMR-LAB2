using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowingBall : MonoBehaviour
{

    public float throwingForce = 1000f;
    public GameObject playerCamera;
    private bool ballthrown = false;
    private float thrownTime;
    private XRGrabInteractable grab;
    
    void Start()
    {
        grab = GetComponent<XRGrabInteractable>(); 
    }


    void Update()
    {
        if(ballthrown && Time.realtimeSinceStartup > thrownTime + 1){
            ballthrown = false;
            grab.interactionLayerMask = LayerMask.NameToLayer("Everything");  
        }
    }

    public void throwBall()
    {        
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
            
        grab.interactionLayerMask = new LayerMask();
        rb.useGravity = true;
        rb.AddForce(playerCamera.transform.rotation * playerCamera.transform.forward * throwingForce);
        ballthrown = true;
        thrownTime = Time.realtimeSinceStartup;
    }

}
