using UnityEngine;

namespace _3_Physics_tanks.Scripts.TanksModule.EnemyTankModule
{
    [RequireComponent(typeof(AngleCalculator))]
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private GameObject _target;
        [SerializeField] private Transform _turretBase;
        [SerializeField] private float _speed = 15.0f;
        [SerializeField] private float _rotSpeed = 5.0f;
        [SerializeField] private float _moveSpeed = 1.0f;

        private AngleCalculator _angleCalculator;

        private void Start()
        {
            _angleCalculator = GetComponent<AngleCalculator>();
            _angleCalculator.Initialize(_target, _speed);
        }
        
        private void Update()
        {
            RotateBody();
            RotateTurret();

            MoveIfFar();
        }

        private void RotateBody()
        {
            Vector3 direction = (_target.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0.0f, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * _rotSpeed);
        }

        private void RotateTurret() 
        {
            if (_angleCalculator.Angle != null) 
            {
                _turretBase.localEulerAngles = new Vector3(360.0f - (float)_angleCalculator.Angle, 0.0f, 0.0f);
            }
        }

        private void MoveIfFar()
        {
            if (_angleCalculator.Angle == null)
            {
                transform.Translate(0.0f, 0.0f, Time.deltaTime * _moveSpeed);
            }
        }
    }
}