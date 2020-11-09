using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClickMenuButtons : MonoBehaviour
{
    string move;
    public TextMeshProUGUI moveTextMeshPro;

    private void Start()
    {
        move = PlayerPrefs.GetString("move", "Turn");
        moveTextMeshPro.text = move;
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
            moveTextMeshPro.text = "Joystick";
            PlayerPrefs.SetString("move", "Joystick");
            PlayerPrefs.Save();
            
        }
        else
        {
            move = "Turn";
            moveTextMeshPro.text = "Turn";
            PlayerPrefs.SetString("move", "Turn");
            PlayerPrefs.Save();
          
        }
    }
}
