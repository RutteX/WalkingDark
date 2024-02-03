using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildObject : MonoBehaviour
{
    [SerializeField]
    private GameObject buildObject;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        buildObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
