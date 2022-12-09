using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("the player has entered the trigger");
            Player thePlayer = other.gameObject.GetComponent<Player>();

            //pickup the fire berry by setting the players bool to true
            thePlayer.FireballPowerUpFunction();
            

            Destroy(gameObject);
        }
    }
}