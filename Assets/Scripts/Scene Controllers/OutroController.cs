using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutroController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene(sceneName: "Introduction");
        }
        if (Input.GetKeyDown("space")) {
            SceneManager.LoadScene(sceneName: "Credits");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(sceneName: "Sources");
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Application.Quit();
        }
    }
}
