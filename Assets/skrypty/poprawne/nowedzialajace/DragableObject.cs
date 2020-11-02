using System.Collections;
using UnityEngine;

public class DragableObject : MonoBehaviour
{
    float time;

    public void OnPress()
    {
        time = -1;
    }

    public void SetFree()
    {
        StartCoroutine(Animate(gameObject, gameObject.transform.parent.gameObject, 2));
    }

    IEnumerator Animate(GameObject objectToMove, GameObject target, float druation)
    {
        time = druation;
        float speed = 7.0f / druation;
        while (time > 0)
        {
            objectToMove.transform.Translate((target.transform.position - objectToMove.transform.position) * speed * Time.deltaTime, Space.World);
            time -= Time.deltaTime;
            yield return null;
        }
    }
}

