using System.Collections.Generic;
using UnityEngine;

public class EqSystem : MonoBehaviour {
    public static EqSystem instance;
    public GameObject eqParent;
    public EqSlot[] slots;
    List<GameObject> freeslots = new List<GameObject>();

    private void Awake() {
        slots = eqParent.GetComponentsInChildren<EqSlot>();
        instance = this;
        //freeslots.AddRange(slots);
    }

    public void pickUpObject(GameObject pickObject) {
        if(freeslots.Count > 0) {
            pickObject.transform.SetParent(freeslots[0].transform);
            freeslots.RemoveAt(0);
            Destroy(pickObject.transform.GetChild(0).gameObject);
            pickObject.GetComponent<DragableObject>().SetFree();
        }
    }

    public void SetSlotFree(GameObject freedObject) {
        //foreach(EqSlot a in slots) {
            //if(freedObject == a.heldObject)
                //a.Free();
        }
        //if(slots.Contains(freedObject) && !freeslots.Contains(freedObject)) { freeslots.Add(freedObject); }
   
    public void SetSlotOccupied(GameObject slot) {
        //if(slots.Contains(slot) && freeslots.Contains(slot)) { freeslots.Remove(slot); }
    }
    }
    /*
     *  Zwalnianie slotów poprzez informację o tym, który obiekt został zabrany 
     * 
     * 
     */


