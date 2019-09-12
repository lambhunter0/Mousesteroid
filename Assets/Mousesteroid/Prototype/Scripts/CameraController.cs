using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float distanceFromPlane;
    [SerializeField] private float followDistance;
    [SerializeField] private float followOffset;
    [SerializeField] private float followSpeed = 2.0f;
    [SerializeField] private bool lookAtTarget;

    private Vector3 targetPosition;
    private Vector3 targetDirection;

    private void FixedUpdate()
    {
        Move();
        Look();
    }

    private void Move()
    {
        targetPosition = new Vector3(target.transform.position.x,  target.transform.position.y - followOffset, -distanceFromPlane);
        targetDirection = targetPosition - transform.position;
        transform.position += targetDirection * Time.deltaTime * followSpeed;
    }

    private void Look()
    {
        if (lookAtTarget)
        {
            transform.LookAt(target);
        }
    }
}
