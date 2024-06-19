using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    void Start()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
        else
        {
            Debug.LogError("Pause menu GameObject is not assigned in the inspector!");
        }
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (isPaused && Input.GetKeyDown(KeyCode.M))
        {
            GoToMainMenu(); // Pokud je hra pozastavena a hráè stiskne M, vrátí se do hlavního menu
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f; // Zastaví bìh hry
            Debug.Log("Game paused");
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f; // Obnoví bìh hry
            Debug.Log("Game resumed");
        }
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Nastaví èas na normální hodnotu (pokud byl náhodou pozastaven)
        SceneManager.LoadScene("MejnMenu"); // Naète scénu s hlavním menu
    }
}