
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Move : MonoBehaviour
{
    //Intialize through the inspector the growth speed of the root
    [SerializeField] private float Speed;
    //Initialize through the inspector of the turn speed of the root
    [SerializeField] private float TurnSpeed;
    [SerializeField] private Transform mainCamera;
    [SerializeField] private Transform player;

    private Boolean ending;

    //direction the root is traveling
    private Vector2 direction;
    public TextMeshProUGUI Win;
    void Start()
    {
        //Initialize the root going downward
        direction = Vector2.up;
    }

    // Player control for moving the root
    private void Update()
    {
        if (!ending )
        {
            mainCamera.position = player.position + new Vector3(0, 0, -10);
        }else if (ending && mainCamera.position.y <= 101f)
        {
            mainCamera.Translate(Vector2.up * 15 * Time.deltaTime);
        }
        else if(mainCamera.position.y >= 101f)
        {
            SceneManager.LoadScene("Ending");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, -TurnSpeed);
        }else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward, TurnSpeed);
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
            Speed -= 1f;
        }
        if (collision.tag == "powerup1")
        {
            Speed += 0.5f;
        }
        if (collision.tag.Equals("water"))
        {
            ending = true;
        }
    }
}
