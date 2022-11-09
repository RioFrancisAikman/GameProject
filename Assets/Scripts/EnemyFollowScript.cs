using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowScript : MonoBehaviour
{

    public GameObject player;
    public VolumeDetection
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3.3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(volumeToMonitor.playerInsideVolume == true)
        {
            transform.LookAt(player.transform.position);

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
