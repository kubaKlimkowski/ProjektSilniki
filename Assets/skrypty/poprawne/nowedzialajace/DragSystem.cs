using UnityEngine;



public class DragSystem : MonoBehaviour
{
    GameObject currentDragObject;
    GameObject currentDragParent;
    public Transform mainParent;
    public void StartDrag(GameObject pickedObject)
    {
        RaycastHit2D[] hitObject = Physics2D.RaycastAll(Input.mousePosition, Vector3.forward);
        Debug.DrawRay(Input.mousePosition, Vector3.forward, Color.green, 60);
        if (hitObject.Length == 2)
        {
            for (int i = 0; i < hitObject.Length; i++)
            {
                if (hitObject[i].collider.gameObject == pickedObject) continue;
                EqSystem.instance.SetSlotFree(hitObject[i].collider.gameObject);
            }
        }
        currentDragObject = pickedObject;

        if (!currentDragObject.transform.parent.name.Equals("Canvas"))
        {
            currentDragParent = currentDragObject.transform.parent.gameObject;
            currentDragObject.transform.SetParent(mainParent);
        }
    }

    public void DragObject()
    {
        currentDragObject.transform.position = Input.mousePosition;
    }
    public void StopDrag()
    {
        RaycastHit2D[] hitObject = Physics2D.RaycastAll(Input.mousePosition, Vector3.forward);
        // Debug.DrawRay(Input.mousePosition, Vector3.forward, Color.green, 60);
        if (hitObject.Length == 2)
        {
            for (int i = 0; i < hitObject.Length; i++)
            {
                if (hitObject[i].collider.gameObject == currentDragObject) continue;

                if (hitObject[i].collider.gameObject.GetComponent<RequireObjectType>() != null)
                {
                    if (hitObject[i].collider.gameObject.GetComponent<RequireObjectType>().requireObjectType == currentDragObject.GetComponent<RequireSlotType>().requireSlotType)
                    {
                        currentDragObject.transform.SetParent(hitObject[i].collider.gameObject.transform);
                        currentDragObject.transform.position = hitObject[i].collider.gameObject.transform.position;
                        EqSystem.instance.SetSlotOccupied(hitObject[i].collider.gameObject);
                    }
                    else
                    {
                        currentDragObject.transform.SetParent(currentDragParent.transform);
                        EqSystem.instance.SetSlotOccupied(hitObject[i].collider.gameObject);
                    }
                }
                else
                {
                    currentDragObject.transform.SetParent(hitObject[i].collider.gameObject.transform);
                    currentDragObject.transform.position = hitObject[i].collider.gameObject.transform.position;
                    EqSystem.instance.SetSlotOccupied(hitObject[i].collider.gameObject);
                }
            }
        }
        else
        {
            currentDragObject.transform.SetParent(currentDragParent.transform);
            EqSystem.instance.SetSlotOccupied(currentDragParent);
        }
        currentDragObject = null;
        currentDragParent = null;
    }
}
