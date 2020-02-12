using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClasses : MonoBehaviour
{
    public enum E_Classes  { E_Warrior, E_Wizard, E_Archer};

    [Header("Effects")]
    public GameObject experienceOrb;

    [Header("Choose the enemy Class")]
    public E_Classes e_Classes = E_Classes.E_Warrior;

    [Header("Attached Scripts")]
    public AIManager ai_Manager;
    public AIStats ai_Stats;

    [Header("Bool Values")]
    public bool isEnemyAlive;

    public void Update()
    {
        ClassSelection();
    }

    //Create an AI Death Function. This is meant to be overridden per enemy class. 
    public void EnemyDeath()
    {
        if (ai_Stats.baseStats.health <= ai_Stats.baseStats.minHealth)
        {
            Debug.Log("Enemy Slain");
            isEnemyAlive = false;
            //Destroy gameObject and drop experience.
            Debug.Log("Dropping Experience..");
            experienceOrb = Instantiate(experienceOrb, transform.position, transform.rotation);
            Destroy(gameObject);
            //Play Death Animation here.
        }
    }

    public virtual void ClassSelection()
    {

        switch (e_Classes)
        {
            case E_Classes.E_Warrior:

                //Write code to select Warrior...
                if (isEnemyAlive == false)
                {
                    EnemyDeath();
                }
                

                break;


            case E_Classes.E_Archer:

                //Write code to select Archer...

                break;



            case E_Classes.E_Wizard:

                //Write code to select Wizard...

                break;
        }

    }

}
