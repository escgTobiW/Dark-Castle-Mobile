using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{


    public RightButton()
    {

    }

    public bool buttonPress = false;

    void Start()
    {
        
    }

   
    void Update()
    {
 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPress = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPress = false;
    }
}
