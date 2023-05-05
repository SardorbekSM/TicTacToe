using Core;
using UnityEngine;

namespace Gameplay
{
    public class MatrixManager : MonoBehaviour
    {
        [SerializeField] private GameplayData _data;
        [SerializeField] private UnityGameObjectEvent _matrixInitialized;
        
        public void Initialize()
        {
            var matrix = Instantiate(_data.MatrixPrefab);
        }
    }
}