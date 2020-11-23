using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


[RequireComponent(typeof(EventTrigger))]
public class DragableObject : MonoBehaviour {

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
    }


    private void Drag(PointerEventData data) {
        transform.position = Input.mousePosition;
    }


    private void OnDragStart(PointerEventData data) {
        EqItem item = GetComponent<EqItem>();
        if(item != null)
            item.canMove = false;
    }
}

