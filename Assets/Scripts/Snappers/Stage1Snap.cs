using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stage1Snap : MonoBehaviour
{
    public GameObject mainMessage;
    public GameObject instructionalMessage;
    public GameObject postMessage;

    bool reached = false;

    private void Start()
    {
        mainMessage.SetActive(true);
        instructionalMessage.SetActive(true);
        postMessage.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > -2f &&
            transform.position.x < 2f &&
            transform.position.y > -3f &&
            transform.position.y < -2f) {
            reached = true;
        }

        if (reached)
        {
            mainMessage.SetActive(false);
            instructionalMessage.SetActive(false);
            postMessage.SetActive(true);
            GetComponent<MouseDragger>().enabled = false;
        }

        if (reached && Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene(sceneName: "Stage2");
        }
    }
}
