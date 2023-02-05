using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollisionGetVelocity : MonoBehaviour
{
    GameObject player;
    
    // Variable for Velocity.
    float hitVelocity;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        // Access move script
        Move move = player.GetComponent<Move>();
        // Apply Player velocity to hit Velocity for FMOD parameter modulation.
        hitVelocity = move.PlayerVelocity;
        // Display in Console
        print(hitVelocity);

        // Access the FMOD eventent emitter that plays the sound effect.
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        // Apply Velocity value to the impact parameter and send to FMOD event.
        emitter.SetParameter("impact", hitVelocity);
    }
}
