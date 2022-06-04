using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int scoreMultipler;

    private float score;
    public const string HighScoreKey = "HighScore";

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultipler;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy() 
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey,0);
        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey,Mathf.FloorToInt(score));
        }    
    }
}
