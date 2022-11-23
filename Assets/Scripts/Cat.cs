using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Animator myCatAnimator;
    public GameObject myCatSprite;
    // Activates when FirePowerUp script is activated from collision
    public bool fireAbility = false;
    // Activates when FirePowerUp script is activated from collision
    public bool iceAbility = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        myCatAnimator.SetFloat("CatUp", verticalInput);

        if (horizontalInput > 0)
        {
            //moving to the right
            myCatAnimator.SetBool("CatWalking", true);
            myCatSprite.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            //moving to the left
            myCatAnimator.SetBool("CatWalking", true);
            myCatSprite.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //not moving to the right
            myCatAnimator.SetBool("CatWalking", false);
        }

        if (fireAbility)
        {
            MeshRenderer f = GetComponent<MeshRenderer>();
            f.material.color = Color.red;
        }
        if (iceAbility)
        {
            MeshRenderer i = GetComponent<MeshRenderer>();
            i.material.color = Color.blue;
        }
       
    }
}
