using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBarrier_Condition : MonoBehaviour
{
    public bool hitBarrier;
    [SerializeField] private Chase_Manager cM; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "MainPlayer")
        {
            hitBarrier = true;
            cM.isBeingChased = true; 
            cM.SendMessage("IsBeingChased", 1);
            return; 
        }
    }
}
