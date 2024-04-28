using UnityEngine;

namespace _1_Transform.Scripts.Rotators
{
    public class EulerAngelsRotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotationPerSecond;
        [SerializeField] private float _speed = 1f;
        [SerializeField] private Vector3 _rotation;

        private void Start()
        {
            transform.eulerAngles = _rotation;
            _rotation = Vector3.zero;
        }

        private void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            Vector3 angle = _rotationPerSecond * (_speed * Time.fixedDeltaTime);
            transform.eulerAngles += angle;
            TrekRotation(angle);
        }

        private void TrekRotation(Vector3 angle)
        {
            _rotation += new Vector3(Mathf.Abs(angle.x), Mathf.Abs(angle.y), Mathf.Abs(angle.z));

            if (_rotation.x % 360 > 0)
            {
                Debug.Log($"{gameObject.name} turn around oX");
                _rotation.x -= 360;
            }
            if (_rotation.y % 360 > 0)
            {
                Debug.Log($"{gameObject.name} turn around oY");
                _rotation.y -= 360;
            }
            if (_rotation.z % 360 > 0)
            {
                Debug.Log($"{gameObject.name} turn around oZ");
                _rotation.z -= 360;
            }
        }
    }
}