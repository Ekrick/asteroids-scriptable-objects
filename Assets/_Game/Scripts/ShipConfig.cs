using UnityEngine;
using Variables;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Ship Config", menuName = "ScriptableObjects/ShipConfig", order = 0)]
    public class ShipConfig : ScriptableObject
    {
        public FloatVariable _trottle;
        public FloatVariable _rotation;
    }
    
}
