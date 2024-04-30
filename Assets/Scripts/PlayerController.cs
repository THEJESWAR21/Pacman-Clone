using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Varibles
    private float moveSpeed = 5f;

    // Components Reference
    private SpriteRenderer Pacman;
    private Rigidbody2D rb;

    // Gets Components Related To The Object
    public void Awake(){
        Pacman = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start(){

    }
 

    // Update is called once per frame
    void Update(){
        HandleInput();
     
    }



    private void HandleInput(){

	// RIGHT MOVEMENT
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
         
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0 , 0, 0);

        } 
	// LEFT MOVEMENT
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0 , 180, 0);
        } 
	// UP MOVEMENT
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0, 0 , 90);

        } 
	// DOWN MOVEMENT
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0, 0 , -90);
        }
        else{
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0 , 0, 0);
        }


    }

}
