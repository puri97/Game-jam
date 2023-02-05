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
    [SerializeField] private Transform player;

    //direction the root is traveling
    private Vector2 direction;

    void Start()
    {
        //Initialize the root going downward
        direction = Vector2.up;
    }

    // Player control for moving the root
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, TurnSpeed);
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward, -TurnSpeed);
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
            Debug.Log("Hello");
        }
        if (collision.tag == "powerup1")
        {
            Speed += 0.5f;
        }
    }
}
