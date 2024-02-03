using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private string nameScene;

    public void LoadSceneButtonMethod()
    {
        SceneManager.LoadScene(nameScene);
        Time.timeScale = 1f;
    }    

}
