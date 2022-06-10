using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player9 : MonoBehaviour
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
        if (other.gameObject.name == "P9")
        {
            score += 1;
        }


    }

}
