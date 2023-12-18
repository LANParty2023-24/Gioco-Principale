using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Rigidbody2D rb;

    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal")*Time.fixedDeltaTime,transform.position.y + Input.GetAxis("Vertical")*Time.fixedDeltaTime);
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed,Input.GetAxis("Vertical")*Time.deltaTime*speed);
    }
}
