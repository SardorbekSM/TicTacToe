using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core.Tap
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class ClickProxy : MonoBehaviour
    {
        [SerializeField] private UnityEvent _clicked;
        
        private void OnMouseDown()
        {
            _clicked.Invoke();
        }
    }
}