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

    private void Update()
    {
        // Input handling
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = -Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = -Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        // Movement
        rb.velocity = direction * speed;
    }     

   }

