using UnityEngine;

namespace Gameplay
{
    [CreateAssetMenu(fileName = "Gameplay Resources", menuName = "GameplayData/Resources", order = 0)]
    public class GameplayData : ScriptableObject
    {
        public const int MatrixSize = 3;
        
        public GameObject MatrixPrefab => _matrixPrefab;
        public GameObject FirstPlayer => _firstPlayerPrefab;
        public GameObject SecondPlayer => _secondPlayerPrefab;
        
        [SerializeField] private GameObject _matrixPrefab;
        [SerializeField] private GameObject _firstPlayerPrefab;
        [SerializeField] private GameObject _secondPlayerPrefab;
        
    }
}