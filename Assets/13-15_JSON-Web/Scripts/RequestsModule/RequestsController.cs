using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace _13_15_JSON_Web.Scripts.RequestsModule
{
    public class RequestsController : MonoBehaviour
    {
        public event Action<string> SuccessGetDataEvent;
        
        private const string URI = "https://airportgap.com/api/favorites";
        private const string AUTH_TOKEN = "Yz7JCVhupBSevBEoh82JdQG6";

        public IEnumerator Get()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(URI))
            {
                AddAuthorizationRequest(request);
                yield return request.SendWebRequest();
                
                if (request.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogError("Error downloading: " + request.error);
                }
                else
                {
                    string result = request.downloadHandler.text;
                    SuccessGetDataEvent?.Invoke(result);
                }
            }
        }

        public IEnumerator Post()
        {
            WWWForm form = new WWWForm();
            form.AddField("airport_id", "GKA");
            form.AddField("note", "qwerty1231231231");

            using (UnityWebRequest request = UnityWebRequest.Post(URI, form))
            {
                AddAuthorizationRequest(request);
                yield return request.SendWebRequest();
                
                if (request.result != UnityWebRequest.Result.Success) 
                {
                    Debug.LogError("Error uploading data: " + request.error);
                } 
                else 
                {
                    Debug.Log("Data uploaded successfully");
                }
            }
        }

        private void AddAuthorizationRequest(UnityWebRequest request)
        {
            request.SetRequestHeader("Authorization", $"Bearer token={AUTH_TOKEN}");
        }
    }
}