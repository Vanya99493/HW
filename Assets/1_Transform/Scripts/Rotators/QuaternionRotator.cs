using UnityEngine;

namespace _1_Transform.Scripts.Rotators
{
    public class QuaternionRotator : MonoBehaviour
    {
        [SerializeField] protected Vector3 _rotationPerSecond;
        [SerializeField] protected float _speed = 1f;

        private void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            transform.rotation *= Quaternion.Euler(_rotationPerSecond * (_speed * Time.fixedDeltaTime));
        }
    }
}