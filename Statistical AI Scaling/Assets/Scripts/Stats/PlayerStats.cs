using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Added Scripts")]
    public PlayerManager playerManager;
    public BaseStats baseStats;

    [Header("Player Stat Tracker")]
    public int playerMinHealth;
    public int playerCurrentHealth;
    public int playerMaxHealth;

    public int playerMinMana;
    public int playerCurrentMana;
    public int playerMaxMana;

    public int playerMinStamina;
    public int playerCurrentStamina;
    public int playerMaxStamina;

    public int playerMinSpellPower;
    public int playerCurrentSpellPower;
    public int playerMaxSpellPower;

    public int playerMinAgility;
    public int playerCurrentAgility;
    public int playerMaxAgility;

    public int playerMinDefense;
    public int playerCurrentDefense;
    public int playerMaxDefense;

    public int playerMinStrength;
    public int playerCurrentStrength;
    public int playerMaxStrength;

    // Start is called before the first frame update
    void Start()
    {
        StartingPlayerStats();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Player Health = " + playerCurrentHealth);
        Debug.Log("Player Max Health = " + playerMaxHealth);
        Debug.Log("Player Mana = " + playerCurrentMana);
        Debug.Log("Player Max Mana = " + playerMaxMana);
        //Debug.Log("Player Stamina = " + baseStats.stamina);
        //Debug.Log("Player Spell Power = " + baseStats.spellPower);
        //Debug.Log("Player Agility = " + baseStats.agility);
        //Debug.Log("Player Defense = " + baseStats.defense);
        //Debug.Log("Player Strength = " + baseStats.strength);
    }


    public void StartingPlayerStats()
    {
        playerMinHealth = baseStats.minHealth;
        playerCurrentHealth = baseStats.health;
        playerMaxHealth = baseStats.maxHealth;

        playerMinMana = baseStats.minMana;
        playerCurrentMana = baseStats.mana;
        playerMaxMana = baseStats.maxMana;

        playerMinStamina = baseStats.minStamina;
        playerCurrentStamina = baseStats.stamina;
        playerMaxStamina = baseStats.maxStamina;

        playerMinSpellPower = baseStats.minSpellPower;
        playerCurrentSpellPower = baseStats.spellPower;
        playerMaxSpellPower = baseStats.maxSpellPower;

        playerMinAgility = baseStats.minAgility;
        playerCurrentAgility = baseStats.agility;
        playerMaxAgility = baseStats.maxAgility;

        playerMinDefense = baseStats.minDefense;
        playerCurrentDefense = baseStats.defense;
        playerMaxDefense = baseStats.maxDefense;

        playerMinStrength = baseStats.minStrength;
        playerCurrentStrength = baseStats.strength;
        playerMaxStrength = baseStats.maxStrength;
    }

    public void SetStatsOnLevel()
    {
        playerCurrentHealth = playerMaxHealth;
        playerCurrentMana = playerMaxMana;
        playerCurrentStamina = playerMaxStamina;
        playerCurrentSpellPower = playerMaxSpellPower;
        playerCurrentAgility = playerMaxAgility;
        playerCurrentDefense = playerMaxDefense;
        playerCurrentStrength = playerMaxStrength;
    }

    public void IncreasePlayerStats()
    {
        if (playerManager.playerCurrentLevel == 2)
        {
            playerMaxHealth += 10;
            playerMaxMana += 15;
            playerMaxStamina += 12;
            playerMaxSpellPower += 9;
            playerMaxAgility += 4;
            playerMaxDefense += 3;
            playerMaxStrength += 5;
            SetStatsOnLevel();
        }

        if (playerManager.playerCurrentLevel == 3 && playerManager.playerCurrentLevel != 2)
        {
            playerMaxHealth += 7;
            playerMaxMana += 5;
            playerMaxStamina += 10;
            playerMaxSpellPower += 10;
            playerMaxAgility += 3;
            playerMaxDefense += 2;
            playerMaxStrength += 2;
            SetStatsOnLevel();
        }

        if (playerManager.playerCurrentLevel == 4 && playerManager.playerCurrentLevel != 3)
        {
            playerMaxHealth += 7;
            playerMaxMana += 5;
            playerMaxStamina += 10;
            playerMaxSpellPower += 10;
            playerMaxAgility += 3;
            playerMaxDefense += 2;
            playerMaxStrength += 2;
            SetStatsOnLevel();
        }
    }
}
