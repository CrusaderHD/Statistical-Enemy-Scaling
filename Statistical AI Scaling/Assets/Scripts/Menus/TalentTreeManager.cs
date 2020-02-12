using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class TalentTreeManager : MonoBehaviour
{


    [Header("Added Scripts")]
    public PlayerManager playerManager;

    [Header("Specialization Buttons")]
    [SerializeField] private Button tankButton;
    [SerializeField] private Button dpsButton;

    [Header("Tank Buttons")]
    [SerializeField] private Button defenseButton;
    [SerializeField] private Button shieldSlamButton;
    [SerializeField] private Button groundSlamButton;
    [SerializeField] private Button shieldWallButton;

    [Header("DPS Buttons")]
    [SerializeField] private Button criticalHitButton;
    [SerializeField] private Button knockbackButton;
    [SerializeField] private Button secondCritButton;
    [SerializeField] private Button bladestormButton;

    // Start is called before the first frame update
    void Start()
    {
        tankButton.interactable = false;
        dpsButton.interactable = false;
        defenseButton.interactable = false;
        shieldSlamButton.interactable = false;
        groundSlamButton.interactable = false;
        shieldWallButton.interactable = false;
        criticalHitButton.interactable = false;
        knockbackButton.interactable = false;
        secondCritButton.interactable = false;
        bladestormButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        UnlockTalents();
    }

    public void UnlockTalents()
    {
        if (playerManager.playerCurrentLevel == 1)
        {
            LevelOnePlayer();
        }
        else if (playerManager.playerCurrentLevel == 2)
        {
            LevelTwoPlayer();
        }
        else if (playerManager.playerCurrentLevel == 3)
        {
            LevelThreePlayer();
        }
        else if (playerManager.playerCurrentLevel == 4)
        {
            LevelFourPlayer();
        }
        else if (playerManager.playerCurrentLevel == 5)
        {
            LevelFivePlayer();
        }

    }

    public void LevelOnePlayer()
    {
        tankButton.interactable = true;
        dpsButton.interactable = true;
    }

    public void LevelTwoPlayer()
    {
        defenseButton.interactable = true;
        criticalHitButton.interactable = true;

    }

    public void LevelThreePlayer()
    {
        shieldSlamButton.interactable = true;
        knockbackButton.interactable = true;

    }

    public void LevelFourPlayer()
    {
        groundSlamButton.interactable = true;
        secondCritButton.interactable = true;

    }

    public void LevelFivePlayer()
    {
        shieldWallButton.interactable = true;
        bladestormButton.interactable = true;

    }


}
