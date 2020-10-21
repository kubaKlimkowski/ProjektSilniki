using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour {

    public Animator transitionAnim;
    public string SceneName;

    void update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(Loadscene());

        }

    }
    IEnumerator Loadscene(){

        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneName);
    }
}


