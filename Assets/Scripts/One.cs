using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class One : MonoBehaviour
{
    public Player1 addscore1;
    public Player2 addscore2;
    public Player3 addscore3;
    public Player4 addscore4;
    public Player5 addscore5;
    public Player6 addscore6;
    public Player7 addscore7;
    public Player8 addscore8;
    public Player9 addscore9;
    public int addition;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        addition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        addition = addscore1.score + addscore2.score + addscore3.score + addscore4.score + addscore5.score + addscore6.score
            + addscore7.score + addscore8.score + addscore9.score;
        text.text = "Score : " + addition;
    }
}
