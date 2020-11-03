using System.Collections.Generic;
using UnityEngine;

public class EqSystem : MonoBehaviour
{
    public static EqSystem instance;

    public List<GameObject> slots;
    List<GameObject> freeslots = new List<GameObject>();

    private void Awake()
    {
        instance = this; 
        freeslots.AddRange(slots);
    }

    public void pickUpObject(GameObject pickObject)
    {
        if (freeslots.Count > 0)
        {
            pickObject.transform.SetParent(freeslots[0].transform);
            freeslots.RemoveAt(0);
            Destroy(pickObject.transform.GetChild(0).gameObject);
            pickObject.GetComponent<DragableObject>().SetFree();
        }
    }

    public void SetSlotFree(GameObject slot)
    {
        if (slots.Contains(slot) && !freeslots.Contains(slot))
        { freeslots.Add(slot); }
    }

    public void SetSlotOccupied(GameObject slot)
    {
        if (slots.Contains(slot) && freeslots.Contains(slot))
        { freeslots.Remove(slot); }
    }
}

