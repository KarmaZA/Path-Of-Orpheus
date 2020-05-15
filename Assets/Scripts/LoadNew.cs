using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNew : MonoBehaviour
{
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
