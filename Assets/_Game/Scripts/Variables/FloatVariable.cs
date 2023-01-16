using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Variables
{
    [CreateAssetMenu(fileName = "new FloatVariable", menuName = "ScriptableObjects/Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject
    {
        [Range(0f, 10f)]
        public float _value;

    }
}
