using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
     {
         Ray ray = eventData.pressEventCamera.ScreenPointToRay(eventData.position);
             transform.position = ray.origin + ray.direction;
     }
}
