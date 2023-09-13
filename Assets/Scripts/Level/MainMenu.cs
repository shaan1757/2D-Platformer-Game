using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   public GameObject LevelSelection;
   public void PlayGame()
   {
      LevelSelection.SetActive(true);
   }
   public void QuitGame()
   {
    Debug.Log("QUIT!");
   }
}
