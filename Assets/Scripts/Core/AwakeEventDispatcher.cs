using System;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class AwakeEventDispatcher : MonoBehaviour
    {
        [SerializeField] private UnityEvent _awakened;

        private void Awake()
        {
            _awakened.Invoke();
        }
    }
}