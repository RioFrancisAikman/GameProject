using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int coinsCollected = 0; //declared and assigned in a single line
    private float speed;
    public bool tutorialComplete;
    public int playerLevel;
    public Animator myAnimator;
    public GameObject mySprite;

    Player myPlayer_script;
    Player myPlayer2_script;
    Player myPlayer3_script;
    Player myPlayerCat_script;


    public bool firePowerup;
    public float fireTimer;
    public bool icePowerup;
    public float iceTimer;
    Renderer r;

    public Transform fireSpawnPoint;
    public GameObject myFireObjectToSpawn;
    public Transform iceSpawnPoint;
    public GameObject myIceObjectToSpawn;
    //public Text coinUIText;


    // Start is called before the first frame update
    void Start()
    {
        speed = 2.2f;
      
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 3.0f;

        Fireball();
        Iceball();
        

        

        

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variable
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        myAnimator.SetFloat("Up", verticalInput);


        if(horizontalInput > 0)
        {
            //moving to the right
            myAnimator.SetBool("Walking", true);
            mySprite.transform.localScale = new Vector3(-2, 2, 2);
        } else if (horizontalInput < 0)
        {
            //moving to the left
            myAnimator.SetBool("Walking", true);
            mySprite.transform.localScale = new Vector3(2, 2, 2);
        } else
        {
            //not moving to the right
            myAnimator.SetBool("Walking", false);
        }


        


            //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
            Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);
        //
        //
        //If statement equality tests
        //
        // == are exactly the same
        // < is less than
        // > is greater than
        // <= is less than or equal to
        // >= is greater than or equal to
        // != is NOT equal to
        // 

        //picked up a coin from something
        //all three of these add 1 coin

        //using the return function to test if something is true

        

        //coinsCollected++;
        //coinsCollected = coinsCollected + 1;


        



        if (coinsCollected == 1)
        {
            //is true, do some code
           // Debug.Log("its TRUEEEEEEEEEEEEEEEEEEEEEE, we have 1 coins now");
        }
        else
        {
            //Debug.Log("it wasnt true after all, we have 0 coins");
        }



       

        //OR example
        if (coinsCollected == 1 || coinsCollected == 2)
        {

           // Debug.Log("we have 1 or 2 coins, but not 0 or 3+");
        }
        else
        {
           // Debug.Log("we have 0 or 3+ coins, but not 1 or 2");

        }


        ///
        /// AND example 
        if (coinsCollected == 1 && tutorialComplete == true && speed > 3.0f)
        {
            //
            //Debug.Log("have 1 coin, and tutorial is complete (true)");

        }
        else
        {
           // Debug.Log("either we dont have 1 coin, or the tutorial is not complete");
        }

        ///
        ///If Else If example
        if (coinsCollected == 0)
        {
            //we have 0

        }
        else if (coinsCollected == 1)
        {
            //we have 1 coins
        }
        else
        {
            //we have not 0 or 1 coins (so 2+, or minus)
        }
    }
    public void CollectedCoin(int numberOfCoinsCollectedInThisAction)
    {
        coinsCollected += numberOfCoinsCollectedInThisAction;
        if (coinsCollected == 5)
        {
            //player has collected enough coins to level up
            playerLevel += 1;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log("collision has happened eh, and it was " + collision.gameObject.name);

        if (collision.gameObject.name == "Wall")
        {
            //We hit the wall!!


        }

    }
    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("collision has ended with " + collision.gameObject.name);
    }

    public void FireballPowerUpFunction()
    {
        //turn on fire power
        firePowerup = true;
        //reset timer
        fireTimer = 0.0f;
       

    }

    public void IceballPowerUpFunction()
    {
        //turn on ice power
        icePowerup = true;
        //reset timer
       iceTimer = 0.0f;

    }

   public void Fireball()
    {
        if (Input.GetButtonDown("FireAttack"))
        {
            if (firePowerup == true)
            {
                
                Debug.Log("Your cat used Fire Blast");
                GameObject FireProjectile = Instantiate(myFireObjectToSpawn, fireSpawnPoint.position, Quaternion.identity) as GameObject;
                Rigidbody r = FireProjectile.GetComponent<Rigidbody>();

                FireProjectile.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
              //  Debug.Break();
                r.AddRelativeForce(Vector3.forward * 100);
            }
            else
            {
                //no power, no fire
                Debug.Log("No Fire Powerup!");
                
            }
        }

        //add the fraction of a second to our timer
        fireTimer += Time.deltaTime;
        if (fireTimer >= 60.0f)
        {
            //run out of time to shoot fire
            firePowerup = false;
            
        }
      



        
        
    }

    void Iceball()
    {
        if (Input.GetButtonDown("IceAttack"))
        {
            if (icePowerup == true)
            {
               
                Debug.Log("Your cat used Ice Blast");
                GameObject IceProjectile = Instantiate(myIceObjectToSpawn, iceSpawnPoint.position, Quaternion.identity) as GameObject;
                Rigidbody r = IceProjectile.GetComponent<Rigidbody>();

                IceProjectile.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
                //Debug.Break();
                r.AddRelativeForce(Vector3.forward * 100);
            }
            else
            {
                //no power, no ice
                Debug.Log("No Ice Powerup!");
                icePowerup = false;
            }
        }

        //add the fraction of a second to our timer
        iceTimer += Time.deltaTime;
        if (iceTimer >= 60.0f)
        {
            //run out of time to shoot ice
            icePowerup = false;
            
        }


        //fire powerup
        if (firePowerup == true)
        {
            r.material.color = Color.red;
        }
        //ice powerup
        if (icePowerup == true)
        {
            r.material.color = Color.blue;
        }
       if (firePowerup == false && icePowerup == false)
        {
            r.material.color = Color.white;
        }

        
        
       
        
    }
}

