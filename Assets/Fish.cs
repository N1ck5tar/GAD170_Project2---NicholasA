using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public string species; // Fish species

    public string rarity; // Fish rarity
    public float rarityValue; // The % the value is increased by
    public float rarityBase;
    public float rarityUpdated;

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
        #region
        int r = Random.Range(1, 101);

        if (r >= 1 && r <= 50) // common
        {
            rarityValue = 1.1f;

            rarity = "Common";
        }

        

        #endregion

        int i = Random.Range(1, 101);

        
        
        #region Cod
        if (i >= 1 && i <= 12) // 12% chance
        {
            species = "Cod"; // Set the type of fish
            length = Random.Range(2, 5);

            rarityBase = Random.Range(20, 30); // Base Price
            rarityUpdated = rarityBase * rarityValue; // Increased price by Rarity
            value = (int)rarityUpdated; // Turn into an int
        }
        #endregion

        #region Slamon
        if (i >= 13 && i <= 24)
        {

        }
        #endregion

        #region Trout
        if (i >= 25 && i <= 36)
        {

        }
        #endregion

        #region Piranha
        if (i >= 37 && i <= 47) // 11% chance
        {

        }
        #endregion

        #region Catfish
        if (i >= 48 && i <= 58)
        {

        }
        #endregion

        #region Swordfish
        if (i >= 59 && i <= 68)
        {

        }
        #endregion

        #region Bass
        if (i >= 69 && i <= 78)
        {

        }
        #endregion

        #region Blobfish
        if (i >= 79 && i <= 83)
        {

        }
        #endregion

        #region Pufferfish
        if (i >= 84 && i <= 88)
        {

        }
        #endregion

        #region Clownfish
        if (i >= 89 && i <= 92)
        {

        }
        #endregion

        #region Barracuda 
        if (i >= 93 && i <= 96)
        {

        }
        #endregion

        #region Anglerfish
        if (i >= 97 && i <= 100)
        {

        }
        #endregion
    }
}
