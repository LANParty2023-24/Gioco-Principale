using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using TMPro;
public class PlayerController : NetworkBehaviour
{
    //devo passarglielo da codice perchè è un prefab
    public TMP_Text classifica;
    private int lead = 0;
    private NetworkVariable<int> punteggio = new NetworkVariable<int>(0, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        classifica = GameObject.Find("classifica").GetComponent<TMP_Text>();
        speed = 5000;
        //GetLocalIPAddress();
        punteggio.OnValueChanged += OnMyNetworkVariableChanged;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner)
        {
            return;
        }
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.T))
        {
            punteggio.Value++;
        }
    }
    private void OnMyNetworkVariableChanged(int oldValue, int newValue)
    {
        // Log the changes on the server
        if (IsServer)
        {
            Debug.Log($"Server Log - Client {OwnerClientId}: myNetworkVariable changed from {oldValue} to {newValue}");
        }
        //TODO modificare la classifica su tutti i client a seconda del punteggio
        if(lead < newValue)
            classifica.text = OwnerClientId +" : "+newValue;
    }

    //private void updateLeaderboard(OwnerClientId,newValue){
    //    if(lead<newValue)
    //        hintText.text = OwnerClientId +" : "+newValue;
    //}

    //public string GetLocalIPAddress()
    //{
    //    var host = Dns.GetHostEntry(Dns.GetHostName());
    //    foreach (var ip in host.AddressList)
    //    {
    //        
    //        if (ip.AddressFamily == AddressFamily.InterNetwork)
    //        {
    //            Debug.Log(ip.ToString());
    //            hintText.text = ip.ToString();
    //            return ip.ToString();
    //        }
    //    }
    //    throw new System.Exception("No network adapters with an IPv4 address in the system!");
    //}

}
