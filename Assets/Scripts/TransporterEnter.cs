using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransporterEnter : MonoBehaviour
{
    public string lastExitName;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == lastExitName)
        {
            PlayerTransporter.instance.transform.position = transform.position;
            PlayerTransporter.instance.transform.eulerAngles = transform.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
