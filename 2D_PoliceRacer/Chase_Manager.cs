using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase_Manager : MonoBehaviour
{
    public bool isBeingChased;
    public GameObject police;
    public GameObject chaseCam; 

    IEnumerator IsBeingChased()
    {
        if(isBeingChased == true)
        {
            chaseCam.SetActive(true); 
            police.gameObject.transform.position = this.transform.position;
            yield return new WaitForSeconds(1.0f); 
            chaseCam.SetActive(false);
            yield return null;  ; 
        }
        yield return null; 
    }
}