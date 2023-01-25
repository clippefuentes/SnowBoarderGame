using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float delayInvoke = 2f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Terrain") {
            Invoke("ReloadScene", delayInvoke);
        }
    }

    void ReloadScene() {
        Debug.Log("Ouch");
        SceneManager.LoadScene(0);
    }
}
