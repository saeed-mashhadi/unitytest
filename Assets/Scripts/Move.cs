using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endLevel()
    {
        Debug.Log("hello Istanbul");
    }
    
    public void Forwardd()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
    public void backk()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
    public void leftt()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

    }
    public void rightt()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

    }

    

 }


