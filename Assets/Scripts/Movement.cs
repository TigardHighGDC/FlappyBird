using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 800f;
    public bool canJump = true;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            canJump = false;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            canJump = true;
        }
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "end")
        {
            Destroy(gameObject);
        }
    }
}
