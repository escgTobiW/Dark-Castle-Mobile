using UnityEngine;

public class castleDoor : MonoBehaviour
{


    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if ((Input.GetMouseButtonDown(0) == true) || (Input.touchCount > 0))
        {
            anim.SetBool("open", true);
          

        }
    }
}
