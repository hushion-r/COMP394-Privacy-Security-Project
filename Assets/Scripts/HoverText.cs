using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject text;

    public void Awake()
    {
        text.SetActive(false);

    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    { 
        //Output to console the detection of the mouse entering the GameObject
        Debug.Log("Cursor Entering " + name + " GameObject");

        text.SetActive(true);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output to console the detection of the mouse exiting the GameObject
        Debug.Log("Cursor Exiting " + name + " GameObject");

        text.SetActive(false);
    }

}
