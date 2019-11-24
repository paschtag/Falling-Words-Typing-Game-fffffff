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

    private void Awake()
    {
       PanelNameText.text = keepData.PlayerName;
       PanelLivesText.text = keepData.PlayerLives.ToString();
        PanelSpeedText.text = keepData.PlayerSpeed.ToString();
     //   PanelHighScoreText.text = "High: " + keepData.HighScore.ToString();
      // PanelRoundsPlayedText.text = "Rounds: " + keepData.RoundsPlayed.ToString();
    }
    private void Update()
    {
       // PanelScoreText.text = Score.PinCount.ToString();
    }
}
