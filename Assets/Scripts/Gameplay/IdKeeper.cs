using UnityEngine;

namespace Gameplay
{
    public class IdKeeper : MonoBehaviour
    {
        private int _identifier;

        public void SetIdentifier(int id)
        {
            _identifier = id;
        }

        public int GetIdentifier()
        {
            return _identifier;
        }
    }
}