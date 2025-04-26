using UnityEngine;
using UnityEngine.SceneManagement;

namespace StateMachine.GameStates
{
    public class MainMenuState : State
    {
        private MainMenuFSM _stateMachine;
        private MainMenuController _controller;
        
        public MainMenuState(MainMenuFSM stateMachine, MainMenuController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public override void Enter()
        {
            base.Enter();
            
            Debug.Log("STATE: MainMenuState Entered");
            Debug.Log("Waiting for player to start game...");
            _controller.stateText.text = "MainMenuState";
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
            
            if(_controller.GameStarted)
                SceneManager.LoadScene("GameplayScene");
               
        }
    }
}