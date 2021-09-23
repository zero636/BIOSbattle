using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    private float moveUp;
    private float _gravityScale;


    private void OnTriggerEnter2D(Collider2D other)
    {
        _gravityScale = _rigidbody2D.gravityScale;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        var obj = other.gameObject;
        
        if (!obj.CompareTag("Player")) return;

        
        
        moveUp = Input.GetAxisRaw("Vertical");

        _rigidbody2D.gravityScale = 0;
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, moveUp * speed);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _rigidbody2D.gravityScale = _gravityScale;
    }
}
