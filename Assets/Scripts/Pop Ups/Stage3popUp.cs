using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3popUp : MonoBehaviour
{
    public GameObject popUp;
    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            popUp.SetActive(false);
        }
    }
    public void Show()
    {
        popUp.SetActive(true);
    }
}
