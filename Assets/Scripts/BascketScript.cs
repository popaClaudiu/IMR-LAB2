using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BascketScript : MonoBehaviour
{

    public Text scoreDisplay;
    public int score = 0;

     void OnTriggerEnter(Collider  collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            score++;
            scoreDisplay.text = "Score: " + score;
        }
    }
}
