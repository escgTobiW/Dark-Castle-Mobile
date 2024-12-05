using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    //public GameObject Main;
    //public GameObject Options;


    // Start is called before the first frame update
    void Start()
    {
     
        //Options.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
     

    }



    public void Play()
    {
   
        SceneManager.LoadScene("Castle");
    }


    public void Quit()
    {
        
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }


}






