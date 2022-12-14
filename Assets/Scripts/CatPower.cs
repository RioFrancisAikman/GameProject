using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPower : MonoBehaviour
{
    public GameObject myPlayerCat;
    Player myPlayerCat_script;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        myPlayerCat_script = myPlayerCat.GetComponent<Player>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayerCat_script.firePowerup == true)
        {
            Debug.Log("the Cat turned red");
            sr.material.color = Color.red;

        }
        if (myPlayerCat_script.icePowerup == true)
        {
            Debug.Log("the Cat turned blue");
            sr.material.color = Color.blue;

        }
        if (myPlayerCat_script.firePowerup == false && myPlayerCat_script.icePowerup == false)
        {
            sr.material.color = Color.white;
        }


    }
}
