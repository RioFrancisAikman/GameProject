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

        PlayerMovementPokemonStyle();

        PlayerMovementTankStyle();
    }
    public void PlayerMovementPokemonStyle()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
    }

    public void PlayerMovementTankStyle()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontalInput, 0);

        transform.Translate(Vector3.forward * verticalInput, 0);
    }
}
