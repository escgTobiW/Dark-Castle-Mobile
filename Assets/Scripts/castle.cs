using UnityEngine;
using UnityEngine.SceneManagement;

public class castle : MonoBehaviour
{

    float wait = 1;
    Animator anim;
    bool entering = false;

    void Start()
    {

        anim = GetComponent<Animator>();
           
    }

  
    void Update()
    {

        anim.SetBool("enter", true);
        entering = true;

        /*
        if ((Input.GetMouseButtonDown(0) == true) || (Input.touchCount > 0))
        {
            anim.SetBool("enter", true);
            entering = true;

        }
        */
        if (entering == true)
        {
            wait += Time.deltaTime;

            if (wait > 3)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
}
