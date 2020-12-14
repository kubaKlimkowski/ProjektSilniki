using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Computer : MonoBehaviour
{
    public Transform[] computerParts;

    private void Update()
    {
        bool complite = true;
        foreach(Transform part in computerParts)
        {
            if(part.childCount == 0)
            {
                complite = false;
            }
        }
        if (complite)
        {
            SceneManager.LoadScene(1);
        }
    }
}
