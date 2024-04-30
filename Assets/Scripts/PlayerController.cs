using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private SpriteRenderer Pacman;


    public void Awake(){
        Pacman = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start(){}
 

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.D)){
         
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Pacman.flipX = false;

        } else if (Input.GetKey(KeyCode.A)){
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            Pacman.flipX = true;
        }
    }

}
