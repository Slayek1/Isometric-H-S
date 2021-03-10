using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{ 
    void Start() 
    {
        CreateCharacter playerStats = new CreateCharacter();   
        playerStats.Hp = 5;
        playerStats.DamageAmount = 4;
    }
}