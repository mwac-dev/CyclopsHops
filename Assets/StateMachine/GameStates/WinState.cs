using UnityEngine;

namespace StateMachine.GameStates
{
    public class WinState : State
    {
        private GameFSM _stateMachine;
        private GameController _controller;
        
        public WinState(GameFSM stateMachine, GameController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public override void Enter()
        {
            base.Enter();
            
            Debug.Log("STATE: WinState Entered");
            Debug.Log("YOU WIN!");
            _controller.stateText.text = "WinState";
            _controller.audioSource.PlayOneShot(_controller.winSound);
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