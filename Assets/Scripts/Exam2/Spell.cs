using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast() 
    {
        Debug.Log("Start Spell-Casting");
    }

    public void Cast(string target) 
    {
        Debug.Log($"Casting a {target}");
    }

    public void Cast(string target, int powerLevel) 
    {
        Debug.Log($"Casting a {target} with power level {powerLevel}");
    }
}
