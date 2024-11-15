using UnityEngine;

public class RatFollow : MonoBehaviour
{
    public GameObject player;

    public float speed;
    public Vector2 playerPos;
    //Animator anim;




    private SpriteRenderer spriteRenderer;


    void Start()
    {

        //anim = GetComponent<Animator>();

        spriteRenderer = GetComponent<SpriteRenderer>();

    }



    void FixedUpdate()
    {

        Follow();


    }

    void Follow()
    {
        playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
        //anim.SetBool("move", true);
        if (player.transform.position.x > transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
