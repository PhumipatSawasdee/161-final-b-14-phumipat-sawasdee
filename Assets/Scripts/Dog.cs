using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    public float DailyFoodConsumption
    {
        get { return dailyFoodConsumption; }
        set { dailyFoodConsumption = value; }
    }

    private int activityLevel;
    public int ActivityLevel
    {
        get { return activityLevel; }
        set { activityLevel = value; }
    }

    private void Start()
    {
        animalName = "Dog";
        DailyFoodConsumption = 1.25f;
        ActivityLevel = 2;

        Init();
        FoodRequirement();
    }

    public override float CalculateFoodRequirement()
    {
        return DailyFoodConsumption * ActivityLevel * 7;
    }

    public void FoodRequirement()
    {
        Debug.Log($"{animalName} eats {DailyFoodConsumption} kg with activity level {ActivityLevel}");
        Debug.Log($"{animalName} weekly food requirement {CalculateFoodRequirement()} kg");
    }

    public override void MakeSound() 
    {
        base.MakeSound();
        Debug.Log($"{animalName} make sound (Woof Woof)");
    }
}
