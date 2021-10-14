using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BascketScript : MonoBehaviour
{

    public Text scoreDisplay;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnTriggerEnter(Collider  collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "ball")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            score++;

            scoreDisplay.text = "Score: " + score;
            

        }
    }
}
