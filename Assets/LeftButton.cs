using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public LeftButton()
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
