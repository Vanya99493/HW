using UnityEngine;

namespace _3_Physics_tanks.Scripts.ShellModule
{
    public class ShellDestroyer : MonoBehaviour
    {
        private const string ON_DESTROY_TAG = "tank";
        
        [SerializeField] private ParticleSystem _psExplosion;
        
        private void Start()
        {
            Destroy(gameObject, 5);  
        }
        
        private void OnCollisionEnter(Collision col) {

            if (col.gameObject.tag == ON_DESTROY_TAG) 
            {
                CreateExplosionParticleSystem();
                Destroy(gameObject);
            }
        }

        private void CreateExplosionParticleSystem()
        {
            ParticleSystem psExplosion = Instantiate(_psExplosion, transform.position, Quaternion.identity);
            Destroy(psExplosion.gameObject, 0.5f);
        }
    }
}