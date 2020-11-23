using System.Collections.Generic;
using UnityEngine;

public class EqSystem : MonoBehaviour {
    public static EqSystem instance { get; private set; }

    EqSlot[] slots;


    private void Awake() {
        slots = GetComponentsInChildren<EqSlot>(); //Funkcja tworzy tablicę więc nie potrzbne jest jej osobne definiowanie
        instance = this;
<<<<<<< HEAD
        //freeslots.AddRange(slots);
=======

>>>>>>> 5fa3470e61ed28d5a80788ab865b4276c840f03a
    }
    private void Start() {
        //argument out of range exception pojawia się w momencie, gdy próbują się Państwo odwołać do elementu nie występującego w kolekcji (np. element 6 w 5cio elementowej tablicy)

    }

    public void PickUpObject(EqItem item) {
        foreach(EqSlot a in slots) {
            if(a.isTaken)
                continue;

            a.Take(item.gameObject);
            return;
            //Destroy(pickObject.transform.GetChild(0).gameObject); //brzydkie
            //pickObject.GetComponent<DragableObject>().SetFree();  //brzydkie

        }

    }

<<<<<<< HEAD
    public void SetSlotFree(GameObject freedObject) {
        //foreach(EqSlot a in slots) {
            //if(freedObject == a.heldObject)
                //a.Free();
        }
        //if(slots.Contains(freedObject) && !freeslots.Contains(freedObject)) { freeslots.Add(freedObject); }
   
    public void SetSlotOccupied(GameObject slot) {
        //if(slots.Contains(slot) && freeslots.Contains(slot)) { freeslots.Remove(slot); }
    }
=======
    public void SetSlotFree(EqItem item) {
        foreach(EqSlot a in slots) {
            if(item.gameObject == a.heldObject)
                a.Free();
        }

    }

    public void SetSlotOccupied(GameObject slot) {

>>>>>>> 5fa3470e61ed28d5a80788ab865b4276c840f03a
    }
    /*
     *  Zwalnianie slotów poprzez informację o tym, który obiekt został zabrany 
     * 
     * 
     */


