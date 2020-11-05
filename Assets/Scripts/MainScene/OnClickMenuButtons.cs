using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClickMenuButtons : MonoBehaviour
{
    string move;
    public Text moveText;

    private void Start()
    {
        move = PlayerPrefs.GetString("move", "Turn");
        moveText.text = move;
    }
    public void OnClickPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickMoveButton()//кнопка переключающая способ перемещения
    {
        if (move.Equals("Turn"))
        {
            move = "Joystick";
            moveText.text = "Joystick";
            PlayerPrefs.SetString("move", "Joystick");
            PlayerPrefs.Save();
            
        }
        else
        {
            move = "Turn";
            moveText.text = "Turn";
            PlayerPrefs.SetString("move", "Turn");
            PlayerPrefs.Save();
          
        }
    }
}
