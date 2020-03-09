using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public float highscore;
    private Score Score;
    void Start()
    {
        highscore = Score.GetScore();
    }

    void Update()
    {
        if(Score.GetScore() > highscore)
           highscore = Score.GetScore();
    }
}
