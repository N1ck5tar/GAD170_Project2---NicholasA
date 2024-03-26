using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 
using UnityEngine.SceneManagement;

public class Aquarium : MonoBehaviour
{
    public bool gameFinished = false;

    public int turnsRemaining = 10; // Amount of turns the player has
    public int turnsPlayed = 0; // Amount of turns done by the player
    public int totalScore = 0;

    public GameObject newFishButton; // Button for a new fish
    public GameObject keepFishButton; // Button to keep the current fish caught
    public GameObject releaseFishButton;// Button to release the current fish caught
    public GameObject restartGameButton; // Button used to restart the game

    public GameObject totalScoreHolder; // The game object that holds the score UI
    public TextMeshProUGUI totalScoreDisplay; // Text at the end of the game that shows your total score

    public TextMeshProUGUI turns; // Displays the number of current turns 

    public GameObject currentFishHolderInfo; // Shows the stats of the current fish caught 
    public TextMeshProUGUI currentFishName; // Current fish's name
    public TextMeshProUGUI currentFishRarity;// Current fish's rarity
    public TextMeshProUGUI currentFishLength;// Current fish's length
    public TextMeshProUGUI currentFishValue;// Current fish's value
    public TextMeshProUGUI totalScoreText; // The total score displayed


    public GameObject fish; // The fish prefab that is used to spawn fish
    public GameObject fishHolder; // Holds the current fish created
    public List<Fish> allFish = new List<Fish>(); // List for holding fish's script in the aquarium

    public TextMeshProUGUI[] aquariumFishName = new TextMeshProUGUI[] { }; // Array for the fish's name for the aquarium
    public TextMeshProUGUI[] aquariumFishLength = new TextMeshProUGUI[] { };// Array for the fish's length for the aquarium
    public TextMeshProUGUI[] aquariumFishValue = new TextMeshProUGUI[] { };// Array for the fish's value for the aquarium




    void Start()
    {
        
    }

    
    void Update() 
    {
        if (gameFinished == false && turnsRemaining <= 0) // Checks if no turns remaining 
        {
            gameFinished = true; // Sets the game to finished

            restartGameButton.SetActive(true); // Turns on the restart button

            for (int i = 0; i < allFish.Count; i++) // Loops through all the fish caught
            {
                totalScore += allFish[i].GetComponent<Fish>().value; // Adds all values of the fishes together
            }

            totalScoreHolder.SetActive(true); // Turns on the UI to display final score
            totalScoreDisplay.text = totalScore.ToString("0"); // Puts total score into text
        }
    }   

    public void NewFish() // Button to get a new fish
    {
        if (turnsRemaining > 0) // Checks if there are turns remaining
        {
            newFishButton.GetComponent<Button>().interactable = false; // Prevents player from pressing new fish by making the button non interactable 

            fishHolder = Instantiate(fish); // Creates the fish and sets it as the fishHolder
            currentFishHolderInfo.SetActive(true); // Shows the information of the current fish
            
            


            keepFishButton.SetActive(true); // Displays the keep fish button
            releaseFishButton.SetActive(true); // Displays the release fish button

        }
    }

    public void KeepFish() // When a fish is put into the aquarium
    {
        allFish.Add(fishHolder.GetComponent<Fish>()); // Adds it the list for the aquarium


        aquariumFishName[turnsPlayed].text = fishHolder.GetComponent<Fish>().species; // Puts the information of species in the aquarium text to show in the UI
        aquariumFishLength[turnsPlayed].text = fishHolder.GetComponent<Fish>().length.ToString("0"); // Puts the information of length in the aquarium text to show in the UI
        aquariumFishValue[turnsPlayed].text = fishHolder.GetComponent<Fish>().value.ToString("0"); // Puts the information of value in the aquarium text to show in the UI


        turnsPlayed += 1; // Adds 1 to turns played
        turnsRemaining -= 1; // Removes 1 from turns remaining
        turns.text = turnsRemaining.ToString("0"); // Turns turns remaining into text 

        #region Checking for other fish
        for (int i = 0; i < allFish.Count; i++) // This for loop is going through all the fish the aquarium currently has
        {
            if (allFish[i].GetComponent<Fish>().length <= fishHolder.GetComponent<Fish>().length / 2 && allFish[i] != null) // checking if the fish that is being put in the aquarium is double the size of the fish in the aquarium
            {
                allFish[i].GetComponent<Fish>().ReleasedFish(); // Runs the release fish function on the current fish in the list
            }
        }
        for (int i = 0; i < turnsPlayed; i++) // Loop to change text in the UI
        {
            string lengthDisplayed = aquariumFishLength[i].text; // Converts current fish's length to a string
            float length = float.Parse(lengthDisplayed); // Then turning into a float
            if (length <= fishHolder.GetComponent<Fish>().length / 2 && aquariumFishLength[i].text != "0") // Checking if the fish in the aquarium will be eaten if current fish enters and is not already released/eaten
            {
                aquariumFishName[i].text = "Eaten"; // Shows that fish was eaten in text 
                aquariumFishName[i].color = Color.red; // Sets the colour to red to indicate further
                aquariumFishLength[i].text = "0"; // Length is set to 0
                aquariumFishValue[i].text = ""; // Sets value to nothing
            }
        }
        #endregion

        if (turnsRemaining > 0)
        {
            newFishButton.GetComponent<Button>().interactable = true; // New fish button can be interacted with again
        }
        keepFishButton.SetActive(false); // Turns off keep fish button
        releaseFishButton.SetActive(false); // Turns off release fish button
        currentFishHolderInfo.SetActive(false); // Turns off the current fish information
    }

    public void ReleaseFish() // Used to 'release' the fish
    {
        fishHolder.GetComponent<Fish>().ReleasedFish(); // Make the fish remove itself through ReleasedFish
        fishHolder = null; // Makes the fishHolder empty again

        aquariumFishName[turnsPlayed].text = "Released"; // Shows that fish was released in text
        aquariumFishName[turnsPlayed].color = Color.blue; // Sets the colour to blue to indicate further

        turnsPlayed += 1; // Adds 1 to turns played
        turnsRemaining -= 1; // Removes 1 from turns remaining 


        if (turnsRemaining > 0) // Checks to see if there are turns remaining
        {
            newFishButton.GetComponent<Button>().interactable = true; // Makes the new fish button interactable
        }
        keepFishButton.SetActive(false); // Turns off keep fish button
        releaseFishButton.SetActive(false); // Turns off release fish button
        currentFishHolderInfo.SetActive(false); // Turns off information of current fish
    }


    public void RemoveFish(Fish fishToRemove) // Gets the fish to remove
    {
        allFish.Remove(fishToRemove); // Removes the fish its told
    }

    public void PlayAgain() // Used to restart the game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restarts the game when the restart button is clicked
        
    }
}
