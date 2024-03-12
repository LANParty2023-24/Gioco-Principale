using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Vertical", movement.x);
        animator.SetFloat("Horizontal", movement.y);

        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -8.7f, 8.7f), Mathf.Clamp(this.transform.position.y, -4.5f, 3.7f), 0);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}