using System;
using System.Collections;
using System.Collections.Generic;
using StateMachine;
using StateMachine.GameStates;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    private GameController _controller;
    

    public GameSetupState SetupState { get; private set; }
    public GamePlayState PlayState { get; private set; }
    
    public WinState WinState { get; private set; }
    public LoseState LoseState { get; private set; }

    private void Awake()
    {
        _controller = GetComponent<GameController>();
        
        WinState = new WinState(this, _controller);
        LoseState = new LoseState(this, _controller);
        SetupState = new GameSetupState(this, _controller);
        PlayState = new GamePlayState(this, _controller);

    }

    private void Start()
    {
        ChangeState(SetupState);
    }
}
