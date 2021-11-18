using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartTime;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;
 void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Terrain" && hasCrashed == false) {

        hasCrashed = true;
        GetComponent<AudioSource>().PlayOneShot(crashSFX);
        crashEffect.Play();
        FindObjectOfType<PlayerController>().ControlLock();
        Invoke("RestartLevel", restartTime);
        
    }
}
    void RestartLevel(){
        SceneManager.LoadScene(0);
    }
    
}
