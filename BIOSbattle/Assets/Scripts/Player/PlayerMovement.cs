using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Animator _animator;
    
    
    [Header("Movement")]
    public float forceMovement = 0;
    public float routeMovement;
    
    [Header("Jump")]
    public float forceJump = 0;

    [SerializeField] private Vector2 checkGroundWidth;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask Ground;
    
    private bool onGround;
    
    
    
    private Rigidbody2D _rb2d;
    
    
    private static readonly int Jumping = Animator.StringToHash("Jump");
    private static readonly int Running = Animator.StringToHash("Running");


    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }


    private void Update()
    {
        routeMovement = Input.GetAxisRaw("Horizontal");
        
        CheckingGround();
        Jump();
    }

    private void FixedUpdate()
    {
        Movement();
        
    }
    

    private void Movement()
    {
        _rb2d.velocity = new Vector2(routeMovement * forceMovement, _rb2d.velocity.y);
        
        _animator.SetBool(Running, routeMovement != 0);
    }

    private void Jump()
    {
        var _jump = Input.GetKeyDown(KeyCode.Space) && onGround;


        if (_jump)
        {
            _rb2d.AddForce(Vector2.up * forceJump);
            
            _animator.SetBool(Jumping, true);
        }
        else
        {
            _animator.SetBool(Jumping, false);
        }
        
            
    }

    private void CheckingGround()
    {
        
        onGround = Physics2D.OverlapBox(GroundCheck.position, checkGroundWidth, 0, Ground);
    }
    
}
