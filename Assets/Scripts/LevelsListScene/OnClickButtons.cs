﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickButtons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickLevelButton(int level)
    {
        PlayerPrefs.SetInt("currentLevel", level);
        PlayerPrefs.Save();

        SceneManager.LoadScene(level.ToString());
    }
}
