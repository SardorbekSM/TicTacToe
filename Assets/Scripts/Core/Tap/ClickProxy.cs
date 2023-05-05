using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core.Tap
{
    public class ClickProxy : MonoBehaviour
    {
        [SerializeField] private UnityEvent _clicked;
        
        private void OnMouseEnter()
        {
            _clicked.Invoke();
        }
    }
}