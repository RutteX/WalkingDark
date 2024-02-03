//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject optionMenu;

    public void ToOpenOptionMenu()
    {
        menu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void ToCloseOptionMenu()
    {
        menu.SetActive(true);
        optionMenu.SetActive(false);
    }
}
