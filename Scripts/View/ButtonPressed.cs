using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, BaapBaapHotaHai
{
    public static ButtonPressed _instance;
    public static ButtonPressed Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ButtonPressed();
            }
            return _instance;
        }
    }

    /*public bool _button_presssed { get => _pressed; set => value = _pressed; }*/
    [SerializeField] protected internal bool _pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Button Pressed...");
        UIController _controller = UIController.Instance;
        _pressed = true;
        _controller.CheckMovement();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Button Released...");
        UIController _controller = UIController.Instance;
        _pressed = false;
        _controller.CheckMovement();
    }
}
