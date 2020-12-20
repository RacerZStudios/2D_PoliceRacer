using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerController_2D : MonoBehaviour
{
    public float speed = 10; 
    private void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) // up 
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed * Time.deltaTime); 
        }
        else if (Input.GetKey(KeyCode.A)) // left
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S)) // down
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D)) // right
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed * Time.deltaTime);
        }
    }
}