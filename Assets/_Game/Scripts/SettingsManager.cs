using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class SettingsManager : ScriptableObject
{
    [Header("Ship")]
    public float _throttlePower;
    public float _rotationPower;
    public float _maxHealth;

}
