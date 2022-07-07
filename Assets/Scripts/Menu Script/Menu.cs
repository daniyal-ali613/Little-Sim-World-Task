using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menu;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        menu.gameObject.SetActive(false);
        Time.timeScale = 1;
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
