using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player6 : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "P6")
        {
            score += 1;
        }


    }
}
