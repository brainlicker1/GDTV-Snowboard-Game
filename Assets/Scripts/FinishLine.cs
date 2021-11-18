using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
    {
        [SerializeField] float restartTime = 5f;
        [SerializeField] ParticleSystem finishEffect;
        
        
    void OnTriggerEnter2D(Collider2D other) {
        
        finishEffect.Play();

       if(other.tag == "Player") {

           Invoke("RestartLevel", restartTime);
       }
       
       
   }

    void RestartLevel(){
        SceneManager.LoadScene(0);
    }
   
}
