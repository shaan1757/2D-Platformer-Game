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
    IEnumerator  ReloadLevel()
    {
      
      yield return new WaitForSeconds(3);
      SceneManager.LoadScene(1);
    }
    public void restart()
    {
        StartCoroutine(ReloadLevel()); 
    }

    public void Quit()
   {
    Debug.Log("QUIT!");
   }
}
