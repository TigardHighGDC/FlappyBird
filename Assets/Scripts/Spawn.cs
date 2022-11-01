// Copyright (c) TigardHighGDC
// SPDX-License SPDX-License-Identifier: Apache-2.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float endTimer = 5f;
    private float timer;
    public GameObject pipe;

    private void Start()
    {
        timer = endTimer;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position + new Vector3(0, Random.Range(-3f, 3f), 0), Quaternion.identity);
            timer = endTimer;
        }
    }
}
