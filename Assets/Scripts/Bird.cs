using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption;
    public float DailyFoodConsumption
    {
        get { return dailyFoodConsumption; }
        set { dailyFoodConsumption = value; }
    }

    private float weight;
    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    private void Start()
    {
        animalName = "Bird";
        DailyFoodConsumption = 0.25f;
        Weight = 0.5f;

        Init();
        FoodRequirement();
    }

    public override float CalculateFoodRequirement()
    {
        return DailyFoodConsumption *= Weight * 7;
    }

    public void FoodRequirement()
    {
        Debug.Log($"{animalName} eats {DailyFoodConsumption} kg with activity level {Weight}");
        Debug.Log($"{animalName} weekly food requirement {CalculateFoodRequirement()} kg");
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} make sound (Tweet Tweet)");
    }
}
