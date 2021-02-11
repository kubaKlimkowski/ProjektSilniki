using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionController : MonoBehaviour {

  TransitionData data;
  TransitionManager manager;

    private void Awake() {
        Resources.Load<TransitionData>(gameObject.name);
        manager = GetComponentInParent<TransitionManager>();
    }

    public void ChangeLevel(string name)
    {
        try
        {
            gameObject.SetActive(false);
            manager.rooms[name].gameObject.SetActive(true);
        }
        catch
        {
            Debug.LogError("Brak: " + name);
        }
    }
}
