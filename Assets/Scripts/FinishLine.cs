using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayInvoke = 2f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Invoke("ReloadScene", delayInvoke);
        }
    }

    void ReloadScene() {
        Debug.Log("hinigh");
        SceneManager.LoadScene(0);
    }
}
