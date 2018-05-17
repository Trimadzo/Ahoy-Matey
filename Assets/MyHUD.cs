using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour
{

    private NetworkManager networkManager;

    void Start()
    {
        networkManager = GetComponent<NetworkManager>();
    }

    public void MyStartHost()
    {
        Debug.Log("Starting Host at " + Time.timeSinceLevelLoad);
        networkManager.StartHost();
    }

    void OnStartHost()
    {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }

}
