using System.Collections;
using UnityEngine;

namespace _3_Physics_tanks.Scripts.ShellModule
{
    [RequireComponent(typeof(Rigidbody))]
    public class LookForward : MonoBehaviour
    {
        [SerializeField] private float _updatesPerSecond = 5f;
        
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            StartCoroutine(RotateForwardCoroutine(1f / _updatesPerSecond));
        }

        private IEnumerator RotateForwardCoroutine(float timeDelay)
        {
            while (true)
            {
                transform.forward = _rigidbody.velocity;
                yield return new WaitForSeconds(timeDelay);
            }
        }
    }
}