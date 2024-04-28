using System;
using UnityEngine;

namespace _3_Physics_tanks.Scripts.PhysicsTestModule
{
    [RequireComponent(typeof(Rigidbody))]
    public class PhysicsTest : MonoBehaviour
    {
        [SerializeField] private float _value;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            AddForce();
        }

        private void FixedUpdate()
        {
            //AddTorque();
        }

        private void AddTorque()
        {
            float input = Input.GetAxis("Vertical");
            _rigidbody.AddTorque(Vector3.forward * input * _value * Time.fixedDeltaTime);
        }

        private void AddForce()
        {
            _rigidbody.AddForce(_value * new Vector3(-0.5f, 1f ,0f) * Time.fixedDeltaTime, ForceMode.Force);
        }
    }
}