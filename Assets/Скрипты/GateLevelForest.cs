using UnityEngine;
using UnityEngine.SceneManagement;

public class GateLevelForest : MonoBehaviour
{
    [SerializeField]
    private string linkLevel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Application.LoadLevel(linkLevel);
        }
    }
}
