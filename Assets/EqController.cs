using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqController : MonoBehaviour {

    public static EqController Instance { get; private set; }

    public int firstFree = 0;
    EqSlot[] slots;

    private void Awake() {
        Instance = this;
        slots = GetComponentsInChildren<EqSlot>();
    }



    public void PutInEq(GameObject go) {
        go.transform.position = slots[firstFree].transform.position;
        slots[firstFree].isTaken = true;
        firstFree++;
    }
}
