using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.OnScreen;

public class MagicJoystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] Transform joystickT;
    [SerializeField] OnScreenStick stick;

    MyInputAction inputs;

    void Start()
    {
        inputs = new MyInputAction();
        inputs.Enable();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        joystickT.position = inputs.Player.ClickPosition.ReadValue<Vector2>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        stick.OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        stick.OnPointerUp(eventData);
    }
}
