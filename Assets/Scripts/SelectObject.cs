using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    public Canvas player1;
    public Canvas player2;
    public Canvas player3;
    public Canvas player4;
    public Canvas player5;
    public Canvas player6;
    public Canvas player7;
    public Canvas player8;
    public Canvas player9;

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;
    public GameObject cube9;

    // Start is called before the first frame update
    void Start()
    {
        player1.GetComponent<Canvas>().enabled = false;
        player2.GetComponent<Canvas>().enabled = false;
        player3.GetComponent<Canvas>().enabled = false;
        player4.GetComponent<Canvas>().enabled = false;
        player5.GetComponent<Canvas>().enabled = false;
        player6.GetComponent<Canvas>().enabled = false;
        player7.GetComponent<Canvas>().enabled = false;
        player8.GetComponent<Canvas>().enabled = false;
        player9.GetComponent<Canvas>().enabled = false;

        cube1.SetActive(false);
        cube2.SetActive(false);
        cube3.SetActive(false);
        cube4.SetActive(false);
        cube5.SetActive(false);
        cube6.SetActive(false);
        cube7.SetActive(false);
        cube8.SetActive(false);
        cube9.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
    }
    void MouseInput()
    {
        // When Mouse 0 is pressed
        if (Input.GetMouseButton(0))
        {
            // Set if the Physics.Raycast returns true
            RaycastHit hitInfo;

            // Setup ray based on mouse input position
            Ray rayFromMouseInput = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Populates hitInfo if returns true
            if (Physics.Raycast(rayFromMouseInput, out hitInfo))
            {
                // Log the name of the hit object
                if (hitInfo.collider.tag == "Player1")
                {
                    // Debug.Log(hitInfo.collider.gameObject.name);
                    player1.GetComponent<Canvas>().enabled = true;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(true);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player2")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = true;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(true);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player3")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = true;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(true);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player4")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = true;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(true);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player5")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = true;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(true);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player6")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = true;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(true);
                }
                if (hitInfo.collider.tag == "Player7")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = true;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(true);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player8")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = true;
                    player9.GetComponent<Canvas>().enabled = false;

                    cube1.SetActive(true);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(false);
                    cube9.SetActive(false);
                }
                if (hitInfo.collider.tag == "Player9")
                {
                    player1.GetComponent<Canvas>().enabled = false;
                    player2.GetComponent<Canvas>().enabled = false;
                    player3.GetComponent<Canvas>().enabled = false;
                    player4.GetComponent<Canvas>().enabled = false;
                    player5.GetComponent<Canvas>().enabled = false;
                    player6.GetComponent<Canvas>().enabled = false;
                    player7.GetComponent<Canvas>().enabled = false;
                    player8.GetComponent<Canvas>().enabled = false;
                    player9.GetComponent<Canvas>().enabled = true;

                    cube1.SetActive(false);
                    cube2.SetActive(false);
                    cube3.SetActive(false);
                    cube4.SetActive(false);
                    cube5.SetActive(false);
                    cube6.SetActive(false);
                    cube7.SetActive(false);
                    cube8.SetActive(true);
                    cube9.SetActive(false);
                }



            //    Debug.DrawRay(
              //      rayFromMouseInput.origin,
                //    rayFromMouseInput.direction * 1000.0f,
                  //  Color.yellow

               // ); // Default ray length to 1000 for debug
            }
        }
    }
}
