using UnityEngine;

namespace StateMachine.GameStates
{
    public class GameSetupState : State
    {
        private GameFSM _stateMachine;
        private GameController _controller;
        
        public GameSetupState(GameFSM stateMachine, GameController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public override void Enter()
        {
            base.Enter();
            
            Debug.Log("STATE: Game Setup");
            Debug.Log("Initializing Game...");
            _controller.stateText.text = "GameSetupState";
            _controller.gameSetUpUI.SetActive(true);
            _controller.gameSetUpButton.onClick.AddListener(OnGameSetUpButtonClicked);
            _controller.playerWeaponFollowLogic.enabled = false;
        }

        private void OnGameSetUpButtonClicked()
        {
            _controller.gameSetUpUI.SetActive(false);
            _controller.gameSetUpButton.onClick.RemoveListener(OnGameSetUpButtonClicked);
            _stateMachine.ChangeState(_stateMachine.PlayState);
        }

        public override void Exit()
        {
            base.Exit();
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