using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Zombie", menuName = "ScriptableObject/Zobie")]
public class ZombiesSO : ScriptableObject
{
    [SerializeField]
    float Speed;

    [SerializeField]
    int MaxHealth;

    [SerializeField]
    int SunAmount;


    public float GetSpeed() 
    {

        return Speed;
    
    }

    public int GetSunAmount() 
    {
        return SunAmount;
    }

    public int GetMaxHealth()
    {
        return MaxHealth;
    }
}
