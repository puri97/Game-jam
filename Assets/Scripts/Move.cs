//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;

//public class Move : MonoBehaviour
//{
//    private Vector2 moveDirection;
//    public Rigidbody2D rb;
//    public float rotateSpeed = 80.0f;
//    public float acceleration = 20;
//    public float decceleration = 5;
//    public float currentSpeed = 20;
//    public float maxSpeed = 100;
//    // Start is called before the first frame update
//    void Start()
//    {
//        //if (Input.GetKey(KeyCode.DownArrow)) {
//        //    processInputs();
//        //    moveWithAcceleration();
//        //}
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        processInputs();
//        moveWithAcceleration();
//    }
//    private void FixedUpdate()
//    {

//    }
//    void processInputs()
//    {
//        //driving forward and backward using user input
//        float moveX = Input.GetAxis("Horizontal");
//        float moveY = Input.GetAxis("Vertical");
//        moveDirection = new Vector2(moveX, moveY);
//    }
//    void moveWithAcceleration() {

//        currentSpeed =  acceleration * Time.deltaTime;
//        //this.transform.Translate(moveDirection * currentSpeed * Time.deltaTime);

//        //currentSpeed += forwardinput * acceleration * Time.deltaTime;
//        if (currentSpeed > maxSpeed)
//        {
//            currentSpeed = maxSpeed;
//        }
//        if (currentSpeed < -maxSpeed)
//        {
//            currentSpeed = -maxSpeed;
//        }

//        //if (moveDirection.y == 0)
//        //{
//        //    if (currentSpeed > 0)
//        //    {
//        //        currentSpeed -= decceleration * Time.deltaTime;
//        //    }
//        //}

//        //{
//        //    if (currentSpeed > 0)
//        //        currentSpeed -= decceleration * Time.deltaTime;

//        //}
//        rb.velocity = new Vector2(moveDirection.x * currentSpeed, moveDirection.y * currentSpeed);

//        //this.transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);


//        ////steer the car to the left and right using user input
//        //float rotateinput = Input.GetAxis("Horizontal");
//        //rotateinput = rotateinput * rotateSpeed * Time.deltaTime;
//        //this.transform.Rotate(0, rotateinput, 0);
//    }
//    //private void OnCollisionEnter2D(Collision2D collision)
//    //{
//    //    rb.AddForce(-moveDirection * currentSpeed, ForceMode2D.Impulse);
//    //}

//}


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
    }
}
