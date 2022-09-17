using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float hiz;
    private float x=10;
    private float z=10;
    public Joystick joystick;
    public Animator anim;
      
    public Rigidbody rb;
    Vector3 move = Vector3.zero;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        karakterHareketAddForce();
       
    }

    void karakterHareketAddForce(){
        x = joystick.Horizontal;
        z = joystick.Vertical;
        
        move = new Vector3(-x,0,z)*Time.deltaTime*hiz;
        rb.MovePosition(transform.position + transform.TransformDirection(move)); 
    
    } 
}
