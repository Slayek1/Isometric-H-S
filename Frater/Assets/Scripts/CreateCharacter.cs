using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter
{
    private int hp;
    private int damageAmount;

    [field: SerializeField]
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public int DamageAmount
    {
        get { return damageAmount; }
        set { damageAmount = value; }
    }
}