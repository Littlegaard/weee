using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    //animation
    private Animator _aniL;


    //movement
    public float Movementspeed;
 
    //jump
    private Rigidbody2D _RB;
    public float Jumpforce;
 

    void Start()
    {
        //jump
    _RB = GetComponent<Rigidbody2D>();
    _aniL = GetComponent<Animator>();
    
    //animation
  
    }

    // Update is called once per frame
    void Update()
    {

        //movement
       var movement = UnityEngine.Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement,0,0) * Time.deltaTime * Movementspeed;
       //jump

       if(UnityEngine.Input.GetButtonDown("Jump") && Mathf.Abs(_RB.velocity.y) < 0.001f)
       {
           _RB.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
       }
       //animation
       
    }
} 
