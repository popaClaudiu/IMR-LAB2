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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(ballthrown && Time.realtimeSinceStartup > thrownTime + 1){
            Debug.Log("RESET");
            ballthrown = false;
            XRGrabInteractable grab = GetComponent<XRGrabInteractable>();       
            grab.interactionLayerMask = LayerMask.NameToLayer("Everything");  
        }
    }

    public void throwBall()
    {

        Debug.Log("TROW BALL");
        
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();       
        
        grab.interactionLayerMask = new LayerMask();
        rb.useGravity = true;
        rb.AddForce(playerCamera.transform.rotation * playerCamera.transform.forward * throwingForce);
        ballthrown = true;
        thrownTime = Time.realtimeSinceStartup;
        Debug.Log(thrownTime);
    }

}
