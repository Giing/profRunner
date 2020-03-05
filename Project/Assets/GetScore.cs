using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    { 
        score = PlayerPrefs.GetInt("PlayerScore");
        scoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
