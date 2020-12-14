using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    public GameObject list;

    public Transform worek;

    public void Connection()
    {
        list.transform.SetParent(worek);

        
    }
}
