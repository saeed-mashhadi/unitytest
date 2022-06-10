using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckEmpty : MonoBehaviour
{
    //private int _count;
    //public Move[] move;
    public int score;
    //public Vector3 loc2;
   // public Vector3 loc3;
    //public Vector3 loc4;
   // public Vector3 loc5;
    // Start is called before the first frame update
    void Start()
    {
        //_count = 0;
        score = 0;
    }

    public void addScore()
    {
        score += 1;
    }
    // Update is called once per frame
    void Update ()
    {
        
        //    for (int i = 0; i < 3 && isIn; ++i)
        //    {
        //  if (cube[i] = loc1[i])
        //  {
        //     isIn = false;
        // }
        //   }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            addScore();
            Debug.Log("123");
            score += 1;
        }
        if (other.gameObject.tag == "Cube (1)")
        {
            addScore();
            Debug.Log("Player1");
            score += 1;
        }
        if (other.gameObject.name == "Cube (2)")
        {
            addScore(); 
            Debug.Log("Player2");
            score += 1;

        }
        if (other.gameObject.name == "Cube (3)")
        {
            addScore();
            Debug.Log("Player3");
            score += 1;

        }
        if (other.gameObject.name == "Cube (4)")
        {
            addScore();
            Debug.Log("Player4");
            score += 1;

        }
        if (other.gameObject.name == "Cube (5)")
        {
            addScore();
            Debug.Log("Player5");
            score += 1;

        }
        if (other.gameObject.name == "Cube (6)")
        {
            addScore();
            Debug.Log("123");
            score += 1;

        }
        if (other.gameObject.name == "Cube (7)")
        {
            addScore();
            Debug.Log("123");
            score += 1;

        }
        if (other.gameObject.name == "Cube (8)")
        {
            addScore();
            Debug.Log("Player8");
            score += 1;

        }
        if (other.gameObject.name == "Cube (9)")
        {
            addScore();
            Debug.Log("Player9");
            score += 1;

        }

    }

    void OnTriggerExit(Collider other)
    {
        //  --_count;
        //move.endLevel();
        if (other.gameObject.name == "Player")
        {
            score++;
            Debug.Log(score);
        }
        if (other.gameObject.tag == "Player1")
        {
            ++score;
            Debug.Log(score);
        }
        if (other.gameObject.name == "Player2")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player3")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player4")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player5")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player6")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player7")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player8")
        {
            ++score;
            Debug.Log(score);

        }
        if (other.gameObject.name == "Player9")
        {
            ++score;
            Debug.Log(score);

        }


    }

    
}
