using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aquarium : MonoBehaviour
{
    public int turnsRemaining = 10; // Amount of turns the player has

    public GameObject fish;
    public List<Fish> allFish = new List<Fish>();

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && turnsRemaining > 0)
        {
            Instantiate(fish);
        }
    }
}
