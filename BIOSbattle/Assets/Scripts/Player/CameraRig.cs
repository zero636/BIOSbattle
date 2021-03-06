using UnityEngine;

public class CameraRig : MonoBehaviour
{
    [Header("Parameters")] 
    [SerializeField] private Transform playerTransform;
    [SerializeField] private string playerTag;
    [SerializeField] private float movingSpeed;

    private void Awake()
    {
        // Проверка на нахождение трансформа игрока и присвоение по умолчанию тега Player
        if (this.playerTransform == null)
        {
            if (this.playerTag == "")
            {
                this.playerTag = "Player";
            }

            this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
        }

        this.transform.position = new Vector3()
        {
            x = this.playerTransform.position.x,
            y = this.playerTransform.position.y,
            z = this.playerTransform.position.z - 10,
        };
    }


    private void FixedUpdate()
    {
        if (!this.playerTransform) return;
        var target = new Vector3()
        {
            x = this.playerTransform.position.x,
            y = this.playerTransform.position.y,
            z = this.playerTransform.position.z - 10,
        };


        var pos = Vector3.Lerp(this.transform.position, target, this.movingSpeed * Time.fixedDeltaTime);

        this.transform.position = pos;
    }
}
