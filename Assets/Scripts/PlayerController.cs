using System.Collections;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Speed of Pacman
    private Rigidbody2D rb;
    private Vector2 direction = Vector2.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update(){

     HandleInput();
    }

    private void FixedUpdate()
    {
        // Movement
        rb.velocity = direction * speed;
    }     

    // Direction And Spirte Orientation Control
     private void HandleInput(){


           // Input handling
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) )
        {
            direction = Vector2.up;
            transform.rotation = Quaternion.Euler(0,0,90);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            direction = -Vector2.up;
            transform.rotation = Quaternion.Euler(0,0,-90);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            direction = -Vector2.right;
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
            transform.rotation = Quaternion.Euler(0,0,0);
        }


    }


   }

