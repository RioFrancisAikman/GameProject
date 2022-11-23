using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverScript : MonoBehaviour
{
    public bool isWaterFrozen;

    // Start is called before the first frame update
    void Start()
    {
        isWaterFrozen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWaterFrozen)
        {
            //Colour changes to show that the river is frozen
            MeshRenderer r = GetComponent<MeshRenderer>();
            r.material.color = Color.white;
        }
        else
        {
            isWaterFrozen = false;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Water freezes");

        if (collider.gameObject.tag == "IceProjectile")
        {
           // Water freezes and player can walk on it
            collider.gameObject.SetActive(false);
            isWaterFrozen = true;
            
        }
    }
}
