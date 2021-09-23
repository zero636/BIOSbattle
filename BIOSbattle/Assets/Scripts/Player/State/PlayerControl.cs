using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float health = 100;
    
    
    public void ApplyDamage(float damage)
    {
        health -= damage;
    }

    public bool Die()
    {
        return health <= 0;
    }
    
}
