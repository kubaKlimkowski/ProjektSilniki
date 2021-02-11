using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TransitionButton : MonoBehaviour {

   [SerializeField]
    public string level;

    void Start() {
        GetComponent<Button>().onClick.AddListener(Switch);
    }

    private void Switch() {
        GetComponentInParent<TransitionController>().ChangeLevel(level);
    }

}
