using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 boxSize;
    public float maxDistance;
    public float jumpforce = 10f;
    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpforce * 0.5f, ForceMode.Impulse);
            isOnGround = false;
        }
       
    }
    

}
