using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class EqItem : MonoBehaviour {

    //skrypt odpowiedzialny za podnoszenie itemków
    public bool canMove = true;
    EventTrigger triggers;

    private void Start() {
        triggers = GetComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();

        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { OnClick((PointerEventData)data); });

        triggers.triggers.Add(entry);

    }


    public void OnClick(PointerEventData data) {
        if(canMove) {
            //pomiędzy tą linijką
            StartCoroutine(Anim());

            //a tą obiekt jest przesuwany do EQ
        } else
            canMove = true;
    }
    IEnumerator Anim() {
        triggers.enabled = false;
        //GetComponent<Image>().raycastTarget = false;
        yield return new WaitForSeconds(0);
        EqSystem.instance.PickUpObject(this);


        //GetComponent<Image>().raycastTarget = true;
        triggers.enabled = true;
    }
}
