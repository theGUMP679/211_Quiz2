using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MeetPlayer : MonoBehaviour
{

    public InputField playerInput;
    public InputField playerAge;
    public static string playerName;
    public int myAge;


    public void SetName ()
    {
        playerName = playerInput.text;
        myAge = int.Parse(playerAge.text);
        Debug.Log("Name and Age of player is" + playerName + myAge);
    }

  
    public void StartGame()
    {
        PlayerPrefs.SetString("ThisPlayer", playerName);
        PlayerPrefs.SetInt("ThisAge", myAge);
        SceneManager.LoadScene("Game");
    }
}
