using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEngine;
using Variables;

public class PlayManager : MonoBehaviour
{
    private GameObject _ship;
    private Engine _engine;
    
    [SerializeField] [Range (0, 10)] float _throttlePower;
    [SerializeField] [Range (0, 10)] float _rotationPower;


    private void Awake()
    {
        _ship = GameObject.FindGameObjectWithTag("Ship");
        _engine = _ship.GetComponent<Engine>();
    }

    private void Start()
    {
        _engine._throttle = _throttlePower;
        _engine._rotation = _rotationPower;
    }
}
