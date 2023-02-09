using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;


    public void Update()
    {
        if (score == 10)
        {
            scoreText.text = score.ToString() + "/10 !!!";
        }
        else
        {
            scoreText.text = score.ToString() + "/10";
        }
    }
    public void IncreaseScore()
    {
        score++;
    }

    public void WipeScore()
    {
        score = 0;
        scoreText.text = "0/10";
    }
}
