using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Failed : MonoBehaviour
{
    public timer timer;
    public float restartDelay;
    Animator anim;
    float restrartTimer;
    public AudioSource playerAudio;
    bool muted;


    void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer.timeRemaining <= 0)
        {
            AudioListener.volume = 0;
            anim.SetTrigger("Fail");
            restrartTimer += Time.deltaTime;
            
            if (restrartTimer >= restartDelay)
            {
                SceneManager.LoadScene("_testScene");
                

            }

        }
        
    }
    public void mute()
    {
        muted = !muted;
    }

    
}
