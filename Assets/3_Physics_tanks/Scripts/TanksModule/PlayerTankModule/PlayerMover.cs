using UnityEngine;

namespace _0_3_Physics_tanks.Scripts.TanksModule.PlayerTankModule
{
    public class PlayerMover : MonoBehaviour 
    {
        [SerializeField] private float _speed = 10.0f;
        [SerializeField] private float _bodyRotationSpeed = 100.0f;
        [SerializeField] private float _gunRotationSpeed = 20f;
        [SerializeField] private Transform _transGun;

        private float _translation;
        private float _rotation;
        
        private void Update() 
        {
            _translation = Input.GetAxis("Vertical") * _speed;
            _rotation = Input.GetAxis("Horizontal") * _bodyRotationSpeed;

            if (Input.GetKey(KeyCode.T))
            {
                Rotate(-_gunRotationSpeed);
            } 
            else if (Input.GetKey(KeyCode.G)) 
            {
                Rotate(_gunRotationSpeed);
            } 
        }

        private void FixedUpdate()
        {
            transform.Translate(0, 0, _translation * Time.fixedDeltaTime);
            transform.Rotate(0, _rotation * Time.fixedDeltaTime, 0);
        }

        private void Rotate(float angle)
        {
            _transGun.RotateAround(_transGun.position, _transGun.right, angle * Time.deltaTime);
        }
    }
}