using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Added Scripts")]
    public PlayerManager playerManager;

    [Header("Experience Handlers")]
    public Slider experienceSlider;
    public Text playerLevelText;
    public int experienceReceived;
    public int currentExperience;
    public int minExperience;
    public int maxExperience;

    //TODO: Make sure player level increase and expereince bar clears itself upon level up. baseExp = 0, maxExp = 1000. Add a .3 multiplyer per level up.
    //TODO: Figure out how to transfer experience from killing enimies to experience bar.

    //Awake Function.
    public void Awake()
    {
        playerManager.levelUp = false;
        playerManager.playerCurrentLevel = playerManager.minPlayerLevel;
        playerLevelText.text = playerManager.playerCurrentLevel.ToString();
        experienceSlider.minValue = minExperience;
        experienceSlider.value = currentExperience;
    }

    //Update function that calls every frame.
    public void Update()
    {
        if (playerManager.levelUp == true)
        {
            ResetExperienceBar();
        }
    }


    //Create ability to manage Experience bar.
    public void AddExperience()
    {
        //This is a test function
        experienceSlider.value += experienceReceived;  //Edits the value of the experience bar slider
        currentExperience += experienceReceived;       //Shows the current expereince amount as the amount received.
    }



    public void ResetExperienceBar()
    {
        if (playerManager.levelUp == true)
        {
            Debug.Log("Leveling Up and Resetting XP Bar");
            experienceSlider.value = experienceSlider.minValue;
            currentExperience = minExperience;
            playerManager.levelUp = false;
        }
    }

    //TODO: Create a way to add more experience needed per level. i.e: 100 experience for to go from Level 1 to 2. 1500 exp from level 2 to 3 etc..

    //Create a function to Open Character Stats panel. Show: HP, MP, STR, DEF, INT, Crit%.

    //Create function to open Inventory.
}
