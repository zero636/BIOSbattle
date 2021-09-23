using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speedMove;
    [SerializeField] private Transform target;

    private void Update()
    {
        Movement();
    }


    private void Movement()
    {
        var direction = (target.transform.position - transform.position).normalized;
        transform.Translate(direction * speedMove * Time.deltaTime);
    }
}
