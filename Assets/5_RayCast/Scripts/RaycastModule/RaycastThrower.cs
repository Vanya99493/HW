using UnityEngine;

namespace _5_RayCast.Scripts.RaycastModule
{
    public class RaycastThrower : MonoBehaviour
    {
        [SerializeField] private float _distance;
        
        private Camera _mainCamera;

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
                Debug.DrawRay(ray.origin, ray.direction * _distance, Color.red);

                RaycastHit[] hits = Physics.RaycastAll(ray.origin, ray.direction, _distance);
                for (int i = 0; i < hits.Length; i++)
                {
                    Debug.Log("Hit object: " + hits[i].transform.name);
                }
            }
        }
    }
}