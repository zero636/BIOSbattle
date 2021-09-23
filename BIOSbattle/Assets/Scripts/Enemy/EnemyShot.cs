using UnityEngine;

public class EnemyShot : MonoBehaviour
{

    [SerializeField] private PlayerControl _playerControl;

    [SerializeField] private float amountDamage = 1;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (!other.TryGetComponent(out PlayerControl playerControl)) return;
        
        playerControl.ApplyDamage(amountDamage);

    }

    
    
}
