using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class WeaponFollow : MonoBehaviour
{
    //get reference to rigidbody
    public Rigidbody2D rb;
    public Transform pivot;
    public SpringJoint2D spring;

    private float _initialSpringDistance;
    private Sequence _tweenSequence;

    private void OnEnable()
    {
        InputManager.Instance.Input.Movement.TouchTap.performed +=  Jab;
        InputManager.Instance.Input.Movement.TouchHold.performed += WindUp;
        InputManager.Instance.Input.Movement.TouchSlowTap.performed += StrongJab;
    }
    
    private void OnDisable()
    {
        InputManager.Instance.Input.Movement.TouchTap.performed -= Jab;
        InputManager.Instance.Input.Movement.TouchHold.performed -= WindUp;
        InputManager.Instance.Input.Movement.TouchSlowTap.performed -= StrongJab;
    }

    private void Start()
    { 
         
        _initialSpringDistance = spring.distance;
    }

    private void FixedUpdate()
    {

        //use new input system to get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(InputManager.Instance.Input.Movement.TouchPosition.ReadValue<Vector2>());



        var angle = (Mathf.Atan2(mousePos.y  - pivot.position.y, mousePos.x - pivot.position.x) *
                     Mathf.Rad2Deg);
        
        rb.MoveRotation(angle);
        
    }
    

    private  void Jab(InputAction.CallbackContext context)
    {
        spring.distance = _initialSpringDistance;
        rb.AddForce(transform.right * 2, ForceMode2D.Impulse);
    }
    
    
    private void WindUp(InputAction.CallbackContext context)
    {
        
        _tweenSequence = DOTween.Sequence();
        _tweenSequence.Append(DOVirtual.Float(spring.distance, 0.4f, 1f, SetSpringDistance));
        
    }

    //gets set by DOTween virtual float callback
    private void SetSpringDistance(float value)
    {
        spring.distance = value;
    }

    private void StrongJab(InputAction.CallbackContext context)
    {
       _tweenSequence.Kill();
       rb.AddForce(transform.right * 6, ForceMode2D.Impulse);
        spring.distance = _initialSpringDistance;
    }
    


}
