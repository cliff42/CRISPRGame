using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public TextMeshProUGUI text;
    public Color hoverColor;
    public Color defaultColor;


    public void OnPointerEnter(PointerEventData eventData) {
        text.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData) {
        text.color = defaultColor;
    }
}
