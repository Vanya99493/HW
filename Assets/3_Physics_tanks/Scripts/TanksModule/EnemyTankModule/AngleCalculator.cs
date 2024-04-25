using System.Collections;
using UnityEngine;

namespace _0_3_Physics_tanks.Scripts.TanksModule.EnemyTankModule
{
    public class AngleCalculator : MonoBehaviour
    {
        [SerializeField] private bool _isLow = true;
        [SerializeField] private float _updatesPreSecond = 1f;
        
        private GameObject _target;
        private float _speed;
        
        public float? Angle { get; private set; }

        private void Start()
        {
            StartCoroutine(CalculateAngleCoroutine(1f / _updatesPreSecond));
        }

        public void Initialize(GameObject target, float speed)
        {
            _target = target;
            _speed = speed;
        }
        
        private IEnumerator CalculateAngleCoroutine(float timeDelay) 
        {
            while (true)
            {
                if (_target == null)
                {
                    yield return null;
                }
                
                Vector3 targetDir = _target.transform.position - transform.position;
                float y = targetDir.y;
                targetDir.y = 0.0f;
                float x = targetDir.magnitude - 1.0f;
                float gravity = 9.8f;
                float sSqr = _speed * _speed;
                float underTheSqrRoot = (sSqr * sSqr) - gravity * (gravity * x * x + 2 * y * sSqr);

                if (underTheSqrRoot >= 0.0f) 
                {
                    float root = Mathf.Sqrt(underTheSqrRoot);
                    float highAngle = sSqr + root;
                    float lowAngle = sSqr - root;

                    if (_isLow)
                    {
                        Angle = Mathf.Atan2(lowAngle, gravity * x) * Mathf.Rad2Deg;
                    }
                    else
                    {
                        Angle = Mathf.Atan2(highAngle, gravity * x) * Mathf.Rad2Deg;
                    }
                }
                else
                {
                    Angle = null;
                }

                yield return new WaitForSeconds(timeDelay);
            }
        }
    }
}