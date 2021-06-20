using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    public void StartG()
    {
        SceneManager.LoadScene(sceneName: "Stage1");
    }
}
