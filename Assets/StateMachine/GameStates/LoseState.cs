using UnityEngine;

namespace StateMachine.GameStates
{
    public class LoseState : State
    {
        private GameFSM _stateMachine;
        private GameController _controller;
        
        public LoseState(GameFSM stateMachine, GameController controller)
        {
            _stateMachine = stateMachine;
            _controller = controller;
        }

        public override void Enter()
        {
            base.Enter();
            
            Debug.Log("STATE: LoseState Entered");
            Debug.Log("YOU LOSE DUN DUN DUNNNN!");
            _controller.stateText.text = "LoseState :(";
            _controller.audioSource.PlayOneShot(_controller.loseSound);
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