using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSprite : MonoBehaviour
{
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3.3f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
    }
}
