using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class gridmap : MonoBehaviour, IDropHandler
{
    private int childmax = 1;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount < childmax)
        {
            //for (int i = childmax; i < transform.childCount; i++)
            //{
                GameObject dropped = eventData.pointerDrag;
                Snapping draggableitem = dropped.GetComponent<Snapping>();
                draggableitem.PArentAfterDrag = transform;
            //}
          

        }
        //draggableitem.transform.localPosition = Vector3.zero;
    }
}
