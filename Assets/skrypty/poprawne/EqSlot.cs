using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqSlot : MonoBehaviour {

    public bool isTaken;
    public GameObject heldObject;

    public void Free() {
        isTaken = false;
        heldObject = null;
    }
}
