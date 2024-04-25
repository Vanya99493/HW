using _0_3_Physics_tanks.Scripts.ShellModule.View;
using _0_3_Physics_tanks.Scripts.TanksModule.Interfaces;
using UnityEngine;

namespace _0_3_Physics_tanks.Scripts.TanksModule.EnemyTankModule
{
    [RequireComponent(typeof(AngleCalculator))]
    public class EnemyShoot : MonoBehaviour, IShoot
    {
        [SerializeField] private ShellView _shellPrefab;
        [SerializeField] private Transform _gunTransform;
        [SerializeField] private float _shootingSpeed = 15f;
        [SerializeField] private float _shootingCooldown = 1f;

        private AngleCalculator _angleCalculator;
        private float _cooldown = 0f;

        private void Start()
        {
            _angleCalculator = GetComponent<AngleCalculator>();
        }
        
        private void Update()
        {
            if (_cooldown > 0)
            {
                _cooldown -= Time.deltaTime;
            }
            else if (_angleCalculator.Angle != null)
            {
                Shoot(_gunTransform, _shootingSpeed);
            }
        }

        public void Shoot(Transform spawnTransform, float shootingSpeed)
        {
            if (_cooldown > 0)
            {
                return;
            }
            
            _cooldown = _shootingCooldown;
            ShellView shell = Instantiate(_shellPrefab, spawnTransform.position, spawnTransform.rotation);
            shell.gameObject.GetComponent<Rigidbody>().velocity = _shootingSpeed * spawnTransform.forward;
        }
    }
}