using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dust;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Surface"){
            dust.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        dust.Stop();
    }

}
