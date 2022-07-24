using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ServiceButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private UnityEvent _down;
    [SerializeField] private UnityEvent _up;
    [SerializeField] private UnityEvent _enter;
    [SerializeField] private UnityEvent _exit;
    [SerializeField] private bool _isExit;

    public bool IsExit { get => _isExit; }

    public void OnPointerDown(PointerEventData eventData) => _down?.Invoke();

    public void OnPointerUp(PointerEventData eventData) => _up?.Invoke();

    public void OnPointerEnter(PointerEventData eventData) => _enter?.Invoke();

    public void OnPointerExit(PointerEventData eventData) => _exit?.Invoke();

}