using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlinkingLogic : MonoBehaviour
{
    [SerializeField] private SpriteRenderer blinkingSprite;
    

    void Start()
    {
        Invoke(nameof(Blink), 0.5f);
}
    // Update is called once per frame
    void Update()
    {
        
    }

    void Blink()
    {
        float randomChance = Random.Range(0, 1);
        float randomTimeToBlink = Random.Range(2, 4);
        float randomTimeToOpen = Random.Range(.1f, .15f);
        
        
        
        blinkingSprite.enabled = true;
        

        
            Invoke(nameof(Blink), randomTimeToBlink);
            Invoke(nameof(OpenEye), randomTimeToOpen);
        


    }

    void OpenEye()
    {
        blinkingSprite.enabled = false;
    }

}
