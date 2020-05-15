
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false){
            Debug.Log("Dead");
            gameHasEnded = true;
            //restart game
            Invoke("goRe", restartDelay);
        }
        
    }
    private void goRe()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("win");
        completeLevelUI.SetActive(true);
    }
}
