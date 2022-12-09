using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
{
    public GameObject myPlayer2;
    Player myPlayer2_script;

    // Start is called before the first frame update
    void Start()
    {
        // making a refenrence between the player and gate
        myPlayer2_script = myPlayer2.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayer2_script.coinsCollected == 20)
        {
            transform.position = new Vector3(0, -10, 0);

        }
    }
}
