using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class ThrowingBall : MonoBehaviour
{

    public float throwingForce = 100f;
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

        rb.useGravity = true;
        rb.AddForce( playerCamera.transform.forward * throwingForce);
    }

}
