using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void toHome()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void toPlay()
    {
        SceneManager.LoadScene("_testScene");
    }
}
