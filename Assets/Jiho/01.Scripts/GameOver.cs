using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    
    public void RestartButton()
    {
        Time.timeScale = 1;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
