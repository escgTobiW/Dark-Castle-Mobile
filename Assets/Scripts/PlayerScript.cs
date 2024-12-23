using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerScript : MonoBehaviour
{

        
       
    public bool canMove = true;

    public GameObject player;

    public float speed;
    public float jump;

    bool dead = false;
    float wait = 1;

    public LeftButton leftButtonScript;
    public RightButton rightButtonScript;

    public JumpButton jumpButtonScript;


    public bool buttonPress = false;

    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    Animator anim;


    Helping Helping;

    bool jumping = false;
    bool midair = false;

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        Helping = gameObject.AddComponent<Helping>();

    }


    void Update()
    {

        if (canMove == true)
        {
            //------------------Movement----------------------------------------
            if (leftButtonScript.buttonPress == true)
            {
                LEFT();
            }

            if (rightButtonScript.buttonPress == true)
            {
                RIGHT();
            }

            if ((leftButtonScript.buttonPress == false) && (rightButtonScript.buttonPress == false))
            {
                anim.SetBool("run", false);
            }

            //------------------Jumping----------------------------------------
            if ((Helping.GroundCheck(0, -1) == false) && (jumping == true))
            {
                midair = true;
            }

            if ((Helping.GroundCheck(0, -1) == true) && (midair == true))
            {
                anim.SetBool("jump", false);
                jumping = false;
                midair = false;
            }



        }
        //------------------Death----------------------------------------
        if (dead == true)
        {
            wait += Time.deltaTime;

        }
   
        if (wait > 5)
        {
            SceneManager.LoadScene("Castle");
        }

    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            
            canMove = false;
            anim.SetBool("dead", true);
            dead = true;
          

        }
       
    }
    //------------------Stairs----------------------------------------
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.CompareTag("up")) && (Input.GetKey("w") == true))
        {
            //go up stairs here
        }

        if ((other.gameObject.CompareTag("down")) && (Input.GetKey("s") == true))
        {
            //go down stairs here
        }
    }


    //-------------------BUTTON ACTIONS-----------------------
    public void LEFT()
    {
       
        if (Helping.GroundCheck(0, -1) == true)
        {
            anim.SetBool("run", true);
        }
        transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
        spriteRenderer.flipX = true;
       
    }

    public void RIGHT()
    {
        if (Helping.GroundCheck(0, -1) == true)
        {
            anim.SetBool("run", true);
        }
        transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
        spriteRenderer.flipX = false;
    }



    public void JUMP()
    {
        if (Helping.GroundCheck(0, -1) == true)
        {
            anim.SetBool("jump", true);
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            jumping = true; 
            
        }
    
    }




}
