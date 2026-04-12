using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthpoints = 3992;

    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); //4392

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); //4792

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); //5192

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints); //5592
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
