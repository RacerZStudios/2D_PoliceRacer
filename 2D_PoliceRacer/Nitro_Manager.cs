using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Nitro_Manager : MonoBehaviour
{
    public int nitro = 0; //score 
    [SerializeField] public TMP_Text nitroText;
    public Transform[] nitroPos; 
    [SerializeField] public GameObject[] nitroObj;
    public GameObject nitroSpritePrefab; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "MainPlayer")
        {
            for(int i = 0; i < nitroObj.Length;i++)
            {
                nitroObj[i].transform.position = nitroPos[0].gameObject.transform.position;
                Instantiate(nitroSpritePrefab, nitroPos[0].transform.position, nitroPos[0].transform.rotation);
            }
            nitro ++;
            nitroText.text = nitro.ToString(); 
            Destroy(gameObject); 
        }
    }
}
