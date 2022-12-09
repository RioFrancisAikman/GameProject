using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate1 : MonoBehaviour
{

    public GameObject myPlayer;
    Player myPlayer_script;
   

    // Start is called before the first frame update
    void Start()
    {
        // making a refenrence between the player and gate
        myPlayer_script = myPlayer.GetComponent<Player>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayer_script.coinsCollected == 10)
        {
            transform.position = new Vector3(0, -10, 0);

        }
        
    }


}
