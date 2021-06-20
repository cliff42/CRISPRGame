using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class swapTextrueStage4 : MonoBehaviour
{
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public GameObject guide;
    public GameObject explination;

    Scrollbar bar;

    public IEnumerator Start()
    {
        d1.SetActive(true);
        d2.SetActive(false);
        d3.SetActive(false);
        d4.SetActive(false);
        explination.SetActive(true);
        guide.SetActive(false);
        yield return null; // Wait one frame
        bar = GetComponentInChildren<Scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        bar = GetComponentInChildren<Scrollbar>();

        if (bar.value <= 0.24 && bar.value >= 0)
        {
            d1.SetActive(true);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(false);
            explination.SetActive(true);
            guide.SetActive(false);
        }

        if (bar.value <= 0.49 && bar.value >= 0.25)
        {
            d1.SetActive(false);
            d2.SetActive(true);
            d3.SetActive(false);
            d4.SetActive(false);
            explination.SetActive(true);
            guide.SetActive(false);
        }

        if (bar.value <= 0.74 && bar.value >= 0.5)
        {
            d1.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(true);
            d4.SetActive(false);
            explination.SetActive(true);
            guide.SetActive(false);
        }

        if (bar.value <= 1 && bar.value >= 0.75)
        {
            d1.SetActive(false);
            d2.SetActive(false);
            d3.SetActive(false);
            d4.SetActive(true);
            explination.SetActive(false);
            guide.SetActive(true);
            if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene("Outro");
            }
        }
    }
}
