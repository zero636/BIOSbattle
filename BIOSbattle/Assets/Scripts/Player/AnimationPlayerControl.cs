using System;
using UnityEngine;

public class AnimationPlayerControl : MonoBehaviour
{
    private Animator _animator;


    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    private void Update()
    {
        _animator.SetBool("Running", Input.GetAxis("Horizontal") != 0);
        
        _animator.SetBool("Jump", Input.GetKeyDown(KeyCode.Space));
    }
    
    
}
