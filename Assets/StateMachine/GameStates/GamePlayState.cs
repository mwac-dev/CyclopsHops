using Unity.VisualScripting;
using UnityEngine;

namespace StateMachine.GameStates
{
    public class GamePlayState : State
    {
        private GameFSM _stateMachine;
        private GameController _controller;
        
        
        public GamePlayState(GameFSM stateMachine, GameController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public override void Enter()
        {
            base.Enter();
            
            _controller.playerOnCollideLogic.OnPlayerLost += OnPlayerLost;
            _controller.playerOnCollideLogic.OnPlayerWon += OnPlayerWon;
            _controller.stateText.text = "GamePlayState";
            _controller.playerWeaponFollowLogic.enabled = true;
            
            Debug.Log("STATE: GamePlayState Entered");
            Debug.Log("Game has started");
        }
        
        private void OnPlayerLost()
        {
            _stateMachine.ChangeState(_stateMachine.LoseState);
        }
        
        private void OnPlayerWon()
        {
            _stateMachine.ChangeState(_stateMachine.WinState);
        }

        public override void Exit()
        {
            base.Exit();
            _controller.playerOnCollideLogic.OnPlayerLost -= OnPlayerLost;
            _controller.playerOnCollideLogic.OnPlayerWon -= OnPlayerWon;
            _controller.playerWeaponFollowLogic.enabled = false;
        }

        public override void FixedTick()
        {
            base.FixedTick();
        }

        public override void Tick()
        {
            base.Tick();
        }
    }
}