using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Manager : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Detected something"); 
        }
    }
}
