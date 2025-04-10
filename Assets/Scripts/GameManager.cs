using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void CheckAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            LoadNextScene();
        }
        else
        {
            BackToMenu();
        }
    }

    private void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      
        if (currentSceneIndex < 21) 
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
