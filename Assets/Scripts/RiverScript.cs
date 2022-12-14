using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverScript : MonoBehaviour
{
    public bool isWaterFrozen;
    bool isdone = false;
    public Transform riverSpawnPoint;
    public GameObject myFrozenObjectToSpawn;
    public float delay = 10;
    float riverTimer;

    // Start is called before the first frame update
    void Start()
    {
        isWaterFrozen = false;
    }

    // Update is called once per frame
    void Update()
    {
        riverTimer += Time.deltaTime;
        if (isdone == false)
        {
            if (isWaterFrozen)
            {
                //Colour changes to show that the river is frozen
                MeshRenderer r = GetComponent<MeshRenderer>();
                r.material.color = Color.white;
               

                if (riverTimer > delay)
                {
                    Destroy(gameObject);
                }
                GameObject FrozenRiver = Instantiate(myFrozenObjectToSpawn, riverSpawnPoint.position, Quaternion.identity) as GameObject;

                isdone = true;

            }
            else
            {
                isWaterFrozen = false;
            }
        }
       
    }
    private void OnTriggerEnter(Collider collider)
    {
       

        if (collider.gameObject.tag == "IceProjectile")
        {
           // Water freezes and player can walk on it
            
            isWaterFrozen = true;
            
            Debug.Log("Water freezes");

        }
    }

   
}
