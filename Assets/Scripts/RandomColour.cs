using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public Color[] ColorBank;
    public bool mesh;
    public bool sprite;
    



    // Start is called before the first frame update
    void Start()
    {
      


    }

    // Update is called once per frame
    void Update()
    {
        //Allows a set number of colours to be used on the object
            int Num = Random.Range(0, ColorBank.Length);
            if (mesh)
            {
                // mesh renderer is set with a material and the colour bank
                MeshRenderer m = GetComponent<MeshRenderer>();
                m.material.color = ColorBank[Num];
            }
            if (sprite)
            {
                SpriteRenderer s = GetComponent<SpriteRenderer>();
                s.material.color = ColorBank[Num];
                
            }
        

       
    }

}
