using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    public GameObject gameScene;
    


    public void addScore(int addToScore)
    {
        playerScore = playerScore + addToScore;
        score.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void startGame()
    {

        SceneManager.LoadScene("GameScene");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
