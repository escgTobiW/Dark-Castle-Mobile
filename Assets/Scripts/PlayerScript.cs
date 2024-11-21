using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

        
       
    public bool canMove = true;

    public GameObject player;

    public float speed;
    public float jump;

    bool dead = false;
    float wait = 1;

   

    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    Animator anim;


    Helping Helping;


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



            //-----Controls--------

            //---JUMP---         (was UP)
            if (((Input.GetMouseButtonDown(0) == true) || (Input.touchCount > 0)) && (Helping.GroundCheck(0, -1)) == true)
            {
                //anim.SetBool("jump", true);
                rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);

                
            }
            /*
            if (Helping.GroundCheck(0, 0) == false)
            {
                anim.SetBool("jump", true);
            }
            else
            {
                anim.SetBool("jump", false);
            }
            */
            
          
                
                


            
         
            else
            {

                anim.SetBool("run", false);

            }

            //----ATTACK---
            if (Input.GetKey("q") == true)
            {
                anim.SetBool("attack", true);
            }
            else
            {
                anim.SetBool("attack", false);
            }
            

        }
        //-----------------------

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
            //spriteRenderer.sprite = spriteDown;
            dead = true;
          

        }
       
    }

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
}
