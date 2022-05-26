using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandelDropItem : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
            = GetComponent<RectTransform>().anchoredPosition;
    }
}
