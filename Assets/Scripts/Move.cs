using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    //Intialize through the inspector the growth speed of the root
    [SerializeField] private float Speed;
    //Initialize through the inspector of the turn speed of the root
    [SerializeField] private float TurnSpeed;

    //direction the root is traveling
    private Vector2 direction;

    // Variable to store Player location so as to calculate velocity.
    private Vector2 whereItWas;
    // Calculate how fast Player is Moving.

    public float PlayerVelocity = 0.0f;

    void Start()
    {
        //Initialize the root going downward
        direction = Vector2.down;
    }

    // Player control for moving the root
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction.x -= TurnSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction.x += TurnSpeed;
        }

    }
    //Late update function to update root position
    private void LateUpdate()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rock")
        {
            Speed -= 0.3f;
            Debug.Log ("Hello");
        }
        if (collision.tag == "powerup1")
        {
            Speed += 0.5f;
        }
    }
}
