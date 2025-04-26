using System;
using System.Collections;
using System.Collections.Generic;
using StateMachine;
using StateMachine.GameStates;
using UnityEngine;

[RequireComponent(typeof(MainMenuController))]
public class MainMenuFSM : StateMachineMB
{
    private MainMenuController _controller;
    
    public MainMenuState MainMenuState { get; private set; }


    private void Awake()
    {
        _controller = GetComponent<MainMenuController>();
       
        MainMenuState = new MainMenuState(this, _controller);
    }

    private void Start()
    {
        ChangeState(MainMenuState);
    }
}