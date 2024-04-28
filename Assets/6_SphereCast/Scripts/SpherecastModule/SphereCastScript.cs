using UnityEngine;

namespace _6_SphereCast.Scripts.SpherecastModule
{
    public class SphereCastScript : MonoBehaviour
    {
        public GameObject CurrentHitObject;
        public float CurrentHitDistance;
        
        [SerializeField] private float _radius = 1f;
        [SerializeField] private float _maxDistance = 10f;
        [SerializeField] private LayerMask _layerMask;
        
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
            if (Physics.SphereCast(_origin, _radius, _direction, out RaycastHit hit, _maxDistance, _layerMask))
            {
                CurrentHitObject = hit.transform.gameObject;
                CurrentHitDistance = hit.distance;
            }
            else
            {
                CurrentHitObject = null;
                CurrentHitDistance = _maxDistance;
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Debug.DrawLine(_origin, _origin + _direction * CurrentHitDistance);
            Gizmos.DrawWireSphere(_origin + _direction * CurrentHitDistance, _radius);
        }
    }
}