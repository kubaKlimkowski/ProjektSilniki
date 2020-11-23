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
        //go.transform.position = slots[firstFree].transform.position;
        //slots[firstFree].isTaken = true;
        //firstFree++;
    }

    public void Animate(GameObject go) {
        StartCoroutine(Animation(go, slots[firstFree].transform.position));
        firstFree++;
    }

    IEnumerator Animation(GameObject go, Vector3 target) {
        float k = 0;
        while(k <= 1) {
            go.transform.position = Vector3.Lerp(go.transform.position, target, k);
            yield return new WaitForSeconds(0.03f);
            k += 0.01f;
        }
    }
}
