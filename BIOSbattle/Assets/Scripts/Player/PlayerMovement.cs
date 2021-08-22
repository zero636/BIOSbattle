using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [Header("Movement")]
    public float forceMovement = 0;
    
    private float routeMovement;
    
    [Header("Jump")]
    public float forceJump = 0;

    [SerializeField] private Vector2 checkGroundWidth;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask Ground;
    
    private bool onGround;
    
    
    
    private Rigidbody2D _rb2d;

    

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
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
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            _rb2d.AddForce(Vector2.up * forceJump);
        }
    }

    private void CheckingGround()
    {
        
        onGround = Physics2D.OverlapBox(GroundCheck.position, checkGroundWidth, 0, Ground);
    }
    
}
