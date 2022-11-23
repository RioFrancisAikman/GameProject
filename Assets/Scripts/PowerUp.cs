using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    

    public PowerUpEffect powerUpEffect;
    private void OnTriggerEnter(Collider collision)
    {
        // Player collects the item
        Destroy(gameObject);
        // Uses the powerUpEffect code
        powerUpEffect.Apply(collision.gameObject);
       
       
    }
    
}
