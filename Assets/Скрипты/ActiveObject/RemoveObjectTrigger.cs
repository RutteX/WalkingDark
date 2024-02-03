using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObjectTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject removeObject;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        removeObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
