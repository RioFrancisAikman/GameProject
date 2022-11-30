using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour
{
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(CalculateDistanceBetweenVectors(player.transform.position, transform.position));

        //look at the player
        transform.LookAt(player.transform.position);

        //grab the distance from between the vectors using new function
        float distanceToPlayer = CalculateDistanceBetweenVectors(player.transform.position, transform.position);

        //when the player is far away (5 units), chase the player
        if ( distanceToPlayer > 5.0f)
        {
            //chase the player
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }


    public float CalculateDistanceBetweenVectors(Vector3 v1, Vector3 v2)
    {
        //square root of 1.x-2.x squared, plus 1.y-2.y squared
        float x = v1.x - v2.x;
        float y = v1.y - v2.y;
        float z = v1.z - v2.z;

        //square root of the x y z squared
        x = Mathf.Pow(x, 2);
        y = Mathf.Pow(y, 2);
        z = Mathf.Pow(z, 2);

        // add the squared values
        float sqXYZ = x + y + z;
        //

        return Mathf.Sqrt(sqXYZ);


    }

}
