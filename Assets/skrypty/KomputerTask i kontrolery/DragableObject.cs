using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


[RequireComponent(typeof(EventTrigger))]

 
public class DragableObject : MonoBehaviour {
    private GameObject selectedObject;
    private void Start() {
        EventTrigger triggers = GetComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();

        entry.eventID = EventTriggerType.BeginDrag;
        entry.callback.AddListener((data) => { OnDragStart((PointerEventData)data); });
        triggers.triggers.Add(entry);

        EventTrigger.Entry entry2 = new EventTrigger.Entry();

        entry2.eventID = EventTriggerType.Drag;
        entry2.callback.AddListener((data) => { Drag((PointerEventData)data); });
        triggers.triggers.Add(entry2);


        EventTrigger.Entry entry3 = new EventTrigger.Entry();

        entry3.eventID = EventTriggerType.EndDrag;
        entry3.callback.AddListener((data) => { OnDragEnd((PointerEventData)data); });
        triggers.triggers.Add(entry3);
    }

    private void OnDragEnd(PointerEventData data) {
        EqItem item = GetComponent<EqItem>();
        if(item != null)
            EqSystem.instance.SetSlotFree(item);
        RaycastHit2D[] hits;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hits =  Physics2D.RaycastAll(Input.mousePosition, Input.mousePosition + Vector3.down, Mathf.Infinity);
        foreach(RaycastHit2D hit in hits)
        {
            print(hit.collider.gameObject.name);
            RequireSlotType obj = selectedObject.GetComponent<RequireSlotType>(); 
            RequireObjectType slot = hit.collider.gameObject.GetComponent<RequireObjectType>();
            if (slot != null)
            {
                if(obj.requireSlotType == slot.requireObjectType)
                {
                    obj.transform.parent = slot.transform;
                    obj.transform.position = slot.transform.position;
                }
            }
        }
        
    }


    private void Drag(PointerEventData data) {
        transform.position = Input.mousePosition;
    }


    private void OnDragStart(PointerEventData data) {
        selectedObject = data.selectedObject;
       RaycastHit2D hit;
        EqItem item = GetComponent<EqItem>();
        if(item != null)
            item.canMove = false;
        hit = Physics2D.Raycast(Input.mousePosition, Input.mousePosition + Vector3.down, Mathf.Infinity);
        if (hit.collider.gameObject.name.Contains("Item"))
        {
            selectedObject = hit.collider.gameObject;
        }
    }
}

