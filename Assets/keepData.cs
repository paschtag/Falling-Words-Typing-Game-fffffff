using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// added

//attached to data manager object in all scenes

public class keepData : MonoBehaviour
{
    public static string PlayerName = "Pasch";
    public static Text PlayerLives;
    public static int PlayerScore;// link to the old game somehow?
    public static int HighScore = 0;
    public static float PlayerSpeed ;
    public static int RoundsPlayed;

    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Dropdown PlayerLivesDropdown;
    // don't forget to fill these fields in the inspector for data manager

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
    }
    private void Update()
    {
        //Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.captionText;
    }
    public void ChangeSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }

}
