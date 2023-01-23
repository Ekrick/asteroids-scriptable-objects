using System;
using System.Collections;
using System.Collections.Generic;
using Asteroids;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class SettingsManager : ScriptableObject
{
    [Header("Ship")]
    public float _throttlePower;
    public float _rotationPower;
    public int _maxHealth;

    [Header("Asteroid")]
    public float _minForce;
    public float _maxForce;
    public float _minSize;
    public float _maxSize;
    public float _minTorque;
    public float _maxTorque;

}
