using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuskTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem duskTrail;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.CompareTag("Player"))
            duskTrail.Play();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        duskTrail.Stop();
    }
}
