using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    public Button restartButton;
    public Button nextLevelButton;

    int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickRestartButton()
    {
        restartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(currentLevel.ToString());
    }

    public void OnClickNextLevelButton()
    {
        nextLevelButton.gameObject.SetActive(true);

        PlayerPrefs.SetInt("currentLevel", currentLevel + 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene((currentLevel + 1).ToString());
    }
}
