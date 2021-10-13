using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowingBall : MonoBehaviour
{

    public float throwingForce = 1000f;
    public GameObject playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void throwBall()
    {

        Debug.Log("TROW BALL");

        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();       
        grab.interactionLayerMask = new LayerMask();
        rb.useGravity = true;
        rb.AddForce(playerCamera.transform.rotation * playerCamera.transform.forward * throwingForce);

        // yield return new WaitForSeconds(5);
        // grab.interactionLayerMask = 1;
    }

}
