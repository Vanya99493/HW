using UnityEngine;

namespace _0_3_Physics_tanks.Scripts.TanksModule.Interfaces
{
    public interface IShoot
    {
        public void Shoot(Transform spawnTransform, float shootingSpeed);
    }
}