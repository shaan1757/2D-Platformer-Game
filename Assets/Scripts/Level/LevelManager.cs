using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    private static LevelManager instance;
    public static LevelManager Instance {get {return instance;}}

    public string Level1;
    public string[] Levels;
    private void Awake()
    {
        if(instance==null)
        {
            instance=this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        if(GetLevelStatus(Levels[0])==LevelStatus.Locked)
        {
            SetLevelStatus(Levels[0], LevelStatus.Unclocked);
        }
    }

    public void MarkLevelComplete()
    {
        UnityEngine.SceneManagement.Scene currentscene = SceneManager.GetActiveScene();
        Instance.SetLevelStatus(currentscene.name, LevelStatus.Completed);

        // int  nextSceneIndex = currentscene.buildIndex +1;
        // UnityEngine.SceneManagement.Scene nextscene = SceneManager.GetSceneByBuildIndex(nextSceneIndex);
        // Instance.SetLevelStatus(nextscene.name,LevelStatus.Unclocked);
        int currentsceneindex=Array.FindIndex(Levels, level => level == currentscene.name);
        int nextSceneIndex = currentsceneindex + 1;
        if(nextSceneIndex < Levels.Length)
        {
            SetLevelStatus(Levels[nextSceneIndex],LevelStatus.Unclocked);
            
        }


    }
    public LevelStatus GetLevelStatus(string level)
    {
        LevelStatus levelStatus = (LevelStatus) PlayerPrefs.GetInt(level,0);
        return levelStatus;
    }
    public void SetLevelStatus(string level, LevelStatus levelStatus)
    {
        PlayerPrefs.SetInt(level,(int)levelStatus);
        Debug.Log("Setting Level: "+level +"Status: "+ levelStatus);
    }
}
