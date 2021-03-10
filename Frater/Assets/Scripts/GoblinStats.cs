using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinStats : MonoBehaviour
{
    void Start()
    {
        CreateCharacter goblinStats = new CreateCharacter();
        goblinStats.Hp = 5;
        goblinStats.DamageAmount = 4;
    }
}
