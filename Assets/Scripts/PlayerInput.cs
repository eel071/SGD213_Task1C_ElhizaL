using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private PlayerMovement playerMovement;
    private Shooting shooting;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();  
        shooting = GetComponent<Shooting>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f ) 
        {
            playerMovement.HorizontalMovement(HorizontalInput);
        }

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
