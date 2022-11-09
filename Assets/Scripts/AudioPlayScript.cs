using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    AudioSource myAudio;

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
        if (collider.tag == "Player")
        {
            //if I need to stop audio playing
            myAudio.Stop();

            //check if audio is already playing
            if (myAudio.isPlaying == false)
            {
                myAudio.Play();
            }

            //set a parameter such as if I should be looping, true or false
            myAudio.loop = false;
        }
    }
}
