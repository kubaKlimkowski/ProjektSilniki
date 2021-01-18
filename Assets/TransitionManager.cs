using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour {

    public Dictionary<string, TransitionController> rooms;
    private void Awake() {
        TransitionController[] ctrls = GetComponentsInChildren<TransitionController>(true);
        rooms = new Dictionary<string, TransitionController>();
        foreach(TransitionController a in ctrls) {
            rooms.Add(a.gameObject.name, a);
        }
    }
}
