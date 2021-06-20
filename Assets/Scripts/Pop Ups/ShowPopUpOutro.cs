using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopUpOutro : MonoBehaviour
{
    public GameObject popUp;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            popUp.SetActive(false);
        }
    }

    // Update is called once per frame
    public void Show()
    {
        Debug.Log("aaa");
        popUp.SetActive(true);
    }
}
