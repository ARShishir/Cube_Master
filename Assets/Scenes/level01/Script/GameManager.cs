using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gameHasEnded = false;

   public float restartDelay = 3f;
   public GameObject CompleteLevelUI;
    //public GameObject GameOverUI;



    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);

    }
    //public void GameOverUI()
    //{
    //    GameOverUI.SetActive(true);

    //}
    public void EndGame()
    {
      if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
