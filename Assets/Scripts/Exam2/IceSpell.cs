using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
    }

    public override void Cast()
    {
        base.Cast();
        Cast("Ice Shard", 5);
    }
}
