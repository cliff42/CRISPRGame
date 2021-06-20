using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour

{

    bool reached = false;


    private void Start()
    {
   
    }

    void Update()
    {
        if (transform.position.x > 6.2f &&
            transform.position.x < 8f &&
            transform.position.y > 1.5f &&
            transform.position.y < 3f)
        {
            reached = true;
        }

        if (reached)
        {
            GetComponent<MouseDragger>().enabled = false;
            gameObject.SetActive(false);
        }

    }
}
