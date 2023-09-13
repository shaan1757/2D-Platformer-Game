using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteController : MonoBehaviour
{
    public string nextscene;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
      if(collision.gameObject.GetComponent<PlayerControllerScript>() != null)
      {
        //level completion 
        Debug.Log("you reached the end of the level");
        LevelManager.Instance.MarkLevelComplete();
        SceneManager.LoadScene(nextscene);
      }  
    }
}