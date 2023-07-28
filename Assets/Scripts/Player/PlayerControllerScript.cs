using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerScript : MonoBehaviour
{
   public ScoreController score;
   public GameOver gameover;


//func for picking up key
    public void PickKey()
    {
        //Debug.Log("Player picked up the collectible");
        score.ScoreIncrement(25);
    }

    public void KillPlayer()
    {
        gameover.PlayerDead();
    }
   
}
   