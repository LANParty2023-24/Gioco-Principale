using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{
    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsOwner){
            return;
        }
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal")*speed*Time.deltaTime,Input.GetAxis("Vertical")*speed*Time.deltaTime);
        
    }

}
