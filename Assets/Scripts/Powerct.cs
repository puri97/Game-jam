using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Powerct : MonoBehaviour
{
    public TextMeshProUGUI Powerup;
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        power = 10;
        Powerup.text = "Power: " + power;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "powerup") {
            power = power + 10;
        }
        
        Powerup.text = "Power: " + power;
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.tag == "rock")
    //    {
    //        power = power - 5;
    //    }
    //    Powerup.text = "Power: " + power;
    //}
}
