using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogsScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Logs burned");
        // When the player uses their powerup effect they can destroy any objects that are named "Logs"
        if (collider.gameObject.tag == "FireProjectile")
        {
           
            collider.gameObject.SetActive(true);
            // Destroyed after hit with a projectile
            Destroy(gameObject, 0.5f);

        
        }
    }
}
