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
        //call needed components now and store them so to not do it again
        playerMovement = GetComponent<PlayerMovement>();  
        shooting = GetComponent<Shooting>();              
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerMovement Input
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f ) 
        {
            if (playerMovement != null) //null reference exception
            {
                playerMovement.HorizontalMovement(HorizontalInput);
            }
            else
            {
                Debug.Log("Attach Movement Script!!!"); //gentle reminder :)
            }

        }
        //Shooting Input
        if (Input.GetButton("Fire1"))
        {
            if (shooting != null) //null reference exception
            {
                shooting.Shoot();
            }
            else
            {
                Debug.Log("Attach Shooting Script!!!"); //gentle reminder :)
            }
            
        }
    }
}
