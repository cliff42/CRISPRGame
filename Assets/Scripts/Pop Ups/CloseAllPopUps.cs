using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAllPopUps : MonoBehaviour
{
    public GameObject popUp1;
    public GameObject popUp2;
    public GameObject popUp3;
    public GameObject popUp4;
    public GameObject popUp5;

    public void ClosePopUps() {
        popUp1.SetActive(false);
        popUp2.SetActive(false);
        popUp3.SetActive(false);
        popUp4.SetActive(false);
        popUp5.SetActive(false);
    }
}
