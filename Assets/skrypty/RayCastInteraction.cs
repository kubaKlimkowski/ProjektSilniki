using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInteraction : MonoBehaviour {
    public List<GameObject> Itemy;
    public GameObject[] eqslots = new GameObject[6];
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        for(int i = 0; i < Itemy.Count; i++) {
            Itemy[i].transform.position = eqslots[i].transform.position;
            Itemy[i].transform.parent = eqslots[i].transform.GetChild(0);
        }
        if(Input.GetMouseButtonDown(0)) {
            CastRay();
        }
    }

    void CastRay() {

        RaycastHit2D[] hits = Physics2D.RaycastAll(Input.mousePosition, Vector3.down);
        foreach(RaycastHit2D hit in hits) {
            if(hit.collider.gameObject.name.Contains("Item")) {
                //Itemy.Add(hit.transform.gameObject);
                EqController.Instance.PutInEq(hit.collider.gameObject);
                break;
            }
        }
    }
}
