using UnityEngine;
using UnityEngine.UI;

public class AIManager : MonoBehaviour
{
    [Header("Attached Scripts")]
    [SerializeField] private AIStats ai_Stats;
    [SerializeField] private ExperienceOrbs expOrbs;

    [Header("Level Handlers")]
    public int aiCurrentLevel;
    public int minAiLevel = 1;
    public int maxAiLevel = 99;
    public Text aiLevelText;
    public bool levelUp = false;

    [Header("Experience Handlers")]
    [SerializeField] private int experienceReceived;
    [SerializeField] private int currentExperience;
    [SerializeField] private int minExperience;
    [SerializeField] private int maxExperience;

    private void Awake()
    {
        levelUp = false;
        aiCurrentLevel = minAiLevel;
        aiLevelText.text = aiCurrentLevel.ToString();
        if (expOrbs == null)
        {
            expOrbs = gameObject.GetComponent<ExperienceOrbs>();
        }
    }

    //Update function that calls every frame.
    private void Update()
    {
        IncreaseAILevel();
        ResetExperienceBar();
        DealDamage();
    }


    //Create ability to manage Experience bar.
    public void AddExperience()
    {
        //This is a test function
        currentExperience += experienceReceived;       //Shows the current expereince amount as the amount received.
    }

    public void IncreaseAILevel()
    {
        //TODO: Add a way that will add the carry over experience from leveling up onto next expereience bar.
        //If the players current is >= to the max expereince the player can receive. Player will level up.
        if (currentExperience >= maxExperience)
        {
            levelUp = true;
            aiCurrentLevel++;
            aiLevelText.text = aiCurrentLevel.ToString();
            ai_Stats.IncreaseAIStats();
            return;
        }
    }

    public void ResetExperienceBar()
    {
        if (levelUp == true)
        {
            Debug.Log("Leveling Up and Resetting XP Bar");
            currentExperience = minExperience;
            levelUp = false;
        }
    }

    public void DealDamage()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ai_Stats.baseStats.health -= 20;
            Debug.Log("Dealing Damage to AI.");
        }
    }

}
