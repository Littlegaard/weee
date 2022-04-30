using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    //movement
  public float Movementspeed = 10;

  //jump
    //sejt
    //sejt
 

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       var movement = UnityEngine.Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement,0,0) * Time.deltaTime * Movementspeed;

    }
} 

