using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateUI : MonoBehaviour
{
    
    
    public void RestartGame()
    {
        Debug.Log("Restart");
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenuScene");
    }
}
