using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePopUpIntro : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            gameObject.SetActive(false);
        }
    }
}
