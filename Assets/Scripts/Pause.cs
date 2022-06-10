using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    bool paused;
    bool muted;
    public Canvas pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        pauseCanvas.GetComponent<Canvas>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseCanvas.GetComponent<Canvas>().enabled = true;

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseCanvas.GetComponent<Canvas>().enabled = false;
    }
    public void exitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
