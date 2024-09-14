using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private const bool V = true;
    [SerializeField] private AudioSource maintheme;
    public GameObject deathMenu;
    public IEnumerator Death()
    {
        FindObjectOfType<PauseMenu>().isDead = true;
        maintheme.Stop();
        yield return new WaitForSeconds(2);
        Time.timeScale = 0f;
        deathMenu.SetActive(true);
    }
    
    void Start()
    {
         if (deathMenu != null)
        {
            deathMenu.SetActive(false);
        }
        else
        {
            Debug.LogError("Death menu GameObject is not assigned in the inspector!");
        }
    }
}
