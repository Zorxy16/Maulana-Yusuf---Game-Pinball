using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Bumper : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    
    private Animator animator;

    private void Start()
    {
        
        animator = GetComponent<Animator>();

       

    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //animasiin
            animator.SetTrigger("hitt");
        }
    }
}
