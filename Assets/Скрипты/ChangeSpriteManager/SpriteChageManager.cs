using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChageManager : MonoBehaviour
{
    public SpriteRenderer Vada;
    public GameObject tourch;
    public Sprite newSprite;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            Vada.sprite = newSprite;
            tourch.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
