using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float restartTime;
    [SerializeField] ParticleSystem crashEffect;
 void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Terrain") {

        crashEffect.Play();
        Invoke("RestartLevel", restartTime);

    }
}
    void RestartLevel(){
        SceneManager.LoadScene(0);
    }
    
}
