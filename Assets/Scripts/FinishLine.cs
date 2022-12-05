using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    float restartDelay = 1.5f;
    [SerializeField] private ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", restartDelay);
        }
    }

    // Reload Scene if you win
    void ReloadScene()
    {
        SceneManager.LoadScene(0); // 0 is the index of scene in the build settings
    }
}
