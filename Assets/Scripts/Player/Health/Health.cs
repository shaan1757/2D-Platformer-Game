using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public PlayerControllerScript player;

    [SerializeField] private float startingHealth;
    public float currentHealth{get;private set;}
    private Animator anim;
    private bool Dead;
    
    private void Awake() 
    {
        currentHealth = startingHealth;    
        anim = GetComponent<Animator>();    
    }
    public void Takedamage(float _damage) 
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage,0,startingHealth);
        if(currentHealth > 0)
        {
            anim.SetTrigger("Hurt");
        }
        else
        {
            if(!Dead)
            {
                anim.SetTrigger("IsDead");
                GetComponent<PlayerMovement>().enabled =false;
                Dead = true;
                player.KillPlayer();
            } 
        }
    }
    public void update()
    {
        
    }
   public void AddHealth(float _value)
   {
    currentHealth = Mathf.Clamp(currentHealth + _value,0,startingHealth);
   } 
}    
