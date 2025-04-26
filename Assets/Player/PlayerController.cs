using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private int Idle = Animator.StringToHash("IdleAnimation");
    // Start is called before the first frame update
    void Start()
    {
        anim.CrossFade(Idle,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
