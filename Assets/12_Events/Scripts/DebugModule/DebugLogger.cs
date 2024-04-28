using UnityEngine;

namespace _12_Events.Scripts.DebugModule
{
    public class DebugLogger : MonoBehaviour
    {
        public void DebugMessage(string message)
        {
            Debug.Log(message);
        }
    }
}