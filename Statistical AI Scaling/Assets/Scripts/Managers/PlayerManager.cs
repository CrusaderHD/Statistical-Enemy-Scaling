using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    [Header("Added Scripts")]
    [SerializeField] private UIManager ui_Manager;
    [SerializeField] private PlayerStats playerStats;


    [Header("Level Handlers")]
    public int playerCurrentLevel;
    public int minPlayerLevel = 1;
    public int maxPlayerLevel = 99;
    public bool levelUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IncreasePlayerLevel();
    }

    public void IncreasePlayerLevel()
    {
        //TODO: Add a way that will add the carry over experience from leveling up onto next expereience bar.
        //If the players current is >= to the max expereince the player can receive. Player will level up.
        if (ui_Manager.currentExperience >= ui_Manager.maxExperience)
        {
            levelUp = true;
            playerCurrentLevel++;
            ui_Manager.playerLevelText.text = playerCurrentLevel.ToString();
            playerStats.IncreasePlayerStats();
            return;
        }
    }

}
