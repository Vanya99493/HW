using UnityEngine;

namespace _3_Physics_tanks.Scripts.TanksModule.Interfaces
{
    public interface IShoot
    {
        public void Shoot(Transform spawnTransform, float shootingSpeed);
    }
}