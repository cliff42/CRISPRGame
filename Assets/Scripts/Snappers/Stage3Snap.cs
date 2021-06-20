using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stage3Snap : MonoBehaviour

{

    bool reached = false;
    public GameObject empty;

    public GameObject guide1;
    public GameObject guide2;
    public GameObject guide4;


    private void Start()
    {
        empty.SetActive(false);
    }

    void Update()
    {
        if (transform.position.x > 6f &&
            transform.position.x < 7f &&
            transform.position.y > 2f &&
            transform.position.y < 3.8f)
        {
            reached = true;
        }

        if (reached)
        {
            guide1.SetActive(false);
            guide4.SetActive(false);
            guide2.SetActive(true);
            GetComponent<MouseDragger>().enabled = false;
            gameObject.SetActive(false);
            empty.SetActive(true);
        }

    }
}
