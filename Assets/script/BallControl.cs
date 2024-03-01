using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float maxspeed;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rig.velocity.magnitude > maxspeed)
        {
            rig.velocity = rig.velocity.normalized * maxspeed;
        }
    }
}
