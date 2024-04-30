using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Varibles
    public float moveSpeed;
    private float spriteRotation;
    private SpriteRenderer Pacman;

    // Gets Components Related To The Object
    public void Awake(){
        Pacman = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start(){

    }
 

    // Update is called once per frame
    void Update(){

        // KeyBindings
        if (Input.GetKey(KeyCode.D)){
         
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0 , 0, 0);

        } 
        else if (Input.GetKey(KeyCode.A)){

            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0 , 180, 0);
        } 
        else if (Input.GetKey(KeyCode.W)){

            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0, 0 , 90);

        } 
        else if (Input.GetKey(KeyCode.S)){

            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
            Pacman.transform.rotation = Quaternion.Euler(0, 0 , -90);
        }
    }

}
