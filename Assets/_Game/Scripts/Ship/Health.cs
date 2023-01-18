using System;
using UnityEngine;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private SettingsManager _settings;
        private int _health;

        private void OnEnable()
        {
            _health = _settings._maxHealth;
        }

        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            _health = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
