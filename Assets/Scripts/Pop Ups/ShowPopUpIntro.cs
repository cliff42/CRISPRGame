using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopUpIntro : MonoBehaviour
{
    GameObject controller;

    // Update is called once per frame
    public void Show(GameObject popUp)
    {
        popUp.SetActive(true);
    }
}
