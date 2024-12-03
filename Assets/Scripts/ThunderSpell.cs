using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSpell : Spell
{
    private void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        base.Cast();
        Cast("Thunder Bolt", 3, "Red");
    }

    public void Cast(string target, int powerLevel, string color)
    {
        Debug.Log($"Casting a {target} with power level {powerLevel}, and have a {color} color");
    }
}
