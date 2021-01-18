using UnityEngine;



public class DragSystem : MonoBehaviour  {
    public static DragSystem Instance { get; private set; }
    GameObject currentDragObject;

    public Transform mainParent;

    private void Awake() {
        Instance = this;
    }

  
    public void StartDrag(GameObject pickedObject) {
        //RaycastHit2D[] hitObject = Physics2D.RaycastAll(Input.mousePosition, Vector3.forward);
        //Debug.DrawRay(Input.mousePosition, Vector3.forward, Color.green, 60);
        //MyItem hitObj = hitObject[0].collider.gameObject.GetComponent<MyItem>();

        //if(hitObj == null)
        //    Debug.Log("nie trafiony obiekt");


        //if(hitObj.isInEq) {
        //    for(int i = 0; i < hitObject.Length; i++) {
        //        if(hitObject[i].collider.gameObject == pickedObject) continue;
        //    }
        //}

        //currentDragObject = pickedObject;

        //if(!currentDragObject.transform.parent.name.Equals("Canvas")) {
        //    currentDragParent = currentDragObject.transform.parent.gameObject;
        //    currentDragObject.transform.SetParent(mainParent);
        //}
    }

    public void DragObject() {
       //currentDragObject.transform.position = Input.mousePosition;
    }

    public void StopDrag() {
        //RaycastHit2D[] hitObject = Physics2D.RaycastAll(Input.mousePosition, Vector3.forward);
        //// Debug.DrawRay(Input.mousePosition, Vector3.forward, Color.green, 60);
        //if(isOutOfEq(hitObject)) {
        //    for(int i = 0; i < hitObject.Length; i++) {
        //        if(hitObject[i].collider.gameObject == currentDragObject) continue;

        //        RequireObjectType obj = hitObject[i].collider.gameObject.GetComponent<RequireObjectType>();

        //        if(obj != null) {
        //            if(obj.requireObjectType == currentDragObject.GetComponent<RequireSlotType>().requireSlotType) {
        //                ModifyObject(hitObject[i]);
        //            } else {
        //                currentDragObject.transform.SetParent(currentDragParent.transform);
        //                EqSystem.instance.SetSlotOccupied(obj.gameObject);
        //            }
        //        } else {
        //            ModifyObject(hitObject[i]);
        //        }
        //    }
        //} else {
        //    currentDragObject.transform.SetParent(currentDragParent.transform);
        //    EqSystem.instance.SetSlotOccupied(currentDragParent);
        //}
        //currentDragObject = null;
        //currentDragParent = null;

        //EqSystem.instance.SetSlotFree(hitObject[0].collider.gameObject);
    }

    void ModifyObject(RaycastHit2D hitObject)
    {
        currentDragObject.transform.SetParent(hitObject.collider.gameObject.transform);
        currentDragObject.transform.position = hitObject.collider.gameObject.transform.position;
        EqSystem.instance.SetSlotOccupied(hitObject.collider.gameObject);
    }

    bool isOutOfEq(RaycastHit2D[] hitObject) {
        return hitObject.Length == 2;
    }

    /*
     * OnDragStart(Item i)-> sprawdza czy mogę przesuwać dany obiekt
     * OnDrag(Item i) -> zmienia pozycję
     * OnDragEnd() -> sprawdzanie czy upuszczenie ma sens (gdy ląduje na obiekcie typu Item, gdy ten Item jest zaznaczony jako obiekt do łączenia, gdy ten Item jest na secenie)
     * jeżeli upuszczenie zadziała. - zwolnij slot w EQ.
     * 
     * OnPointerUp -> DragSystem -> EqSystem
     * Jeżeli po upuszczeniu obiekt znajduje się poza EQ - na pewno można wyczyścić slota
     * if(item.canPick())
     * 
     */
}
