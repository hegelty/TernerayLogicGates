using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIChecker : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("Canvas").GetComponent<BuilderManager>().IsMouseOnUi = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject.Find("Canvas").GetComponent<BuilderManager>().IsMouseOnUi = false;
    }
}
