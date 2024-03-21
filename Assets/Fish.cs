using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public string species; // Fish species

    public string rarity; // Fish rarity
    public float rarityValue; // The % the value is increased by
    public float rarityBase; // Base price (visual purpose)
    public float rarityUpdated; // Fish value after rarity 

    public float length; // Fish length

    public int value; // Fish value

    public Aquarium aquarium;
    
    void Start()
    {
        aquarium = FindAnyObjectByType<Aquarium>();

        SelectFish();
    }
   

    void Update()
    {

            
    }





    private void SelectFish()
    {
        #region Rarity
        int r = Random.Range(1, 101);

        if (r >= 1 && r <= 50) // common
        {
            rarityValue = 1.1f;

            rarity = "Common";
        }

        

        #endregion


        int i = Random.Range(1, 101);

        
        #region Cod
        if (i >= 1 && i <= 12) // 12% chance V
        {
            species = "Cod"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Salmon
        if (i >= 13 && i <= 24)
        {
            species = "Salmon"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Trout
        if (i >= 25 && i <= 36)
        {
            species = "Trout"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Piranha
        if (i >= 37 && i <= 47) // 11% chance V
        {
            species = "Piranha"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Catfish
        if (i >= 48 && i <= 58)
        {
            species = "Catfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Swordfish
        if (i >= 59 && i <= 68) // 10% chance V
        {
            species = "Swordfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Bass
        if (i >= 69 && i <= 78)
        {
            species = "Bass"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Blobfish
        if (i >= 79 && i <= 83) // 5% chance V
        {
            species = "Blobfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Pufferfish
        if (i >= 84 && i <= 88)
        {
            species = "Pufferfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Clownfish
        if (i >= 89 && i <= 92) // 4% chance
        {
            species = "Clownfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Barracuda 
        if (i >= 93 && i <= 96)
        {
            species = "Barracuda"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Anglerfish
        if (i >= 97 && i <= 100)
        {
            species = "Anglerfish"; // Set the type of fish

            length = Random.Range(2, 5); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        Debug.Log("You Caught a " + species);


    }
}
