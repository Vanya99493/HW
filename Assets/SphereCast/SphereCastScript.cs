using UnityEngine;

public class SphereCastScript : MonoBehaviour
{
    public GameObject CurrentHitObject;
    public float CurrentHitDistance;
    
    public float Radius = 1f;
    public float MaxDistance = 10f;
    public LayerMask LayerMask;
    
    private Vector3 _origin;
    private Vector3 _direction;

    private void Start()
    {
        _direction = transform.forward;
    }

    private void Update()
    {
        _origin = transform.position; 
        RaycastHit hit;
        if (Physics.SphereCast(_origin, Radius, _direction, out hit, MaxDistance, LayerMask))
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
