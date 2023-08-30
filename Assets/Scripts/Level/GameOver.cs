using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject LevelSelection;
    public void PlayerDead()
    {
        gameObject.SetActive(true);
    }
    public void  ReloadLevel()
    {
      //SceneManager.LoadScene(1);
      Scene scene = SceneManager.GetActiveScene();
      SceneManager.LoadScene(scene.buildIndex);
    }
    public void restart()
    {
        ReloadLevel(); 
    }

    public void SelectLevel()
   {
     SceneManager.LoadScene("Start");
     LevelSelection.SetActive(true);
   }
}
