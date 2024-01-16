using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 1f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Surface")
        {
            crashEffect.Play();
            Invoke("ReloadScene", reloadTime);
            Debug.Log("You crashed fool");
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
