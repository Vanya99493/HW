using UnityEngine;

namespace _1_Transform.Scripts.Rotators
{
    public class EulerAngelsRotator : MonoBehaviour
    {
        [SerializeField] protected Vector3 _rotationPerSecond;
        [SerializeField] protected float _speed = 1f;

        public void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            transform.eulerAngles += _rotationPerSecond * (_speed * Time.fixedDeltaTime);
        }
    }
}