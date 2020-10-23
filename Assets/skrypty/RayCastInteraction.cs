using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        if (hit)
        {
            if(hit.transform.name == "Item")
            {
                Debug.Log("mam to");
            }

            if(hit.transform.name == "Item2")
            {
                Debug.Log("mam też to");
            }
            if (hit.transform.name == "Item3")
            {
                Debug.Log("kumalski");
            }
        }
    }
}
