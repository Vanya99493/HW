using UnityEngine;

namespace _2_Vector.Scripts.MovementModule
{
    public class AddVectorMover : MonoBehaviour
    {
        [SerializeField] private Vector3 _movementDirection;
        [SerializeField] private float _movementSpeed;

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            transform.position += _movementDirection.normalized * (_movementSpeed * Time.fixedDeltaTime);
        }
    }
}