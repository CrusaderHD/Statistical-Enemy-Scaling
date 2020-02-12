using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //PlayGame is a function that will load the game scene.
    public void PlayGame()
    {
        //Load Scene
        //TODO: Update the scene/Build Index to ensure proper scenes are used and loaded.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //QuitGame will exit the user out of the game.
    public void QuitGame()
    {
        //Since this wont happen within the Unity Editor. Adding a Debug Log method.
        Debug.Log("Quitting Game.");
        Application.Quit();
    }
}
