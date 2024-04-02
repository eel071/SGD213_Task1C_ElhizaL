using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
            // SerializeField exposes this value to the Editor, but not to other Scripts!
            [SerializeField]
            private float speed = 5000f;

            private Rigidbody2D rb;

    // Use this for initialization
    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        rb = GetComponent<Rigidbody2D>(); 
    }


    public void HorizontalMovement(float HorizontalInput) 
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * speed * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }
}
