using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1;
    [SerializeField] float boostSpeed = 1f;
    [SerializeField] float baseSpeed= 1f;
    bool canMove = true;
    SurfaceEffector2D surfaceEffector2D;

    void Start()
    {
      
         rb2d  = GetComponent<Rigidbody2D>();
         surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        
    }

    // Update is called once per frame
    void Update()
    {   if(canMove) {
         playerControls();
         RespondToBoost();
    }
       
    }

     void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.W)){

            surfaceEffector2D.speed = boostSpeed;


        } else {

            surfaceEffector2D.speed =  baseSpeed;

        }
    }

   
    void playerControls(){

         if(Input.GetKey(KeyCode.A)){

            rb2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb2d.AddTorque(-torqueAmount);
        }

    }

     public void ControlLock(){

        canMove = false;

    }
}
