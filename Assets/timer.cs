using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    public Text cdtimerText;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        cdtimerText.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        // Functional game countdown timer
        timeRemaining -= Time.deltaTime;
        if (timeRemaining > 0)
        {
            cdtimerText.text = "TIME: " + (int)timeRemaining;
        }
        else
        {
            cdtimerText.text = "TIME'S UP!";

        }

        if (timeRemaining <= 10.0)
        {
            
        }
        else if (timeRemaining <= 13.0)
        {
            
        }
        else if (timeRemaining <= 16.0)
        {
        }

    }

}