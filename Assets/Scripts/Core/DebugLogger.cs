using UnityEngine;

namespace Core
{
    public class DebugLogger : MonoBehaviour
    {
        public void ShowLog(string text)
        {
            Debug.Log($"DEBUG.LOG: {text}");
        }
    }
}
