using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        // Ensure that the GameManager persists across scenes
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        NewGame();
    }

    public void NewGame()
    {
        this.score = 0;
        this.lives = 3;
        // Additional initialization code can go here
        Loadlevel(1);
    }

    private void Loadlevel(int level)
    {
        // Implementation for loading a level
        this.level = level;
        SceneManager.LoadScene("Level" + level);
    }
}
