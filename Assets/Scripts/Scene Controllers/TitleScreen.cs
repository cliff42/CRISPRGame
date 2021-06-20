﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    int timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 300;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
        {
            SceneManager.LoadScene(sceneName: "Introduction");
        }
    }
}
