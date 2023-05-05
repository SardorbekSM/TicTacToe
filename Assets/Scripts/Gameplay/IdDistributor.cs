using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class IdDistributor : MonoBehaviour
    {
        [SerializeField] private List<IdKeeper> _idKeepers = new List<IdKeeper>();
        
    }
}