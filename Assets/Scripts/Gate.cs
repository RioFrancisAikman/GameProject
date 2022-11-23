using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
   
   
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        // making a refenrence between the player and gate
        Player player;
        player = GetComponent<Player>();
       gameObject.GetComponent<Player>().coinsCollected = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.coinsCollected == 0)
        {
            transform.position = new Vector3(0, -10, 0);
        }
               
               
         
        
    }
}
