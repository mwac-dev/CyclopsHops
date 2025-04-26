using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    public InputMap Input;
    
    
    private void Awake()
    {
        if (Instance == null && Instance != this)
        {
            Instance = this;
            Input = new InputMap();
            Input.Enable();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    //enable action map by name
    // public void EnableActionMap(string actionMapName)
    // {
    //
    //     //enable the action map by name
    //     Input.FindAction(actionMapName).Enable();
    // }


}
