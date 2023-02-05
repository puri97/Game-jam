

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Move : MonoBehaviour
{
    //Intialize through the inspector the growth speed of the root
    [SerializeField] private float Speed;
    //Initialize through the inspector of the turn speed of the root
    [SerializeField] private float TurnSpeed;

    //direction the root is traveling
    private Vector2 direction;
    public TextMeshProUGUI Win;
    void Start()
    {
        //Initialize the root going downward
        direction = Vector2.down;
        Win.text = " ";
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

    //future implementation when hitting an obstacle,
    //ex) Rock or hard soil
    //Dont worry about this yet
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rock")
        {
            Speed -= 0.5f;
        }
        if (collision.tag == "powerup")
        {
            Speed += 0.5f;
        }
        if (collision.tag == "dest") {
            Speed = 0;
            Win.text = "YOU WIN !! ";
        }
    }
}
