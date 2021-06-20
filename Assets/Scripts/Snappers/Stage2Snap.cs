using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2Snap : MonoBehaviour
{
  
    bool reached;
    public GameObject explanation;
    public GameObject guide;

    Scrollbar bar;

    public IEnumerator Start()
    {
        explanation.SetActive(false);
        yield return null; // Wait one frame
        bar = GetComponentInChildren<Scrollbar>();
    }

    void Update()
    {
        bar = GetComponentInChildren<Scrollbar>();
        if (bar.value <= 0.398 && bar.value >= 0.380)
        {
            reached = true;
        }

        if (reached)
        {
            guide.SetActive(false);
            bar.interactable = false;
            explanation.SetActive(true);
        }

        if (reached && Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene(sceneName: "Stage3");
        }
    }
}

