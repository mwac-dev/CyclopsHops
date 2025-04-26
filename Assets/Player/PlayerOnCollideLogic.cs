using System;
using UnityEngine;

namespace Player
{
    public class PlayerOnCollideLogic : MonoBehaviour
    {
        public Action OnPlayerLost;
        
        public Action OnPlayerWon;


        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.CompareTag("Lose"))
            {
                OnPlayerLost?.Invoke();
            }
            
            if (col.gameObject.CompareTag("Win"))
            {
                OnPlayerWon?.Invoke();
            }
        }
    }
}