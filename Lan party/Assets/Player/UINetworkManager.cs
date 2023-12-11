using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
public class UINetworkManager : MonoBehaviour
{
    [SerializeField]private Button startHost;
    [SerializeField]private Button startClient;
    [SerializeField]private Button startServer;

    void Start(){
        
    }

    private void Awake(){
        startHost.onClick.AddListener(()=>{
            NetworkManager.Singleton.StartHost();
        });
        startClient.onClick.AddListener(()=>{
            NetworkManager.Singleton.StartClient();
        });
        startServer.onClick.AddListener(()=>{
            NetworkManager.Singleton.StartServer();
        });
    }
}
