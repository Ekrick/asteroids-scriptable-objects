using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Ship;
using UnityEngine;
using Variables;

public class PlayManager : MonoBehaviour
{

    
    [SerializeField] float _throttlePower;
    [SerializeField] float _rotationPower;
    public FloatVariable _throttleFV;
    public FloatVariable _rotationFV;

    

    private void Start()
    {
        _throttleFV._value = _throttlePower;
        _rotationFV._value = _rotationPower;
    }
}
