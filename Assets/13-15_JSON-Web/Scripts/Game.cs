using _13_15_JSON_Web.Scripts.DataStructures;
using _13_15_JSON_Web.Scripts.RequestsModule;
using UnityEngine;

namespace _13_15_JSON_Web.Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private RequestsController _requestsController;

        private void Start()
        {
            _requestsController.SuccessGetDataEvent += OnSuccessGetRequest;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                StartCoroutine(_requestsController.Get());
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                StartCoroutine(_requestsController.Post());
            }
        }

        private void OnSuccessGetRequest(string jsonData)
        {
            RootObject rootObject = JsonUtility.FromJson<RootObject>(jsonData);
            foreach (var data in rootObject.data)
            {
                Debug.Log(data);
            }
        }
    }
}