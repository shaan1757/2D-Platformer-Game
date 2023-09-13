using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class Levelloader : MonoBehaviour
{
   private Button button;
   public string LevelName;

   private void Awake()
   {
      button = GetComponent<Button>();
      button.onClick.AddListener(onclick);
   }
   private void onclick()
   {
      LevelStatus levelStatus = LevelManager.Instance.GetLevelStatus(LevelName);
      switch(levelStatus)
      {
         case LevelStatus.Locked:
            Debug.Log("level locked ,cant play until you complete previous level");
            break;

         case LevelStatus.Unclocked:
            SceneManager.LoadScene(LevelName);
            break;

         case LevelStatus.Completed:
            SceneManager.LoadScene(LevelName);
            break;
      }
      
   }

}
