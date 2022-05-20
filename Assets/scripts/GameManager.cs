using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;

    void Awake()
    {
        Instance = this;
        
    }
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Restart()
    {
        // reset scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("GAme Over");
        Time.timeScale = 1;
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}