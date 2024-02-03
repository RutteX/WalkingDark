using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Tourch : MonoBehaviour
{
    private Light tourch;
    [SerializeField]
    private float powerTourch;

    void Start()
    {
        tourch = gameObject.GetComponent<Light>();
        tourch.range = powerTourch;
        StartCoroutine("TimeTourch");
    }

    private IEnumerator TimeTourch()
    {
        while (powerTourch > 4.5f)
        {
            tourch.intensity = Random.Range(2f, 3f);

            powerTourch -= 0.01f;
            tourch.range = powerTourch;
            yield return new WaitForSeconds(0.02f);
        }
        tourch.range = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "уголёк")
        {
            powerTourch = 10f;
            collision.gameObject.SetActive(false);
        }
    }

}
