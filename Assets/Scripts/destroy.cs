using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject power;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.CompareTag("powerup")) { 
            Destroy(this.gameObject, 0.3f);
        }
        if (this.gameObject.CompareTag("surprise1")) {
            Instantiate(power, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    
    }
}
