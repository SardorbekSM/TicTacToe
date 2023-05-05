using UnityEngine;

namespace Core.Transform
{
    public class TransformPosition : MonoBehaviour
    {
        [SerializeField] private Vector3 _position;

        public void SetPosition(GameObject prefab)
        {
            prefab.transform.localPosition = _position;
        }
    }
}