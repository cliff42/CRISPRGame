using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    private bool selected;

    void Update()
    {
        if (selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, gameObject.transform.position.y);
        }

        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }
}
