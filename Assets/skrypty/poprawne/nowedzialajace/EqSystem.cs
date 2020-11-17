using System.Collections.Generic;
using UnityEngine;

public class EqSystem : MonoBehaviour {
    public static EqSystem instance { get; private set; }

    EqSlot[] slots;


    private void Awake() {
        slots = GetComponentsInChildren<EqSlot>(); //Funkcja tworzy tablicę więc nie potrzbne jest jej osobne definiowanie
        instance = this;

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

    public void SetSlotFree(EqItem item) {
        foreach(EqSlot a in slots) {
            if(item.gameObject == a.heldObject)
                a.Free();
        }

    }

    public void SetSlotOccupied(GameObject slot) {

    }
    /*
     *  Zwalnianie slotów poprzez informację o tym, który obiekt został zabrany 
     * 
     * 
     */
}

