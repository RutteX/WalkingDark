using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public bool menuActive = false;
    [SerializeField]private float timeWait = 0.0000000001f;

    void Update()
    {
        if (Input.GetKeyDown("escape")) 
        {
            menuActive = !menuActive;
            menu.SetActive(menuActive);  
            StopTime(menuActive);
        }
    }

    void StopTime(bool menuActive)
    {
        if(menuActive) 
        {
            Time.timeScale = timeWait;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}