using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init()
    {
        DisplayName(animalName);
        MakeSound();
    }

    public abstract float CalculateFoodRequirement();
    public virtual void MakeSound() 
    {
        Debug.Log("This animal make a sound ...");
    }
    public void DisplayName(string name) 
    {
        Debug.Log($"This animal is {name}");
    }
}
