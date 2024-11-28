using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public JumpButton()
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
