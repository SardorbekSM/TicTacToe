using UnityEngine;

namespace Gameplay
{
    public class DebugLog : MonoBehaviour
    {
        public void ShowLog()
        {
            Debug.Log($"This log is working!");
        }

        public void ShowLog(int number)
        {
            Debug.Log($"Number of log: {number}");
        }

        public void ShowLog(string text)
        {
            Debug.Log($"Log text: {text}");
        }
    }
}
