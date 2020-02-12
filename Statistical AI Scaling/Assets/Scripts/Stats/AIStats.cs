using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStats : MonoBehaviour
{

    public AIManager ai_Manager;
    public BaseStats baseStats;

    [Header("AI Stat Tracker")]
    public int aiMinHealth;
    public int aiCurrentHealth;
    public int aiMaxHealth;

    public int aiMinMana;
    public int aiCurrentMana;
    public int aiMaxMana;

    public int aiMinStamina;
    public int aiCurrentStamina;
    public int aiMaxStamina;

    public int aiMinSpellPower;
    public int aiCurrentSpellPower;
    public int aiMaxSpellPower;

    public int aiMinAgility;
    public int aiCurrentAgility;
    public int aiMaxAgility;

    public int aiMinDefense;
    public int aiCurrentDefense;
    public int aiMaxDefense;

    public int aiMinStrength;
    public int aiCurrentStrength;
    public int aiMaxStrength;


    // Start is called before the first frame update
    void Start()
    {
        StartingAIStats();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("AI Health = " + baseStats.health);
        Debug.Log("AI Mana = " + baseStats.mana);
        //Debug.Log("AI Stamina = " + baseStats.stamina);
        //Debug.Log("AI Spell Power = " + baseStats.spellPower);
        //Debug.Log("AI Agility = " + baseStats.agility);
        //Debug.Log("AI Defense = " + baseStats.defense);
        //Debug.Log("AI Strength = " + baseStats.strength);
    }

    public void StartingAIStats()
    {
        baseStats.minHealth = 0;
        baseStats.health = 100;

        baseStats.minMana = 0;
        baseStats.mana = 45;

        baseStats.minStamina = 0;
        baseStats.stamina = 30;

        baseStats.minSpellPower = 0;
        baseStats.spellPower = 15;

        baseStats.minAgility = 0;
        baseStats.agility = 10;

        baseStats.minDefense = 0;
        baseStats.defense = 9;

        baseStats.minStrength = 0;
        baseStats.strength = 5;
    }

    public void IncreaseAIStats()
    {
        if (ai_Manager.aiCurrentLevel == 2)
        {
            baseStats.health += 7;
            baseStats.mana += 5;
            baseStats.stamina += 10;
            baseStats.spellPower += 10;
            baseStats.agility += 3;
            baseStats.defense += 2;
            baseStats.strength += 2;
        }

        if (ai_Manager.aiCurrentLevel == 3 && ai_Manager.aiCurrentLevel != 2)
        {
            baseStats.health += 7;
            baseStats.mana += 5;
            baseStats.stamina += 10;
            baseStats.spellPower += 10;
            baseStats.agility += 3;
            baseStats.defense += 2;
            baseStats.strength += 2;
        }

        if (ai_Manager.aiCurrentLevel == 4 && ai_Manager.aiCurrentLevel != 3)
        {
            baseStats.health += 7;
            baseStats.mana += 5;
            baseStats.stamina += 10;
            baseStats.spellPower += 10;
            baseStats.agility += 3;
            baseStats.defense += 2;
            baseStats.strength += 2;
        }

    }

}
