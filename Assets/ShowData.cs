﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighScoreText;
    public Text PanelRoundsPlayedText;

    public void Awake()
    {
       PanelNameText.text = keepData.PlayerName;
       PanelLivesText.text = keepData.PlayerLives.ToString();
        PanelSpeedText.text = keepData.PlayerSpeed.ToString();
       PanelHighScoreText.text = "High: " + keepData.HighScore.ToString();
      PanelRoundsPlayedText.text = "Rounds: " + keepData.RoundsPlayed.ToString();
    }
    public void Update()
    {
      //  PanelScoreText.text = WordManager.score.ToString;
    }
}
