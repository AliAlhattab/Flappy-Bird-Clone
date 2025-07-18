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
    public BirdScript bird;
    


    public void addScore(int addToScore)
    {
        //if (bird.isBirdAlive)
        //{
        //playerScore = playerScore + addToScore;
        //score.text = playerScore.ToString();
        //}
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
