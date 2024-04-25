using UnityEngine;

namespace _2_Vector.Scripts.MovementModule
{
    public class TranslateMover : MonoBehaviour
    {
        [SerializeField] private Vector3 _movementDirection;
        [SerializeField] private float _movementSpeed;

        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            transform.Translate(_movementDirection.normalized * (_movementSpeed * Time.fixedDeltaTime));
        }
    }
}