using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate3 : MonoBehaviour
{
    public GameObject myplayer3;
    Player myplayer_script3;

    // Start is called before the first frame update
    void Start()
    {
        // making a refenrence between the player and gate
        myplayer_script3 = myplayer3.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myplayer_script3.coinsCollected == 30)
        {
            transform.position = new Vector3(0, -10, 0);

        }
    }
}
