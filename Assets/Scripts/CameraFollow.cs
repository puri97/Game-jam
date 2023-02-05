using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    // Update is called once per frame

    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject endingCamera;

    private bool mainBoolean;
    private bool endingBoolean;

    void Start()
    {

        mainCamera.SetActive(true);
        endingCamera.SetActive(false);
    }

    private void Update()
    {
         mainCamera.transform.position = player.position + new Vector3(0, 0, -10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "water")
        {
            mainCamera.SetActive(false);
            endingCamera.SetActive(true);
            endingBoolean = true;
            Debug.Log("Water");
        }
    }
}
