using UnityEngine;

namespace _6_SphereCast.Scripts.SpherecastModule
{
    public class SphereCastScript : MonoBehaviour
    {
        public GameObject CurrentHitObject;
        public float CurrentHitDistance;
        
        [SerializeField] private float Radius = 1f;
        [SerializeField] private float MaxDistance = 10f;
        [SerializeField] private LayerMask LayerMask;
        
        private Vector3 _origin;
        private Vector3 _direction;

        private void Start()
        {
            _direction = transform.forward;
        }

        private void Update()
        {
            CastSphere();
        }

        private void CastSphere()
        {
            _origin = transform.position; 
            if (Physics.SphereCast(_origin, Radius, _direction, out RaycastHit hit, MaxDistance, LayerMask))
            {
                CurrentHitObject = hit.transform.gameObject;
                CurrentHitDistance = hit.distance;
            }
            else
            {
                CurrentHitObject = null;
                CurrentHitDistance = MaxDistance;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Debug.DrawLine(_origin, _origin + _direction * CurrentHitDistance);
            Gizmos.DrawWireSphere(_origin + _direction * CurrentHitDistance, Radius);
        }
    }
}