using UnityEngine.UI;
using UnityEngine;

public class ExperienceOrbs : MonoBehaviour
{

    public bool interactingWithPlayer = false;

    [Header("Orb Value")]
    [Range(0, 100)] public int orbValue;

    [Header("Added Scripts")]
    public UIManager uiManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactingWithPlayer = true;
            uiManager.currentExperience += orbValue;
            uiManager.experienceSlider.value += orbValue;
            Debug.Log("EXP Picked up: " + orbValue);
            Destroy(gameObject);
        }
    }



}
