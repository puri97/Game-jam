using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Powerct : MonoBehaviour
{
    public TextMeshProUGUI Powerup;
    public int power;
    public TextMeshProUGUI Win;
    // Start is called before the first frame update
    void Start()
    {
        power = 10;
        Powerup.text = "Power: " + power;
        Win.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (power == 0)
        {
            Win.text = "YOU LOSE :( BETTER LUCK NEXT TIME! ";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "powerup") {
            power = power + 10;
        }
        if (collision.tag == "rock")
        {
            power = power - 5;
        }
        Powerup.text = "Power: " + power;
    }
}
