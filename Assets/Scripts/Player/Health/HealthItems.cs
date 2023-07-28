using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItems : MonoBehaviour
{
    [SerializeField] private float healthVal;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        other.GetComponent<Health>().AddHealth(healthVal); 
    }
}
