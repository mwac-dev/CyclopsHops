using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class EyeMovement : MonoBehaviour
{
 [SerializeField] Transform playerEyeTransform;



 [SerializeField]float maxX = 0.5f;
 [SerializeField] float minX = 0.5f;
 [SerializeField] float maxY = 0.5f;
 [SerializeField] float minY = 0.5f;
 
 Vector3 targetPos = new Vector3(0,0,10);



    // Update is called once per frame
    void Update()
    {
         Vector3 mousePos = Camera.main.ScreenToWorldPoint(InputManager.Instance.Input.Movement.TouchPosition.ReadValue<Vector2>());
         mousePos.z = 10f;

         Vector3 direction = (mousePos - playerEyeTransform.position ).normalized;
         direction.x = Mathf.Clamp(direction.x, minX,maxX);
         direction.y = Mathf.Clamp(direction.y, minY, maxY);
         
 

        playerEyeTransform.localPosition = Vector3.Lerp(playerEyeTransform.localPosition, direction * 1f, 4f * Time.deltaTime);


    }
}
