using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text highScoreText;
    int savedScore = 0;

    private string KeyString = "HighScore";

    void Start()
    {
        savedScore = PlayerPrefs.GetInt(KeyString);
        highScoreText.text = savedScore.ToString();
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt(KeyString, 0);
        savedScore = PlayerPrefs.GetInt(KeyString);
        highScoreText.text = savedScore.ToString();
    }
}
