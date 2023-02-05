using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0, 0, -10);
    }
}
