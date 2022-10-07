// Copyright (c) TigardHighGDC
// SPDX-License SPDX-License-Identifier: Apache-2.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public Rigidbody2D rb;
    private float force = 10.0f;
    bool hit = true;
    void Start()
    {
    }

    private void Update()
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
