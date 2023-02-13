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
        power = 100;
        Powerup.text = "Power: " + power;
        Win.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (power == 0)
        {
            Win.text = "Rocky soil makes it hard for plants to grow...";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "powerup" || collision.tag == "power1") {
            power = power + 1;
        }
        if (collision.tag == "rock" || collision.tag == "rock1")
        {
            power = power - 1;
        }
        Powerup.text = "Power: " + power;
    }
}
