using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimple : MonoBehaviour
{
    
    public float speed;
    private float health; //unused health from UML

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * speed);
    }
}
