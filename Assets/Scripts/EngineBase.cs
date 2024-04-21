﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineBase : MonoBehaviour
{
    // acceleration indicates how fast the enemy accelerates
    [SerializeField]
    private float acceleration = 5000f;

    // local references
    private Rigidbody2D rb;

    void Start()
    {
        // populate ourRigidbody
        rb = GetComponent<Rigidbody2D>();
    }


    /// <summary>
    /// Accelerate takes a direction as a parameter, and applies a force in this provided direction to rb,  
    /// based on the acceleration variables and the delta time.
    /// </summary>

    /// <param name="horizontalInput">A direction vector, expected to be a unit vector (magnitude of 1).</param>

    public void Accelerate(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
            // apply forceToAdd to rb
            rb.AddForce(forceToAdd);
        }
    }


    public void Accelerate(float horizontalInput)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (horizontalInput != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = Vector2.right * horizontalInput * acceleration * Time.deltaTime;
            // apply forceToAdd to rb
            rb.AddForce(forceToAdd);
        }
    }

}
