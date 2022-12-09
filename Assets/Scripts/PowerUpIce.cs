using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpIce : MonoBehaviour
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
            Debug.Log("the cat ate the ice berry");
            Player thePlayer = other.gameObject.GetComponent<Player>();

            //pickup the ice berry by setting the players bool to true
            thePlayer.IceballPowerUpFunction();

            Destroy(gameObject);
        }
    }
}
