using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqSlot : MonoBehaviour {

    public bool isTaken;
    public GameObject heldObject;

    private void Awake() {
        isTaken = false;
    }
    public void Free() {
        isTaken = false;

        //heldObject.transform.SetParent(null); // czy ma być w canvasie czy nie(jeżeli w canvasie, można parenta ustawić jako root transform.SetParent(heldObject.transform.root);
        
        heldObject = null;
    }
    public void Take(GameObject go) {

        isTaken = true;
        heldObject = go;
        heldObject.transform.SetParent(this.transform);
        heldObject.transform.position = transform.position;
    }
}
