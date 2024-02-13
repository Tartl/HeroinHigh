using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


    public AudioMixer MainMixer;

    void Start()
    {
        SetVolumeToMinimum();
    }

    void SetVolumeToMinimum()
    {
        if (MainMixer != null)
        {
            float minVolume = -80f; // Nejnižší hodnota hlasitosti
            MainMixer.SetFloat("volume", minVolume);
        }
        
    }
}

