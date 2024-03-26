using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    public string species; // Fish species

    public string rarity; // Fish rarity
    public float rarityValue; // The % the value is increased by
    public float rarityBase; // Base price (visual purpose)
    public float rarityUpdated; // Fish value after rarity 

    public float length; // Fish length

    public int value; // Fish value

    //public bool releasedFish;

    public Aquarium aquarium; // Reference to the Aquarium script
    
    void Start()
    {
        aquarium = FindAnyObjectByType<Aquarium>(); // Finds the game object that has the 'Aquarium' script 

        SelectFish(); // Creates the fish when this script's object is spawned
    }
   

    void Update()
    {

            
    }
        

    public void ReleasedFish() // Used to destroy the fish
    {
        if(aquarium != null) // Checks to ensure reference is connected correctly
        {
            aquarium.RemoveFish(this); // Gets the current fish that will be removed (released) by the aquarium script
        }

        Destroy(gameObject); // Destroys the fish
    }


    private void SelectFish() // Used to create the fish its rarity, species, length and value
    {
        #region Rarity
        int r = Random.Range(1, 101); // Random number used to determine the fish's rarity

        if (r >= 1 && r <= 40) // Common 40%
        {
            rarityValue = 1.1f; // 10% increase in value

            rarity = "Common"; // Sets the rarity to Common
        }

        if (r >= 41 && r <= 70) // Uncommon 30%
        {
            rarityValue = 1.2f; // 20% increase in value

            rarity = "Uncommon"; // Sets the rarity to Uncommon
        }

        if (r >= 71 && r <= 85) // Rare 15%
        {
            rarityValue = 1.5f; // 50% increase in value

            rarity = "Rare"; // Sets the rarity to Rare
        }

        if (r >= 86 && r <= 95) // Epic 10%
        {
            rarityValue = 1.6f; // 60% increase in value

            rarity = "Epic"; // Sets the rarity to Epic
        }

        if (r >= 96 && r <= 100) // Legendary 5%
        {
            rarityValue = 2f; // 100% increase in value

            rarity = "Legendary"; // Sets the rarity to Legendary
        }

        #endregion


        int i = Random.Range(1, 101); // Random number used to determine the fish's species

        
        #region Cod
        if (i >= 1 && i <= 12) // 12% chance V
        {
            species = "Cod"; // Set the type of fish

            length = Random.Range(4, 9); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Salmon
        if (i >= 13 && i <= 24)
        {
            species = "Salmon"; // Set the type of fish

            length = Random.Range(4, 10); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Trout
        if (i >= 25 && i <= 36)
        {
            species = "Trout"; // Set the type of fish

            length = Random.Range(4, 10); // Makes the fish a random length

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Piranha
        if (i >= 37 && i <= 47) // 11% chance V
        {
            species = "Piranha"; // Set the type of fish

            length = Random.Range(4, 11); // Makes the fish a random length

            rarityBase = Random.Range(21, 32); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Catfish
        if (i >= 48 && i <= 58)
        {
            species = "Catfish"; // Set the type of fish

            length = Random.Range(5, 11); // Makes the fish a random length

            rarityBase = Random.Range(21, 32); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Swordfish
        if (i >= 59 && i <= 68) // 10% chance V
        {
            species = "Swordfish"; // Set the type of fish

            length = Random.Range(5, 11); // Makes the fish a random length

            rarityBase = Random.Range(22, 34); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Bass
        if (i >= 69 && i <= 78)
        {
            species = "Bass"; // Set the type of fish

            length = Random.Range(5, 11); // Makes the fish a random length

            rarityBase = Random.Range(22, 34); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Blobfish
        if (i >= 79 && i <= 83) // 5% chance V
        {
            species = "Blobfish"; // Set the type of fish

            length = Random.Range(4, 12); // Makes the fish a random length

            rarityBase = Random.Range(23, 36); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Pufferfish
        if (i >= 84 && i <= 88)
        {
            species = "Pufferfish"; // Set the type of fish

            length = Random.Range(4, 13); // Makes the fish a random length

            rarityBase = Random.Range(23, 36); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Clownfish
        if (i >= 89 && i <= 92) // 4% chance V
        {
            species = "Clownfish"; // Set the type of fish

            length = Random.Range(2, 18); // Makes the fish a random length

            rarityBase = Random.Range(10, 80); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Barracuda 
        if (i >= 93 && i <= 96)
        {
            species = "Barracuda"; // Set the type of fish

            length = Random.Range(5, 14); // Makes the fish a random length

            rarityBase = Random.Range(30, 46); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Anglerfish
        if (i >= 97 && i <= 100)
        {
            species = "Anglerfish"; // Set the type of fish

            length = Random.Range(5, 14); // Makes the fish a random length

            rarityBase = Random.Range(30, 46); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        Debug.Log("You Caught a " + species); // rarity, length, value (order)


        aquarium.currentFishName.text = aquarium.fishHolder.GetComponent<Fish>().species; // Gives the information of species to fishHolder
        aquarium.currentFishValue.text = aquarium.fishHolder.GetComponent<Fish>().value.ToString("0"); // Gives the information of value to fishHolder
        aquarium.currentFishRarity.text = aquarium.fishHolder.GetComponent<Fish>().rarity; // Gives the information of rarity to fishHolder
        aquarium.currentFishLength.text = aquarium.fishHolder.GetComponent<Fish>().length.ToString("0"); // Gives the information of length to fishHolder


    }
}
