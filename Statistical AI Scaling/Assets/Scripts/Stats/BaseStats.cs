using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    //Create a list of base stats that both the Player and the AI can derive from starting at level 1.
    public int minHealth = 0;
    public int health =  100;
    public int maxHealth = 100;

    public int minMana = 0;
    public int mana = 45;
    public int maxMana = 45;

    public int minStamina = 0;
    public int stamina = 30;
    public int maxStamina = 30;

    public int minSpellPower = 0;
    public int spellPower = 15;
    public int maxSpellPower = 15;

    public int minAgility = 0;
    public int agility = 12;
    public int maxAgility = 12;

    public int minDefense = 0;
    public int defense = 10;
    public int maxDefense = 10;

    public int minStrength = 0;
    public int strength = 10;
    public int maxStrength = 10;
}
