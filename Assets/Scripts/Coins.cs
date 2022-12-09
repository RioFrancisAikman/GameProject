using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("A collision has happened");

        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Coin collected");

            Destroy(gameObject, 0.5f);
            CoinCounter.instance.IncreaseCoins(value);

            //added coin to player
            if (value == 1)
            {
                collider.gameObject.GetComponent<Player>().CollectedCoin(1);
            } else if (value == 5)
            {
                collider.gameObject.GetComponent<Player>().CollectedCoin(5);
            }

            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay still");
    }
    
    
}
