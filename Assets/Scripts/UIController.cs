using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{

    public string playerName2;
    public int playerLegal;

    public Text tellPlayer;
    public Slider mooseColor;
    public Slider mooseSize;
    public Slider mooseRotate;
    public GameObject Moose;


    

    public void changeMooseColor()
    {
        float newMooseColor = mooseColor.value;
        Moose.GetComponent<SpriteRenderer>().color = Colors[(int)newMooseColor];

        Colors = new Color32[4];
        Colors[0] = new Color32(185, 0, 185, 255);
        Colors[1] = new Color32(0, 127, 255, 255);
        Colors[2] = new Color32(0, 0, 255, 255);
        Colors[3] = new Color32(0, 255, 255, 255);
    }


    public void changeMooseSize()
    {
        float newMooseSize = mooseSize.value;
        Moose.transform.localScale = new Vector2(newMooseSize, newMooseSize);
    }

    Color32[] Colors;

}
