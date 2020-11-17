using System.Collections.Generic;
using UnityEngine;

public class EqSystem : MonoBehaviour {
    public static EqSystem instance;
    
    public EqSlot[] slots = new EqSlot[6];
    List<GameObject> freeslots = new List<GameObject>();

    private void Awake() {
        slots = GetComponentsInChildren<EqSlot>();
        instance = this;
       
    }
    private void Start()
    {
        for(int i = 0; i< transform.childCount; i++)
        {
            slots[i] = transform.GetChild(i).gameObject.GetComponent<EqSlot>();
        }

        for (int i = 0; i < slots.Length; i++)
        {
            freeslots[i] = slots[i].gameObject; 
        }
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
        foreach(EqSlot a in slots) {
            if(freedObject == a.heldObject)
                a.Free();
        }
      if(slots.Contains(freedObject) && !freeslots.Contains(freedObject)) { freeslots.Add(freedObject); }
    }

    public void SetSlotOccupied(GameObject slot) {
       if(slots.Contains(slot) && freeslots.Contains(slot)) { freeslots.Remove(slot); }
    }
    /*
     *  Zwalnianie slotów poprzez informację o tym, który obiekt został zabrany 
     * 
     * 
     */
}

