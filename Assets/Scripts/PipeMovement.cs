// Copyright (c) TigardHighGDC
// SPDX-License SPDX-License-Identifier: Apache-2.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.position = transform.position + new Vector3(-1, 0, 0) * speed *Time.deltaTime;
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
