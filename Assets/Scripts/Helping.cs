using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
//using static UnityEngine.RuleTile.TilingRuleOutput;

public class Helping : MonoBehaviour
{


    public void FlipObject(bool flip)
    {
        SpriteRenderer spriteRen = gameObject.GetComponent<SpriteRenderer>();


        if (flip == true)
        {

            spriteRen.flipX = true;
        }
        else
        {
            spriteRen.flipX = false;
        }




    }
    public bool GroundCheck(float xOff, float yOff)
    {

        Color rayColour;

        float distanceToCheck = 0.01f;
        bool isGrounded;


        Vector3 offset = new Vector3(xOff, yOff, 0);
        if (Physics2D.Raycast(transform.position + offset, Vector2.down, distanceToCheck))
        {
            isGrounded = true;
            rayColour = Color.red;
        }
        else
        {
            isGrounded = false;
            rayColour = Color.white;
        }

        Debug.DrawRay(transform.position + offset, Vector2.down * distanceToCheck, rayColour);

        return isGrounded;

    }



    public bool WallCheckRight(float xOff, float yOff)
    {

        //Color rayColour;

        float distanceToCheck = 0.1f;
        bool wallRight;


        Vector3 offset = new Vector3(xOff, yOff, 0);
        if (Physics2D.Raycast(transform.position + offset, Vector2.right, distanceToCheck))
        {
            wallRight = true;
            //rayColour = Color.red;
        }
        else
        {
            wallRight = false;
            //rayColour = Color.white;
        }

        //Debug.DrawRay(transform.position + offset, Vector2.right * distanceToCheck, rayColour);

        return wallRight;

    }

    public bool WallCheckLeft(float xOff, float yOff)
    {

        //Color rayColour;

        float distanceToCheck = 0.1f;
        bool wallLeft;


        Vector3 offset = new Vector3(xOff, yOff, 0);
        if (Physics2D.Raycast(transform.position + offset, Vector2.right, distanceToCheck))
        {
            wallLeft = true;
            //rayColour = Color.red;
        }
        else
        {
            wallLeft = false;
            //rayColour = Color.white;
        }

        //Debug.DrawRay(transform.position + offset, Vector2.right * distanceToCheck, rayColour);

        return wallLeft;

    }

}












/*


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
*/

