using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject endingCamera;

    void Start()
    {

        mainCamera.SetActive(true);
        endingCamera.SetActive(false);
    }

    private void Update()
    {
        endingCamera.transform.Translate(Vector2.up * 3 * Time.deltaTime);
    }
}
