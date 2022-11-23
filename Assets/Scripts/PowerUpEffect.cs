using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpEffect : ScriptableObject
{
    //Allows a script to add its affect to te player when a powerup is collected
    public abstract void Apply(GameObject target);

}
