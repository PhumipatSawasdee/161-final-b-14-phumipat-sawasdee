using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast();
    }

    public override void Cast() 
    {
        base.Cast();
        Cast("Fire ball");
    }
}
