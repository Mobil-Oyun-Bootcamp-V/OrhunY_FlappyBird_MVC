using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerView _view;
    private PlayerController _controller;

    private void Start()
    {
        _controller = new PlayerController(_view);
    }
}
