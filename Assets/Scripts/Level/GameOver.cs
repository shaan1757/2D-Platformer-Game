using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void PlayerDead()
    {
        gameObject.SetActive(true);
    }
    public void  ReloadLevel()
    {
      SceneManager.LoadScene(1);
    }
    public void restart()
    {
        ReloadLevel(); 
    }

    public void Quit()
   {
    Debug.Log("QUIT!");
   }
}
