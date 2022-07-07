using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;

    public void CloseMenu()
    {
        menu.gameObject.SetActive(false);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            menu.gameObject.SetActive(true);
        }
    }
}
