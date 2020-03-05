using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private int score;
    public Text scoreText;

    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("addScore", 1.0f, 1.0f);
    }

    void addScore()
    {
        scoreText.text = "Score : " + score++;
        PlayerPrefs.SetInt("PlayerScore", score);
    }
}
