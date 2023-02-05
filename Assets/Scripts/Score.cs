using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretxt;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Scoretxt.text = "Score: " + score;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "powerup")
        {
            score = score + 5;
        }
        Scoretxt.text = "Score: " + score;
    }
}
