using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Snapping : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Gamemanager manager;
    public Image image;
    public Transform PArentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        PArentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        //image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Dragging");
        transform.SetParent(PArentAfterDrag);
        transform.position = Vector3.zero;
        //image.raycastTarget = true;
        manager.isblueturn = true;
        manager.isredturn = false;

    }
}
