using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("DeathScreen");
    }
    
}
