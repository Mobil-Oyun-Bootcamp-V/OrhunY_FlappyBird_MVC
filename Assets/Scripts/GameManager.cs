using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerView _view;
    private PlayerController _controller;
    public int _pipeCount;
    public GameObject pipePref;

    private void Start()
    {
        _controller = new PlayerController(_view);
        InvokeRepeating("CreateObsticles", 1, 5);
    }

    public void CreateObsticles()
    {
        ObjectPooler.GetInstance().Initialize(_pipeCount, pipePref);
        ObjectPooler.GetInstance().MovePipe();
    }
    
}
