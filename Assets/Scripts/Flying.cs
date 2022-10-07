using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public Rigidbody2D rb;
    float force = 10.0f;
    bool hit = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && hit)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.up * force, ForceMode2D.Impulse);
            hit = false;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            hit = true;
        }
    }
}
