using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape")) 
        {
            Application.Quit();    
        }
    }
}
