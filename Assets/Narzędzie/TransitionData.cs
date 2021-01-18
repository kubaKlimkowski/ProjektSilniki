using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TransitionData", menuName = "ScriptableObjects/Transition", order = 1)]
public class TransitionData : ScriptableObject {

    public string from;
    public List<string> to;

}
