using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Web
{
    public class Game : MonoBehaviour
    {
        private const string URL = "https://airportgap.com/api/favorites";
        private const string AUTH_TOKEN = "Yz7JCVhupBSevBEoh82JdQG6";

        private void Start()
        {
            StartCoroutine(Authorize());
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                StartCoroutine(Get());
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                StartCoroutine(Post());
            }
        }

        private IEnumerator Authorize()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(URL))
            {
                AddAuthorizationRequest(request);
                
                yield return request.SendWebRequest();
                
                if (request.result != UnityWebRequest.Result.Success)
                {
                    Debug.LogError("Error: " + request.error);
                }
            }
        }

        private IEnumerator Get()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(URL))
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
                    RootObject rootObject = JsonUtility.FromJson<RootObject>(result);
                    foreach (var data in rootObject.data)
                    {
                        Debug.Log(data);
                    }
                }
            }
        }

        private IEnumerator Post()
        {
            string postDataStr = JsonUtility.ToJson(CreateRootObject());
            //string postDataStr = "{\"airport_id\": \"GKA\", \"note\": \"qwerty1\"}";

            using (UnityWebRequest request = UnityWebRequest.Post(URL, postDataStr))
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

        private RootObject CreateRootObject()
        {
            return new RootObject
            {
                data = new List<Data>
                {
                    new Data
                    {
                        type = "favorite",
                        attributes = new Attributes
                        {
                            airport = new Airport
                            {
                                id = 4,
                                name = "Nadzab Airport",
                                city = "Nadzab",
                                country = "Papua New Guinea",
                                iata = "LAE",
                                icao = "AYNZ",
                                latitude = "-6.569803",
                                longitude = "146.725977",
                                altitude = 239,
                                timezone = "Pacific/Port_Moresby"
                            },
                            note = "qwerty"
                        }
                    }
                }
            };
        }
    }
}