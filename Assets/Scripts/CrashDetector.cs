using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float delayInvoke = 2f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasPlayed = false;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Terrain" && !hasPlayed) {
            FindObjectOfType<PlayerController>().DisableControls();
            finishEffect.Play();
            hasPlayed = true;
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayInvoke);
        }
    }

    void ReloadScene() {
        Debug.Log("Ouch");
        SceneManager.LoadScene(0);
    }
}
